using Project.Models;

namespace Project.BusinessLayer
{
    public class UserManager
    {
        public async Task RegisterUserAsync(string username, string password)
        {
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
