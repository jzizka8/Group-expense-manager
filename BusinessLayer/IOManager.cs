using Project.CsvReading;
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
        private Group group;

        public IOManager(Group group)
        {
            this.group = group;
        }

        public async Task ImportExpenses(string srcPath)
        {
            CsvReader csv = new CsvReaderWriter();

            var expensesData = await csv.ReadAsync(srcPath);



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
        public async Task ExportExpenses(string outPath)
        {
            List<List<string>> expensesData = group.Expenses.Select(e => GetExpenseData(e)).ToList();

            CsvWriter writer = new CsvReaderWriter();
            await writer.WriteAsync(outPath, expensesData);
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
        private List<string> GetDebtData(DebtManaging.IDebt debt) => 
            new List<string>() { debt.Payee.ToString(), debt.Amount.ToString(),
                debt.Debtor.ToString() };

        public async Task ExportDebts(string path)
        {

        }
    }
}
