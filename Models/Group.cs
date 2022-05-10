using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Group
    {

        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public User Admin { get; set; }
        [Required]
        public IEnumerable<User> Members { get; set; }
        public IEnumerable<Expense> Expenses { get; set; }
        public Group()
        { }
            
        public Group(string name, User admin, IEnumerable<Expense> expenses)
        {
            Name = name;
            Admin = admin;
            Members = new HashSet<User>();
            Expenses = expenses;
        }
        public Group(string name, User admin)
            :this(name, admin, new HashSet<Expense>())
        {
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
            return obj.GetType() == this.GetType() && Equals((Group)obj);
        }
        public bool Equals(Group other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
