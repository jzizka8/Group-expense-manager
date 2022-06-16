using Project.Models;
using Regex = System.Text.RegularExpressions;

namespace Project.BusinessLayer
{
    public class UserManager
    {
        private static readonly int MIN_GROUPNAME_LENGTH = 3;
        // alpha numeric string with -_ of min length of 3
        private static readonly Regex.Regex USERNAME_REGEX = new($"^[0-9a-zA-Z_-]{{{MIN_GROUPNAME_LENGTH},}}$");
        public async Task RegisterUserAsync(string username, string password)
        {
            if (!USERNAME_REGEX.IsMatch(username))
            {
                throw new ArgumentException("Username is either too short or contains illegal characters");
            }
            if (password.Length < 3)
            {
                throw new ArgumentException("Password is too short");
            }
            if (await GetUserAsync(username) != null)
            {
                throw new ArgumentException("This username already exists");
            }

            PasswordHash passwordHashing = new PasswordHash();
            string hashedPassword = passwordHashing.HashPassword(password);
            var salt = passwordHashing.Salt;

            using (var db = await Task.Run(() => new DataContext()))
            {
                db.Users.Add(new User(username, hashedPassword, salt));
                await db.SaveChangesAsync();
            }
        }

        public async Task<bool> LoginUserAsync(string username, string password)
        {
            User user = await GetUserAsync(username);
            if (user == null)
            {
                return false;
            }

            PasswordHash passwordHashing = new(user.Salt);
            return passwordHashing.HashPassword(password) == user.Password;
        }

        public async Task<User> GetUserAsync(string username)
        {
            using (var db = await Task.Run(() => new DataContext()))
            {
                return db.Users.FirstOrDefault(u => u.Username == username);
            }
        }
    }
}
