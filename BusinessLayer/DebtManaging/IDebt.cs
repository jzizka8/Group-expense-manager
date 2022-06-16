using Project.Models;

namespace Project.BusinessLayer.DebtManaging
{
    public interface IDebt
    {
        public User Debtor { get; }
        public User Payee { get; }
        public decimal Amount { get; }
    }
}
