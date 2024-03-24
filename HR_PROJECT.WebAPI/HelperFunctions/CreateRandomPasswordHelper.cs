using System.Text;

namespace HR_PROJECT.WebAPI.HelperFunctions
{
    public class CreateRandomPasswordHelper
    {
        private static readonly Random _random = new Random();
        private const string _validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";

        public string GenerateRandomString(int length)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(_validChars[_random.Next(_validChars.Length)]);
            }

            return sb.ToString();
        }
    }
}
