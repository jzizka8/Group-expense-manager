using Microsoft.EntityFrameworkCore;
using Project.BusinessLayer;
using Project.Models;
using Project.UI.Authorized.GroupManaging;

namespace Project.UI.Authorized
{
    public partial class MainForm : Form
    {
        public User User { get; set; }
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
            List<Group> groups = await groupManager.GetGroups(User);

            listBox1.DataSource = groups;
            GroupSelectComb.DataSource = groups; 
        }

        private void CreateGroupBtn_Click(object sender, EventArgs e)
        {
            CreateGroupForm groupCreate = new(User);
            groupCreate.Location = Location;
            groupCreate.StartPosition = FormStartPosition.Manual;

            groupCreate.ShowDialog();
            ReinitGroup();
        }



        private void GroupSelectComb_SelectedIndexChanged(object sender, EventArgs e)
        {

            DebugLabel.Text = "dropdown " + GroupSelectComb.Text;
        }
    }
}
