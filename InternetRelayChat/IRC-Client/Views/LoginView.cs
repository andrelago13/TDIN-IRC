using IRC_Client.ViewModels;
using IRC_Common;
using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class LoginView : MaterialForm
    {
        public LoginView()
        {
            this.InitializeComponent();
            this.LoginViewBindingSource.Add(LoginViewModel.Instance);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void LoginButtonClick(object sender, EventArgs e)
        {
            IServer connection = Client.Instance.Connection;
            
            try
            {
                bool login = connection.Login(NicknameInput.Text, PasswordInput.Text, "", 0);

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
            }
            catch (Exception ex)
            {
                StatusLabel.Text = "Unable to reach server.";
                StatusLabel.Visible = true;
                Console.WriteLine(ex.ToString());
            }
        }

        private void LoginFormClosing(object sender, FormClosingEventArgs e)
        {
            if (Client.Instance.Connection == null) { 
                return;
            }

            try
            {
                Client.Instance.MaybeLogout("");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void RegisterButtonClick(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.ShowDialog();
        }
    }
}
