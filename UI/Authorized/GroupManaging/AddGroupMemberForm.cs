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

namespace Project.UI.Authorized.GroupManaging
{
    public partial class AddGroupMemberForm : Form
    {
        public Group Group { get; }
        public AddGroupMemberForm(Group group)
        {
            InitializeComponent();
            Group = group;
        }

        private async void CreateBtn_Click(object sender, EventArgs e)
        {
            GroupManager groupManager = new();
            try
            {

                await groupManager.AddGroupMembers(Group, UsernamesTxt.Text);
                MessageBox.Show("Adding comlete", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
