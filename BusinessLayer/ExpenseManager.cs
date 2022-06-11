using Project.CsvIO;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer
{
    public class ExpenseManager
    {
        public async Task AddExpense(string payerStr, Group group, string description, string amountStr, IEnumerable<string> consumersStr)
        {
            decimal amount;
            if (decimal.TryParse(amountStr, out amount))
            {
                throw new ArgumentException("The amount is not of decimal type");
            }

            UserManager userManager = new();
            User payer = await userManager.GetUserAsync(payerStr);
            
            List<User> consumers = new();

            // async linq was causing deadlocks
            foreach (var item in consumersStr)
            {
                consumers.Add(await userManager.GetUserAsync(item));
            }
            

            await AddExpense(payer, group, description, amount, consumers);
        }
        public async Task AddExpense(User payer,Group group, string description, decimal amount, IEnumerable<User> consumers)
        {
            await AddExpense(payer.Id, group.Id, description, amount, consumers.Select(c => c.Id).ToList());
        }

        public async Task AddExpense(int payerId, int groupId, string description, decimal amount, IEnumerable<int> consumerIds)
        {
            if (amount == 0)
            {
                throw new ArgumentException("The amount cannot be zero");
            }
            if (!consumerIds.Any())
            {
                throw new ArgumentException("The list for whom the expense is paid cannot be empty");
            }
            

            using var db = await Task.Run(() => new DataContext());

            var trackedPayer = await db.Users.FindAsync(payerId);
            var trackedGroup = await db.Groups.FindAsync(groupId);
            var trackedConsumers = await Task.Run(() =>
               consumerIds.Select(c => db.Users.Find(c))
                           .ToList());

            CheckUsersMembership(trackedGroup, trackedPayer, trackedConsumers);

            Expense expense = new(trackedPayer, description, trackedGroup, amount,
                                          trackedConsumers);

            db.Add(expense);
            await db.SaveChangesAsync();
        }

        private void CheckUsersMembership(Group group, User payer, IEnumerable<User> consumers)
        {
            if (!group.Members.Contains(payer))
            {
                throw new ArgumentException("Given payer is not part of the group");
            }

            if (!ConsumersAreMembers(group, consumers))
            {
                throw new ArgumentException("List of consumers contains users which are not part of the group");
            }
        }
        private bool ConsumersAreMembers(Group group, IEnumerable<User> consumerIds)
        {
            return consumerIds.All(c => group.Members.Contains(c));
        }

        
    }
}
