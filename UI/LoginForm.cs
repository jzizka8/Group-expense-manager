using Project.BusinessLayer;
using Project.Models;
using Project.UI.Authorized;

namespace Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            RegisterForm register = new();
            register.ShowDialog();
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            UserManager userManager = new();
            string username = UsernameLoginTxt.Text;
            if (!await userManager.LoginUserAsync(username, PasswordLoginTxt.Text))
            {
                ErrLoginLbl.Text = "Login not succesful";
                return;
            }
            var user = userManager.GetUserAsync(username);
            ShowAuthorized(await user);
        }

        private void ShowAuthorized(User user)
        {
            MainForm main = new(user);
            main.Location = Location;
            main.StartPosition = FormStartPosition.Manual;
            main.FormClosing += delegate { Show(); };
            main.Show();
            Hide();
        }
    }
}