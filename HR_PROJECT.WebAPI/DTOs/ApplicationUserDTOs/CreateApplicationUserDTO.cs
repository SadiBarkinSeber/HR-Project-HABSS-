using HR_PROJECT.WebAPI.HelperFunctions;
using System.Text.RegularExpressions;

namespace HR_PROJECT.WebAPI.DTOs.ApplicationUserDTOs
{

    public class CreateApplicationUserDTO
    {



        private string username;

        public string UserName
        {
            get { return username; }
            set 
            { 
                username = ReplaceNonEnglishCharacters(value.ToLower()); 
            }
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string? Role { get; set; }
        public int Id { get; set; }
        private string email;

        public string Email
        {
            get 
            {
                string eFirstName = ReplaceNonEnglishCharacters(Firstname.ToLower());
                string eLastName = ReplaceNonEnglishCharacters(Lastname.ToLower());
                email = $"{eFirstName}.{eLastName}@bilgeadamboost.com";
                return email; 
            }
            
        }

        public string ReplaceNonEnglishCharacters(string input)
        {
            // Define mapping of non-English characters to their English counterparts
            var replacements = new Dictionary<string, string>
        {
            { "ı", "i" },  // Turkish dotless i
            { "ş", "s" },
            { "ö", "o" },
            { "ü", "u" },
            { "ğ", "g" },
            { "ç", "c" }
        };

            // Create a regex pattern for matching non-English characters
            var pattern = "[" + string.Join("", replacements.Keys.Select(Regex.Escape)) + "]";

            // Replace non-English characters with their English counterparts
            var result = Regex.Replace(input, pattern, match => replacements[match.Value]);

            return result;
        }


    }
}
