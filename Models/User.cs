using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public byte[] Salt{ get; set; }
        public IEnumerable<Group> Groups{ get; set; }
        public IEnumerable<Group> ManagedGroups { get; set; }
        public IEnumerable<Expense> ExpensesPaid{ get; set; }
        public IEnumerable<Expense> Expenses{ get; set; }
        public User(string userName, string password, byte[] salt)
        {
            UserName = userName;
            Password = password;
            Salt = salt;
            Groups = new HashSet<Group>();
            Expenses = new List<Expense>();
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
    }
}
