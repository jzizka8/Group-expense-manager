
using Project.UI;

namespace Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            SampleData sd = new();
            //dsd.AddSampleData().Wait();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());

            //BusinessLayer.UserManager user = new();
            //var x = user.GetUserAsync("test");
            //Application.Run(new UI.Authorized.MainForm(x.Result));
        }
    }
}