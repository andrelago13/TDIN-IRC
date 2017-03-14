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
    public partial class MainView : MaterialForm
    {
        public MainView()
        {
            this.InitializeComponent();
            this.LoginViewBindingSource.Add(MainViewModel.Instance);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void LoginButtonClick(object sender, EventArgs e)
        {
            IServer connection = ClientBk.Instance.Connection;
            
            try
            {
                bool login = connection.Login(NicknameInput.Text, PasswordInput.Text, "", 0);

                if (login)
                {
                    MessagingView mf = new MessagingView();
                    Hide();
                    mf.ShowDialog();
                    Show();
                }
                else
                {
                    MainViewModel.Instance.Status = "Invalid login credentials.";
                }
            }
            catch (Exception ex)
            {
                MainViewModel.Instance.Status = "Failed to login. Unable to reach server.";
                Console.WriteLine(ex.ToString());
            }
        }

        private void LoginFormClosing(object sender, FormClosingEventArgs e)
        {
            if (ClientBk.Instance.Connection == null) { 
                return;
            }

            try
            {
                ClientBk.Instance.MaybeLogout("");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void RegisterButtonClick(object sender, EventArgs e)
        {
            IServer connection = ClientBk.Instance.Connection;

            try
            {
                int result = connection.Register(NicknameInput.Text, RealNameInput.Text, PasswordInput.Text);
                switch (result)
                {
                    case 0:
                        StatusLabel.ForeColor = Color.Green;
                        break;
                    default:
                        StatusLabel.ForeColor = Color.Red;
                        break;
                }
                string reason;
                Utils.ErrorCodes.TryGetValue(result, out reason);
                MainViewModel.Instance.Status = reason;
            }
            catch (Exception ex)
            {
                MainViewModel.Instance.Status = "Failed to register. Unable to reach server.";
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
