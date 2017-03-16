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

        private async void LoginButtonClick(object sender, EventArgs e)
        {
            LoginButton.Enabled = false;

            bool validLogin = await Task.Run<bool>(() => MainViewModel.Instance.Login());
            if(validLogin)
            {
                MessagingView mf = new MessagingView();
                Hide();
                mf.ShowDialog();
                Show();
            }
        }

        private async void RegisterButtonClick(object sender, EventArgs e)
        {
            RegisterButton.Enabled = false;
            await Task.Run<bool>(() => MainViewModel.Instance.Register());
        }
    }
}
