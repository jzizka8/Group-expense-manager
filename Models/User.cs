using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public byte[] Salt { get; set; }
        [Required]
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Group> ManagedGroups { get; set; }
        public virtual ICollection<Expense> ExpensesPaid { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public User(string username, string password, byte[] salt)
        {
            Username = username;
            Password = password;
            Salt = salt;
            Groups = new HashSet<Group>();
            ManagedGroups = new HashSet<Group>();
            ExpensesPaid = new HashSet<Expense>();
            Expenses = new HashSet<Expense>();
        }
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            return obj.GetType() == this.GetType() && Equals((User)obj);
        }
        public bool Equals(User other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }
        public override string ToString()
        {
            return Username;
        }
    }
}
