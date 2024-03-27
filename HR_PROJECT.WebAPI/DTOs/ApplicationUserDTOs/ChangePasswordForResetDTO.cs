namespace HR_PROJECT.WebAPI.DTOs.ApplicationUserDTOs
{
    public class ChangePasswordForResetDTO
    {
        public string Email { get; set; }   
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
    }
}
