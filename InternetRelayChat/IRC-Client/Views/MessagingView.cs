using IRC_Client.Models;
using IRC_Client.ViewModels;
using IRC_Common;
using IRC_Common.Models;
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
    public partial class MessagingView : MaterialForm
    {
        public MessagingView()
        {
            this.InitializeComponent();
            this.MessagingViewBindingSource.Add(MessagingViewModel.Instance);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void MessagingViewLoad(object sender, EventArgs e)
        {
            MessagingViewModel.Instance.UpdateOnlineUsers();
            Client.Instance.SessionsEvent += new SessionUpdateHandler(HandleSession);
        }

        private void HandleSession(SessionUpdateArgs info)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate {
                    HandleSession(info);
                });
            }
            //TODO user the user list existing in the view model
            /*List<string> values = new List<string>();
            values.Add(info.Username + " [" + "+" + "]");
            userList.DataSource = values;*/
        }

        private void MessagingViewClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Client.Instance.MaybeLogout();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void InviteButtonClick(object sender, EventArgs e)
        {
            int val = UserList.SelectedIndex;
            Console.WriteLine(val);
        }

        private void RefreshButtonClick(object sender, EventArgs e)
        {
            MessagingViewModel.Instance.UpdateOnlineUsers();
        }
    }
}
