using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer
{
    public class Debt
    {
        public User Debtor{ get; private set; }
        public User Payee { get; private set; }
        public decimal Amount { get; private set; }

        public Debt(User debtor, User payee, decimal amount)
        {
            Debtor = debtor;
            Payee = payee;
            Amount = amount;
        }
        public override string ToString()
        {
            return $"{Debtor} owes {Amount} to {Payee}";
        }
    }
}
