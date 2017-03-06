using IRC_Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRC_Client.GUI
{
    public partial class LoginForm : Form
    {
        private IServer server;

        public LoginForm(IServer server)
        {
            this.server = server;
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(server.Login(nicknameText.Text, passwordText.Text, "", 0));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm(server);
            rf.ShowDialog();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.Logout(nicknameText.Text, passwordText.Text);
        }
    }
}
