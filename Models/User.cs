using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public IEnumerable<Group> Groups{ get; set; }
        public IEnumerable<Expense> Expenses{ get; set; }
        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
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
