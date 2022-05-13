using Microsoft.EntityFrameworkCore;
using Project.BusinessLayer;
using Project.Models;
using Project.UI.Authorized.GroupManaging;

namespace Project.UI.Authorized
{
    public partial class MainForm : Form
    {
        public User User { get; set; }
        public Group Group { get => (Group)(GroupSelectComb.SelectedValue); }
        public ICollection<Group> ManagedGroups { get; set; }
        public MainForm(User user)
        {
            User = user;
            
            InitializeComponent();
            LogedUserLbl.Text = User.Username;

            ReinitGroup();
        }

        private async void ReinitGroup()
        {
            var groupManager = new GroupManager();
            List<Group> groups = await groupManager.GetGroupsAsync(User);

            GroupSelectComb.DataSource = groups;
        }

        private async Task GroupChanged()
        {
            var groupManager = new GroupManager();
            Group group = (Group)GroupSelectComb.SelectedValue;

            MembersListBox.DataSource = await groupManager.GetGroupMembersAsync(group);

            AddMemberBtn.Enabled = await groupManager.IsGroupAdmin(group, User);
        }

       



        private async void GroupSelectComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO:
            //reinit expenses
            //Show admin Buttons
            GroupManager groupManager = new();
            Group group = (Group)(GroupSelectComb.SelectedValue);
            group = await groupManager.GetEagerGroup(group);
            DebugLabel.Text = group.Name + " " + group.Admin + " users:" + group.Members.Last().ToString() ;
            await GroupChanged();
        }
        #region Buttons Actions
        private void CreateGroupBtn_Click(object sender, EventArgs e)
        {
            CreateGroupForm groupCreate = new(User);
            groupCreate.Location = Location;
            groupCreate.StartPosition = FormStartPosition.Manual;

            groupCreate.ShowDialog();
            ReinitGroup();
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            AddGroupMemberForm addMember = new(Group);
            addMember.Location = Location;
            addMember.StartPosition = FormStartPosition.Manual;

            addMember.ShowDialog();
            ReinitGroup();
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
