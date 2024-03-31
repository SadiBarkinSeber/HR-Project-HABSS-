namespace HR_PROJECT.WebAPI.DTOs.ApplicationUserDTOs
{
    public class CreateUserResponseDTO
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string Password { get; set; }
        public int? PositionId { get; set; }
    }
}
