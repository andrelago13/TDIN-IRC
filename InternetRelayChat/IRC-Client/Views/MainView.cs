using IRC_Client.Models;
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
            this.MainViewBindingSource.Add(MainViewModel.Instance);

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void LoginButtonClick(object sender, EventArgs e)
        {            
            try
            {
                bool login = Client.Instance.Login(NicknameInput.Text, PasswordInput.Text);

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
                MainViewModel.Instance.Status = ex.Message;
                Console.WriteLine(ex.ToString());
            }
        }

        private void LoginFormClosing(object sender, FormClosingEventArgs e) { }

        private void RegisterButtonClick(object sender, EventArgs e)
        {
            IServer connection = Client.Instance.ServerConnection.Connection;

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
