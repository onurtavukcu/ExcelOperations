using System.Security.Cryptography;

namespace ExcelOperations.Authenticate.AuthenticateOperations
{
    public static class PasswordHashingOperations
    {
        public static byte[] CreatePasswordHash(byte[] password)
        {
            var hmac = new HMACSHA512();

            var passwordHash = hmac.ComputeHash(password);

            return passwordHash;
        }

        public static bool VerifyPasswordHash(byte[] password, byte[] passwordHash)
        {
            var hmac = new HMACSHA512();
            
            var computedHash = hmac.ComputeHash(password);

            Console.WriteLine(passwordHash);
            Console.WriteLine(BitConverter.ToString(computedHash));

            return computedHash.Equals(passwordHash);            
        }
    }
}
