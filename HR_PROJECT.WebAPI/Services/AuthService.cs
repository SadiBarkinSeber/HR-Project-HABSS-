using HR_PROJECT.Application.Features.CQRS.Commands.ApplicationUserCommands;
using HR_PROJECT.Application.Features.CQRS.Handlers.AdvanceHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Handlers.ApplicationuserHandlers.Write;
using HR_PROJECT.Domain.Entities;
using HR_PROJECT.WebAPI.DTOs.ApplicationUserDTOs;
using HR_PROJECT.WebAPI.HelperFunctions;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Web.Mvc;

namespace HR_PROJECT.WebAPI.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly UpdateApplicationuserCommandHandler _handler;
        private readonly CreateRandomPassword _createRandomPassword;

        public AuthService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, UpdateApplicationuserCommandHandler handler, CreateRandomPassword createRandomPassword)
        {
            _configuration = configuration;
            _userManager = userManager;
            _roleManager = roleManager;
            _handler = handler;
            _createRandomPassword = createRandomPassword;
        }

        public async Task<(int, string)> Login(LoginApplicationUserDTO dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user == null)
            {
                return (0, "Invalid username");
            }

            if (dto.OneTimeCode == user.OneTimePassword)
            {
                return (2, "Password change.");
            }

            if (!await _userManager.CheckPasswordAsync(user, dto.Password))
            {
                return (0, "Invalid password");
            }

            var userRoles = await _userManager.GetRolesAsync(user);
            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            foreach (var userRole in userRoles)
            {
                authClaims.Add(new Claim(ClaimTypes.Role, userRole));
            }


            if(user.EmployeeId != null)
                authClaims.Add(new Claim(ClaimTypes.NameIdentifier, user.EmployeeId.ToString()));
            if (user.ManagerId != null)
                authClaims.Add(new Claim(ClaimTypes.NameIdentifier, user.ManagerId.ToString()));
            if (user.SiteManagerId != null)
                authClaims.Add(new Claim(ClaimTypes.NameIdentifier, user.SiteManagerId.ToString()));




            string token = GenerateToken(authClaims);

            return (1, token);
        }


        public async Task<(int, string)> ResetPassword(ChangePasswordForResetDTO dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user == null)
            {
                return (0, "User not found.");
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

            var result = await _userManager.ResetPasswordAsync(user, token, dto.Password);

            if (result.Succeeded)
            {
                var changes = new UpdateApplicationUserCommand()
                {
                    Id = user.Id,
                    OneTimePassword = null
                };

                _handler.Handle(changes);

                return (1, $"Password reset successfully. {user.OneTimePassword}");
            }
            else
            {
                return (0, string.Join(", ", result.Errors.Select(error => error.Description)));
            }
        }

        public async Task<(int, CreateUserResponseDTO)> CreateUser(CreateApplicationUserDTO dto)
        {
            CreateUserResponseDTO response = new CreateUserResponseDTO();
            try
            {
                
                if (dto.UserName == null || dto.Firstname == null || dto.Lastname == null)
                {
                    throw new ArgumentException("Invalid model.");
                }

                ApplicationUser user = new ApplicationUser()
                {
                    UserName = dto.UserName,
                    Email = dto.Email,
                    FirstName = dto.Firstname,
                    LastName = dto.Lastname
                };

                string password = _createRandomPassword.GenerateRandomString(6);

                IdentityResult result = await _userManager.CreateAsync(user, password);

                if (result.Succeeded)
                {
                    string roleName = dto.Role;

                    result = await _userManager.AddToRoleAsync(user, roleName);
                    if (!result.Succeeded)
                    {
                        response.Message = "An error has occurred.";
                        return (2, response);
                    }

                    response.Id = user.Id;
                    response.Email = user.Email;
                    response.Message = "Success.";
                    response.Password = password;
                    return (1, response);
                }

                response.Message = "Something ain't right.";

                return (3, response);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return (0, response);
            }
        }

        private string GenerateToken(IEnumerable<Claim> claims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = _configuration["Jwt:Issuer"],
                Audience = _configuration["Jwt:Audience"],
                Expires = DateTime.UtcNow.AddHours(3),
                SigningCredentials = new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256),
                Subject = new ClaimsIdentity(claims)
            };


            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        
    }
}
