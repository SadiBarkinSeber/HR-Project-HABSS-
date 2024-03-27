using HR_PROJECT.Domain.Entities;
using HR_PROJECT.WebAPI.DTOs.ApplicationUserDTOs;
using HR_PROJECT.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Net;
using System.Net.Mail;
using HR_PROJECT.WebAPI.HelperFunctions;
using HR_PROJECT.Application.Features.CQRS.Commands.ApplicationUserCommands;
using HR_PROJECT.Application.Features.CQRS.Handlers.ApplicationuserHandlers.Write;

namespace HR_PROJECT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IAuthService authService;
        private readonly ILogger<AccountController> logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly PasswordHasher<ApplicationUser> _passwordHasher;
        private readonly CreateRandomPassword _createRandomPassword;
        private readonly UpdateApplicationuserCommandHandler _updateUserCommandHandler;
        
        

        public AccountController(UserManager<ApplicationUser> userManager, ILogger<AccountController> logger, IAuthService authService, RoleManager<IdentityRole> roleManager, PasswordHasher<ApplicationUser> passwordHasher, CreateRandomPassword createRandomPassword, UpdateApplicationuserCommandHandler updateUserCommandHandler)
        {
            _userManager = userManager;
            this.logger = logger;
            this.authService = authService;
            _createRandomPassword = createRandomPassword;
            _passwordHasher = passwordHasher;
            _roleManager = roleManager;
            _updateUserCommandHandler = updateUserCommandHandler;
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginApplicationUserDTO dto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid payload");
                }
                var (status, message) = await authService.Login(dto);
                if (status == 0)
                {
                    return BadRequest(message);
                }
                return Ok(message);
                
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> ChangePasswordForReset(ChangePasswordForResetDTO dto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid payload.");
                }

                if (dto.Password != dto.RepeatPassword)
                {
                    return BadRequest("Passwords don't match.");
                }

                var (status, message) = await authService.ResetPassword(dto);

                if ( status == 0)
                {
                    return BadRequest(message);
                }
                return Ok(message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("create")]
        public async Task<IActionResult> Create(CreateApplicationUserDTO dto)
        {
            try
            {
                
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid payload");
                }

                if (ModelState.IsValid)
                {
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
                        string roleName = "employee";

                        result = await _userManager.AddToRoleAsync(user, roleName);
                        if (!result.Succeeded)
                        {
                            Errors(result);
                            return BadRequest("An error has occurred. 100");
                        }

                        var response = new
                        {
                            Message = "Kullanıcı oluşturuldu.",
                            Password = password,
                            Email = user.Email
                        };

                        return Ok(response);
                    }

                    else
                    {
                        foreach (IdentityError item in result.Errors)
                        {
                            ModelState.AddModelError("Create User", $"{item.Code} - {item.Description}");
                        }

                        var response = ModelState;

                        return BadRequest(response);
                    }
                }
                else
                {
                    return BadRequest("An error has occurred. 124");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  
            }
        }




        [HttpPost("resetpassword")]
        public async Task<IActionResult> ResetPassword(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return NotFound("Bu e-posta adresi ile ilişkili bir hesap bulunamadı.");
            }

            // Doğrulama kodu oluşturma
            var verificationCode = GenerateVerificationCode();

            var resetPasswordLink = $"https://comforting-marzipan-f52585.netlify.app";

            // E-posta içeriğinde doğrulama kodunu kullanıcıya gösterme
            var mailMessage = new MailMessage
            {
                From = new MailAddress("habss.hr@gmail.com"),
                Subject = "Şifre Sıfırlama",
                Body = $"Şifrenizi sıfırlamak için aşağıdaki bağlantıyı kullanarak tek kullanımlık şifrenizle giriş yapabilirsiniz :<br/><br/> <a href='{resetPasswordLink}'>{resetPasswordLink}</a> <br/><br/> Tek Kullanımlık Şifreniz: {verificationCode}",
                IsBodyHtml = true,
            };
            mailMessage.To.Add("azizogluharun@gmail.com");
            mailMessage.To.Add("sazikomen@gmail.com");

            using (var smtpClient = new SmtpClient("smtp.gmail.com"))
            {
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("habss.hr@gmail.com", "mvwo msab napt efvc");
                smtpClient.EnableSsl = true;

                await smtpClient.SendMailAsync(mailMessage);
            }

            UpdateApplicationUserCommand command = new UpdateApplicationUserCommand()
            {
                Id = user.Id,
                OneTimePassword = verificationCode
            };

            try
            {
                await _updateUserCommandHandler.Handle(command);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok("Doğrulama kodu başarılı bir şekilde gönderildi.");
        }

        // Rastgele doğrulama kodu oluşturma fonksiyonu
        private string GenerateVerificationCode()
        {
            const string chars = "0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 6)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }



        private void Errors(IdentityResult result)
        {
            foreach (IdentityError item in result.Errors)
            {
                ModelState.AddModelError("UpdateUser", $"{item.Code} - {item.Description}");
            }
        }


        

    }
}
