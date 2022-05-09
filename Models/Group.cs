using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User Admin { get; set; }
        public IEnumerable<User> Members { get; set; }
        public IEnumerable<Expense> Expenses { get; set; }
    }
}
