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
        public async Task AddExpense(User payer,Group group, string description, decimal amount, ICollection<User> consumers)
        {
            if(amount == 0)
            {
                throw new ArgumentException("The amount cannot be zero");
            }
            if(consumers.Count == 0)
            {
                throw new ArgumentException("The list for whom the expense is paid cannot be empty");
            }

            using var db = await Task.Run(() => new DataContext());
            
            var trackedPayer =  await db.Users.FindAsync(payer.Id);
            var trackedGroup = await db.Groups.FindAsync(group.Id);
            var trackedConsumers =  await Task.Run(()=>
                consumers.Select(c => db.Users.Find(c.Id))
                            .ToList());

            Expense expense = new Expense(trackedPayer, description, trackedGroup, amount,
                                          trackedConsumers);

            db.Add(expense);
            await db.SaveChangesAsync();
        }
    }
}
