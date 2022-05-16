using Project.BusinessLayer;

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
            Button senderBtn = (Button)sender;
            senderBtn.Enabled = false;

            ErrReportLbl.Text = "";

            UserManager userManager = new();
            try
            {
                await userManager.RegisterUserAsync(UserNameTxt.Text, PasswordTxt.Text);
                MessageBox.Show("You may proceed to log in", "Registration succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            catch (ArgumentException ex)
            {
                ErrReportLbl.Text = ex.Message;
            }

            senderBtn.Enabled = true;
        }

        private void LoginLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
