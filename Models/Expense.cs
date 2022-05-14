using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Required]
        public virtual User Payer { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public virtual Group Group { get; set; }
        [Required]
        public virtual IEnumerable<User> Consumers { get; set; }
        public Expense()
        {

        }

        public Expense(User payer, string description, Group group, decimal amount, IEnumerable<User> consumers)
        {
            Payer = payer;
            Description = description;
            Group = group;
            Amount = amount;
            Consumers = consumers;
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

        public override string ToString()
        {
            string consumersFormated = Consumers.Select(c => c.ToString())
                                               .Aggregate((f, s) => $"{f}, {s}");

            return $"{Payer} paid {Amount} for {Description:0.00} for {consumersFormated}";
        }
    }
}
