using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public User Payer { get; set; }
        public string Description { get; set; }
        public Group Group { get; set; }
        public double Amount { get; set; }
        public IEnumerable<User> PaidFor { get; set; }

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
