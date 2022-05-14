using Microsoft.EntityFrameworkCore;
using Project.BusinessLayer;
using Project.Models;
using Project.UI.Authorized.GroupManaging;

namespace Project.UI.Authorized
{
    public partial class MainForm : Form
    {
        public User User { get; set; }
        public Group SelectedGroup { get => (Group)(GroupSelectComb.SelectedValue); }
        public ICollection<Group> ManagedGroups { get; set; }
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
            Group fetchedGroup = await groupManager.GetGroupEagerAsync(SelectedGroup);

            MembersListBox.DataSource = fetchedGroup.Members.ToList();
            ExpensesListBox.DataSource = fetchedGroup.Expenses.ToList();

            AddMemberBtn.Enabled = fetchedGroup.Admin.Equals(User);
        }

        private async void GroupSelectComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO:
            //reinit expenses
            //Show admin Buttons
            //Group SelectedGroup = await groupManager.GetEagerGroup(this.SelectedGroup);
            await LoadGroupAsync();
        }

        #region Buttons Actions
        private void CreateGroupBtn_Click(object sender, EventArgs e)
        {
            CreateGroupForm groupCreate = new(User);
            groupCreate.Location = Location;
            groupCreate.StartPosition = FormStartPosition.Manual;

            groupCreate.ShowDialog();
            RefreshGroupListAsync();
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            AddGroupMemberForm addMember = new(SelectedGroup);
            addMember.Location = Location;
            addMember.StartPosition = FormStartPosition.Manual;

            addMember.ShowDialog();
        }

        private void AddExpenseBtn_Click(object sender, EventArgs e)
        {

        }
        private void ExportDebtsBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
