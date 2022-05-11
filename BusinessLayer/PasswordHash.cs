using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace Project.BusinessLayer
{
    internal class PasswordHash
    {
        public byte[] Salt { get; }

        public PasswordHash(byte[] salt)
        {
            Salt = salt;
        }
        public PasswordHash()
        {
            Salt = new byte[128 / 8];
            // generate a 128-bit salt using a cryptographically strong random sequence of nonzero values
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetNonZeroBytes(Salt);
            }
        }
        public string HashPassword(string password)
        {


            // derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: Salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));
        }
    }
}
