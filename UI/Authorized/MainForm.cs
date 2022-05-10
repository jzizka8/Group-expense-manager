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

namespace Project.UI.Authorized
{
    public partial class MainForm : Form
    {
        public User User { get; set; }
        public Form Caller { get; }
        public MainForm(User user, Form caller)
        {
            User = user;
            Caller = caller;
            InitializeComponent();
        }
    }
}
