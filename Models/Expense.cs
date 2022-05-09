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
    }
}
