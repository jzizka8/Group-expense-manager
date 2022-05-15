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
    public partial class CreateGroupForm : Form
    {
        public User User { get; }
        public CreateGroupForm(User user)
        {
            InitializeComponent();
            User = user;
        }

        private async void CreateBtn_Click(object sender, EventArgs e)
        {
            GroupManager groupManager = new();
            try
            {
                await groupManager.CreateGroup(GroupNameTxt.Text, User); 
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show( "You can now add members to your new group", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
