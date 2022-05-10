using Project.BusinessLayer;
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
            if (!await userManager.LoginUser(username, PasswordLoginTxt.Text))
            {
                ErrLoginLbl.Text = "Login not succesful";
                return;
            }

            Hide();
            MainForm main = new(userManager.GetUser(username), this);
            main.Show();
        }
    }
}