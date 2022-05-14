using Microsoft.EntityFrameworkCore;
using Project.BusinessLayer;
using Project.Models;
using Project.UI.Authorized.ExpenseManaging;
using Project.UI.Authorized.GroupManaging;

namespace Project.UI.Authorized
{
    public partial class MainForm : Form
    {
        public User User { get; set; }
        private Group selectedGroup;
        public MainForm(User user)
        {
            InitializeComponent();
            
            User = user;
            LogedUserLbl.Text = User.Username;

            RefreshGroupListAsync();
        }

        private async void RefreshGroupListAsync()
        {
            var groupManager = new GroupManager();
            List<Group> groups = await groupManager.GetGroupsAsync(User);

            GroupSelectComb.DataSource = groups.ToList();
        }

        private async Task LoadGroupAsync()
        {
            var groupManager = new GroupManager();
            selectedGroup = await groupManager.GetGroupEagerAsync((Group)(GroupSelectComb.SelectedValue));
        }

        private void RefreshGroupControls()
        {
            MembersListBox.DataSource = selectedGroup.Members.ToList();
            ExpensesListBox.DataSource = selectedGroup.Expenses.ToList();

            AddMemberBtn.Enabled = selectedGroup.IsManagedBy(User);
        }

        private void ShowFormDialogAligned(Form form)
        {
            form.Location = Location;
            form.StartPosition = FormStartPosition.Manual;
            form.ShowDialog();
        }
        #region Event Handlers
        private async void GroupSelectComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadGroupAsync();
            RefreshGroupControls();
        }
        private void CreateGroupBtn_Click(object sender, EventArgs e)
        {
            Form createGroup = new CreateGroupForm(User);
            ShowFormDialogAligned(createGroup);
            RefreshGroupListAsync();
        }
        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            Form addMember = new AddGroupMemberForm(selectedGroup);
            ShowFormDialogAligned(addMember);

        }
        private void AddExpenseBtn_Click(object sender, EventArgs e)
        {
            Form createExpense = new AddExpenseForm(selectedGroup.Members.FirstOrDefault(u => u.Equals(User)), selectedGroup);
            ShowFormDialogAligned(createExpense);

        }
        private void ExportDebtsBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
