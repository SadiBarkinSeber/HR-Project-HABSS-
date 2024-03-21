using HR_PROJECT.Domain.Entities;
using HR_PROJECT.WebAPI.DTOs.ApplicationUserDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HR_PROJECT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager; 

        public AccountController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager) 
        {
            _signInManager = signInManager;
            _userManager = userManager; 
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginApplicationUserDTO dto)
        {
            if (string.IsNullOrEmpty(dto.UserName) || string.IsNullOrEmpty(dto.Password))
            {
                return BadRequest("Kullanıcı adı ve şifre gerekli.");
            }

            var result = await _signInManager.PasswordSignInAsync(dto.UserName, dto.Password, false, false);

            if (result.Succeeded)
            {
                return Ok("Giriş başarılı.");
            }
            else
            {
                return Unauthorized("Kullanıcı adı veya şifre yanlış.");
            }
            
        }

        [HttpPost("check-email")]
        public async Task<IActionResult> CheckEmailExists(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                return Ok(new { exists = true });
            }
            else
            {
                return Ok(new { exists = false });
            }
        }
    }
}
