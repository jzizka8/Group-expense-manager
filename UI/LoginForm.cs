using Project.BusinessLayer;
using Project.Models;
using Project.UI.Authorized;

namespace Project.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }



        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            InformLoginStart();

            UserManager userManager = new();
            string username = UsernameLoginTxt.Text;
            var loginResult = await userManager.LoginUserAsync(username, PasswordLoginTxt.Text);

            LoginProgress.Visible = false;

            if (!loginResult)
            {
                InformLoginFail();
                return;
            }

            LoginStatusLbl.Text = "";
            ShowAuthorized(await userManager.GetUserAsync(username));
        }

        private void InformLoginStart()
        {
            LoginStatusLbl.ForeColor = Color.Black;
            LoginStatusLbl.Text = "loging in";

            LoginProgress.Visible = true;
        }

        private void InformLoginFail()
        {
            LoginStatusLbl.ForeColor = Color.Red;
            LoginStatusLbl.Text = "Login not succesful";
        }

        private void ShowAuthorized(User user)
        {
            MainForm main = new(user);
            this.ReplaceCurrentWith(main);
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new();
            this.ReplaceCurrentWith(register);
        }


    }
}