using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Group:IEquatable<Group>
    {

        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public virtual User Admin { get; set; }
        [Required]
        public virtual ICollection<User> Members { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public Group()
        { }

        public Group(string name, User admin)
        {
            Name = name;
            Admin = admin;
            Members = new HashSet<User>() { admin };
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
        public override string ToString()
        {
            return Name;
        }

        public bool IsManagedBy(User user)
        {
            return Admin.Equals(user);
        }

    }
}
