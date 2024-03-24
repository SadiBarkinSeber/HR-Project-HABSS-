using System.Text;

namespace HR_PROJECT.WebAPI.HelperFunctions
{
    public class CreateRandomPassword
    {
        private static readonly Random _random = new Random();
        private const string _validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";

        public string GenerateRandomString(int length)
        {
            var sb = new StringBuilder();

            // Add at least one uppercase letter
            sb.Append(_validChars[_random.Next(26)]);

            // Add at least one lowercase letter
            sb.Append(_validChars[_random.Next(26, 52)]);

            // Add at least one digit
            sb.Append(_validChars[_random.Next(52, 62)]);

            // Add at least one special character
            sb.Append(_validChars[_random.Next(62, _validChars.Length)]);

            // Add remaining characters
            for (int i = 4; i < length; i++)
            {
                sb.Append(_validChars[_random.Next(_validChars.Length)]);
            }

            // Shuffle the characters
            return new string(sb.ToString().OrderBy(x => _random.Next()).ToArray());
        }
    }
}
