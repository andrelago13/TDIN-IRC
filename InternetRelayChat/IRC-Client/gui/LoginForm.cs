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
        public LoginForm()
        {
            InitializeComponent();
        }

        #region Input Binding
        private void ServerPortModified(object sender, EventArgs e)
        {
            Client.Instance.ServerPort = int.Parse(ServerPort.Text);
        }

        private void ServerAddressModified(object sender, EventArgs e)
        {
            Client.Instance.ServerAddress = ServerAddress.Text;
        }
        #endregion


        private void LoginButtonClick(object sender, EventArgs e)
        {
            IServer connection = Client.Instance.Connection;

            /*try
            {*/
                bool login = Client.Instance.Login(nicknameText.Text, passwordText.Text);

                if (login)
                {
                    StatusLabel.Visible = false;
                    MainForm mf = new MainForm();
                    Hide();
                    mf.ShowDialog();
                    Show();
                }
                else
                {
                    StatusLabel.Text = "Invalid login.";
                    StatusLabel.Visible = true;
                }
           /* }
            catch (Exception ex)
            {
                StatusLabel.Text = "Unable to reach server.";
                StatusLabel.Visible = true;
                Console.WriteLine(ex.ToString());
            }*/
        }

        private void RegisterButtonClick(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.ShowDialog();
        }

        private void LoginFormClosing(object sender, FormClosingEventArgs e)
        {
            if (Client.Instance.Connection == null) { 
                return;
            }

            try
            {
                Client.Instance.MaybeLogout(passwordText.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
