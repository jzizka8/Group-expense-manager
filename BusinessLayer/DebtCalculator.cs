using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer
{
    public class DebtCalculator
    {

        public List<Debt> CalculateDebts(IEnumerable<Expense> expenses)
        {
            List<Debt> result = new();
            if(expenses.Count() == 0)
            {
                return result;
            }
            Dictionary<User, decimal> userAmount = CollectBalances(expenses);

            User middleMan = GetMaxValueKey(userAmount);

            foreach((var user, var balance) in userAmount)
            {
                if (user.Equals(middleMan) || balance == 0)
                {
                    continue;
                }
                // if user's balance is negative they pay to the middleMan
                // otherwise they are paid by middleMan;
                User debtor = balance > 0 ? middleMan : user;
                User payee = balance > 0 ? user : middleMan;

                
                result.Add(new Debt(debtor, payee, Math.Abs(balance)));
            }

            return result;
        }
        private void SafeAddToValue(Dictionary<User, decimal> userAmount, User key, decimal amount)
        {
            // adds amount to value, if key is not in dictionary initializes with amount instead
            userAmount[key] = userAmount.GetValueOrDefault(key, 0) + amount;
        }

        private Dictionary<User, decimal>  CollectBalances(IEnumerable<Expense> expenses)
        {
            Dictionary<User, decimal> userAmount = new();
            foreach (var expense in expenses)
            {
                SafeAddToValue(userAmount, expense.Payer, expense.Amount);

                decimal splitedAmount = expense.Amount / expense.Consumers.Count();

                foreach (var consumer in expense.Consumers)
                {
                    SafeAddToValue(userAmount, consumer, -splitedAmount);
                }

            }
            return userAmount;
        }

        private User GetMaxValueKey(Dictionary<User,decimal> valuePairs)
        {
            return valuePairs.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        }
    }
}
