using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer
{
    public class UserManager
    {
        public async Task RegisterUserAsync(string username, string password)
        {
            if (GetUser(username) != null)
            {
                throw new ArgumentException("This username already exists");
            }
            PasswordHashing passwordHashing = new PasswordHashing();
            string hashedPassword = passwordHashing.HashedPassword(password);
            var salt = passwordHashing.Salt;

            using(var db= new ExpenseDbContext())
            {
                db.Users.Add(new User(username, hashedPassword, salt));
                await db.SaveChangesAsync();
            }
        }
        public async Task<bool> LoginUser(string username, string password)
        {
            return false;
        }
        private User? GetUser(string username)
        {
            using(var db = new ExpenseDbContext())
            {
                return db.Users.FirstOrDefault(u => u.UserName == username);
            }
        }

        

    }
}
