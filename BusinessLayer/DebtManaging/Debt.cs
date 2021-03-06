using Project.Models;

namespace Project.BusinessLayer.DebtManaging
{
    public class Debt : IDebt
    {
        public User Debtor { get; private set; }
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
