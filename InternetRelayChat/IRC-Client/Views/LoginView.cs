using IRC_Client.ViewModels;
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

namespace IRC_Client.Views
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
            this.loginViewModelBindingSource.DataSource = new LoginViewModel();
            this.InitializeDataBindings();
        }

        private void InitializeDataBindings()
        {
            this.nicknameText.DataBindings.Add("Text", this.loginViewModelBindingSource, "Nickname", true);
            this.passwordText.DataBindings.Add("Text", this.loginViewModelBindingSource, "Password", true);
            this.ServerAddress.DataBindings.Add("Text", this.loginViewModelBindingSource, "ServerAddress", true);
            this.ServerPort.DataBindings.Add("Text", this.loginViewModelBindingSource, "ServerPort", true);
        }

        private void LoginButtonClick(object sender, EventArgs e)
        {
            IServer connection = Client.Instance.Connection;

            try
            {
                bool login = connection.Login(nicknameText.Text, passwordText.Text, "", 0);

                if (login)
                {
                    StatusLabel.Visible = false;
                    MainForm mf = new MainForm(connection, new LoggedUserInfo(nicknameText.Text, "", "", 0));
                    Hide();
                    mf.ShowDialog();
                    Show();
                }
                else
                {
                    StatusLabel.Text = "Invalid login.";
                    StatusLabel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                StatusLabel.Text = "Unable to reach server.";
                StatusLabel.Visible = true;
                Console.WriteLine(ex.ToString());
            }
        }

        private void RegisterButtonClick(object sender, EventArgs e)
        {
            IServer connection = Client.Instance.Connection;

            RegisterForm rf = new RegisterForm(connection);
            rf.ShowDialog();
        }

        private void LoginFormClosing(object sender, FormClosingEventArgs e)
        {
            IServer connection = Client.Instance.Connection;
            if (connection == null) { 
                return;
            }

            try
            {
                connection.Logout(nicknameText.Text, passwordText.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
