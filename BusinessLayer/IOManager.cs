using Project.BusinessLayer.DebtManaging;
using Project.CsvIO;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer
{
    public class IOManager
    {
        private string path;
        public IOManager(string path)
        {
            this.path = path;
        }

        public async Task ImportExpenses(Group group)
        {
            ICsvReader csv = new CsvReader();

            var expensesData = await csv.ReadAsync(path);



            if (!expensesData.TrueForAll(e => e.Count == 4))
            {
                throw new InvalidDataException("The number of columns is not right");

            }

            // payer, description, amount, consumers

            foreach (var expenseData in expensesData)
            {
                string payer, description, amount;
                payer = expenseData[0];
                description = expenseData[1];
                amount = expenseData[2];
                var consumers = expenseData[3].Split(" ");

                ExpenseManager expenseManager = new();

                await expenseManager.AddExpense(payer, group, description, amount, consumers);
            }

        }
        public async Task ExportExpenses(Group group)
        {
            var expensesData = group.Expenses.Select(e => GetExpenseData(e));

            ICsvWriter writer = new CsvWriter();
            await writer.WriteAsync(path, expensesData);
        }
        private List<string> GetExpenseData(Expense expense)
        {
            List<string> result = new();
            result.Add(expense.Payer.Username);
            result.Add(expense.Description);
            result.Add(expense.Amount.ToString());
            result.Add(string.Join(' ', expense.Consumers.Select(c => c.Username)));

            return result;
        }
        private List<string> GetDebtData(IDebt debt) => 
            new() { debt.Payee.ToString(), debt.Amount.ToString(),
                debt.Debtor.ToString() };

        public async Task ExportDebts(IEnumerable<IDebt> debts)
        {
            var debtsData = debts.Select(d => GetDebtData(d));
            ICsvWriter writer = new CsvWriter();
            await writer.WriteAsync(path, debtsData);
        }
    }
}
