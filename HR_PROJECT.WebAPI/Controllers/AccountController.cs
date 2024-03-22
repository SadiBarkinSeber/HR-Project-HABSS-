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

        public AccountController(UserManager<ApplicationUser> userManager, ILogger<AccountController> logger, IAuthService authService)
        {
            _userManager = userManager;
            this.logger = logger;
            this.authService = authService;
        }

        [AllowAnonymous]
        [HttpPost]
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

        [HttpPost("resetpassword")]
        public async Task<IActionResult> ResetPassword(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return BadRequest("Bu e-posta adresi ile ilişkili bir hesap bulunamadı.");
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

            var mailMessage = new MailMessage
            {
                From = new MailAddress("your@email.com"),
                Subject = "Şifre Sıfırlama",
                Body = $"Şifrenizi sıfırlamak için bu bağlantıyı kullanın: http://www.example.com/resetpassword?email={email}&token={token}",
                IsBodyHtml = true, 
            };
            mailMessage.To.Add(email);

            using (var smtpClient = new SmtpClient("mail.example.com"))
            {
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("username", "password");
                smtpClient.EnableSsl = true;
               
                await smtpClient.SendMailAsync(mailMessage);
            }

            return Ok("Dogrulama kodu basarili bir sekilde gonderildi.");
        }


    }
}
