using Project.BusinessLayer;
using Project.BusinessLayer.DebtManaging;
using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.UI.Authorized.ExpenseManaging
{
    public partial class AddExpenseForm : Form
    {
        private Group group;
        public AddExpenseForm(User defaultPayer, Group group)
        {
            CommonCustomInit(defaultPayer, group);
            ConsumersChListBox.DataSource = group.Members.ToList();

            for (int i = 0; i < ConsumersChListBox.Items.Count; i++)
            {
                ConsumersChListBox.SetItemChecked(i, true);
            }
        }

        public AddExpenseForm(IDebt debt, Group group)
        {
            CommonCustomInit(debt.Debtor, group);

            ConsumersChListBox.DataSource = new List<User> { debt.Payee };
            ConsumersChListBox.SetItemChecked(0, true);

            //PayerComb.DataSource = new List<User>() { debt.Debtor };

            AmountNum.Value = debt.Amount;
            DescriptionTxt.Text = "Debt settlement";

            ConsumersChListBox.Enabled = false;
            PayerComb.Enabled = false;
        }

        private void CommonCustomInit(User defaultPayer, Group group)
        {
            InitializeComponent();
            this.group = group;

            PayerComb.DataSource = group.Members.ToList();
            PayerComb.SelectedItem = defaultPayer;
        }

        private async void SubmitBtn_Click(object sender, EventArgs e)
        {
            ExpenseManager expenseManager = new();
            try
            {
                await expenseManager.AddExpense(
                    (User)PayerComb.SelectedItem,
                    group,
                    DescriptionTxt.Text,
                    AmountNum.Value,
                    ConsumersChListBox.CheckedItems.OfType<User>().ToList());
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Expense was added succesfuly", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
