using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer
{
    internal class PasswordHashing
    {
        public byte[] Salt { get; }

        public PasswordHashing(byte[] salt)
        {
            Salt = salt;
        }
        public PasswordHashing()
        {
            Salt = new byte[128 / 8];
            // generate a 128-bit salt using a cryptographically strong random sequence of nonzero values
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetNonZeroBytes(Salt);
            }
        }
        public string HashedPassword(string password)
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
