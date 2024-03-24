using HR_PROJECT.WebAPI.HelperFunctions;

namespace HR_PROJECT.WebAPI.DTOs.ApplicationUserDTOs
{

    public class CreateApplicationUserDTO
    {
        private readonly CreateRandomPasswordHelper _createRandomPassword;

        public CreateApplicationUserDTO(CreateRandomPasswordHelper createRandomPasswordHelper)
        {
            _createRandomPassword = createRandomPasswordHelper;
        }

        public string UserName { get; set; }
        public string Firstname { get; set; }
        public string? SecondFirstName { get; set; }
        public string Lastname { get; set; }
        public string? SecondLastName { get; set; }
        private string email;

        public string Email
        {
            get 
            {
                email = $"{Firstname}.{Lastname}@bilgeadamboost.com";
                return email; 
            }
            
        }

        private string password;

        public string Password
        {
            get 
            {
                password = _createRandomPassword.GenerateRandomString(6);
                return password; 
            }
            
        }

    }
}
