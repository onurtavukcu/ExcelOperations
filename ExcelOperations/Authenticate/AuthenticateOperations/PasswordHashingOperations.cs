using System.Security.Cryptography;
using System.Text;

namespace ExcelOperations.Authenticate.AuthenticateOperations
{
    public static class PasswordHashingOperations
    {
        public static string CreateHash(string value)
        {
            var hmac = new HMACSHA512();

            var valueBytes = Encoding.UTF8.GetBytes(value);
            var hashValue = hmac.ComputeHash(valueBytes);

            return Encoding.UTF8.GetString(hashValue);
        }

        public static bool VerifyPasswordHash(string password, string passwordHash)
        {
            var computedHash = CreateHash(password);

            Console.WriteLine(passwordHash);
            Console.WriteLine(computedHash);

            return computedHash.Equals(passwordHash);            
        }
    }
}
