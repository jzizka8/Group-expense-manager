using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Required]
        public User Payer { get; set; }
        public string Description { get; set; }
        [Required]
        public Group Group { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public IEnumerable<User> PaidFor { get; set; }
        public Expense()
        {

        }

        public Expense(User payer, string description, Group group, IEnumerable<User> paidFor)
        {
            Payer = payer;
            Description = description;
            Group = group;
            PaidFor = paidFor;
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
            return obj.GetType() == this.GetType() && Equals((Expense)obj);
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
