using System.Security.Cryptography;

namespace AccountService_API.Utility
{
    public class PasswordHashing
    {
        public static byte[] GenerateSalt(int size = 16)
        {
            var salt = new byte[size];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        public static byte[] HashPassword(string password, byte[] salt, int iterations = 10000, int hashByteSize = 20)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
            {
                return pbkdf2.GetBytes(hashByteSize);
            }
        }

        public static string HashPassword(string password)
        {
            var salt = GenerateSalt();
            var hash = HashPassword(password, salt);
            var hashBytes = new byte[salt.Length + hash.Length];
            Array.Copy(salt, 0, hashBytes, 0, salt.Length);
            Array.Copy(hash, 0, hashBytes, salt.Length, hash.Length);
            return Convert.ToBase64String(hashBytes);
        }

        public static bool VerifyPassword(string password, string storedHash)
        {
            var hashBytes = Convert.FromBase64String(storedHash);
            var salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, salt.Length);
            var storedHashBytes = new byte[hashBytes.Length - salt.Length];
            Array.Copy(hashBytes, salt.Length, storedHashBytes, 0, storedHashBytes.Length);
            var hash = HashPassword(password, salt);
            for (int i = 0; i < storedHashBytes.Length; i++)
            {
                if (storedHashBytes[i] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
