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
            this.InitializeComponent();
            this.LoginViewBindingSource.Add(LoginViewModel.Instance);
        }

        private void LoginButtonClick(object sender, EventArgs e)
        {            
            /*try
            {*/
                bool login = Client.Instance.Login(NicknameInput.Text, PasswordInput.Text);

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
            /*}
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
                Client.Instance.MaybeLogout(LoginViewModel.Instance.Password);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
