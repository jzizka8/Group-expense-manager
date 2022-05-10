using Project.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private async void RegisterBtn_Click(object sender, EventArgs e)
        {
            ErrReportLbl.Text = "";

            if (PasswordTxt.Text.Length < 3)
            {
                ErrReportLbl.Text = "Password too short";
                return;
            }

            UserManager userManager = new();
            try
            {
                await userManager.RegisterUserAsync(UserNameTxt.Text, PasswordTxt.Text);
            }catch(ArgumentException ex)
            {
                ErrReportLbl.Text = ex.Message;
            }
        }
    }
}
