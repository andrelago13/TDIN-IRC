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
        private IServer server = null;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(server == null)
            {
                InitServer();
            }

            try
            {
                bool login = server.Login(nicknameText.Text, passwordText.Text, "", 0);

                if (login)
                {
                    statusLabel.Visible = false;
                    MainForm mf = new MainForm(server, new LoggedUserInfo(nicknameText.Text, "", "", 0));
                    Hide();
                    mf.ShowDialog();
                    Show();
                }
                else
                {
                    statusLabel.Text = "Invalid login.";
                    statusLabel.Visible = true;
                }
            } catch (Exception ex)
            {
                statusLabel.Text = "Unable to reach server.";
                statusLabel.Visible = true;
                Console.WriteLine(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (server == null)
            {
                InitServer();
            }

            RegisterForm rf = new RegisterForm(server);
            rf.ShowDialog();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (server == null)
            {
                return;
            }

            try
            {
                server.Logout(nicknameText.Text, passwordText.Text);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void InitServer()
        {
            server = (IServer)Activator.GetObject(typeof(IServer), "tcp://" + serverAddrText.Text + ":" + serverPortText.Text + "/IRC-Server/Server");
        }
    }
}
