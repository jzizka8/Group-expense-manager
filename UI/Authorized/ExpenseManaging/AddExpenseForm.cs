using Project.BusinessLayer;
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
            InitializeComponent();
            this.group = group;

            ConsumersChListBox.DataSource = group.Members.ToList();

            for (int i = 0; i < ConsumersChListBox.Items.Count; i++)
            {
                ConsumersChListBox.SetItemChecked(i, true);
            }

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
