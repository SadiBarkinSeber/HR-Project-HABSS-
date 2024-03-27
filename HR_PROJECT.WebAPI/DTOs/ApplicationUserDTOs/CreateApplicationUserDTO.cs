﻿using HR_PROJECT.WebAPI.HelperFunctions;
using System.Text.RegularExpressions;

namespace HR_PROJECT.WebAPI.DTOs.ApplicationUserDTOs
{

    public class CreateApplicationUserDTO
    {

        

        public string UserName { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
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
            // Add more replacements as needed
        };

            // Create a regex pattern for matching non-English characters
            var pattern = "[" + string.Join("", replacements.Keys.Select(Regex.Escape)) + "]";

            // Replace non-English characters with their English counterparts
            var result = Regex.Replace(input, pattern, match => replacements[match.Value]);

            return result;
        }


    }
}