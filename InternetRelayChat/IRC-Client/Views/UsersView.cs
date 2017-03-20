﻿using IRC_Client.Comunication;
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
    public partial class UsersView : MaterialForm
    {
        private static UsersView instance;
        public static UsersView Instance
        {
            get
            {
                if (instance == null)
                    instance = new UsersView();
                return instance;
            }
        }

        public static bool Exists
        {
            get
            {
                return instance != null;
            }
        }

        private UsersView()
        {
            this.InitializeComponent();
            UsersViewModel.Instance.Controller = this;
            this.MessagingViewBindingSource.Add(UsersViewModel.Instance);

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void MessagingViewLoad(object sender, EventArgs e)
        {
            RefreshUsers();
            Client.Instance.SessionsEvent += new SessionUpdateHandler(HandleSession);
        }

        private void HandleSession(LoggedClient info)
        {
            if (this.InvokeRequired)
            {
                Utils.ControlInvoke(this, () => HandleSession(info));
                return;
            }
            if (info.IsLogged)
            {
                LoggedClient client = new LoggedClient(info.Nickname, info.RealName, info.Address, info.Port);
                UsersViewModel.Instance.LoggedUsers.Add(client);
                UserList.Items.Add(new ListViewItem(client.RealName + " [" + client.Nickname + "]"));
            }
        }

        private void MessagingViewClosing(object sender, FormClosingEventArgs e)
        {
            if(ChatView.Exists)
            {
                ChatView.Instance.Terminate();
            }

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
            if (UserList.SelectedIndices.Count == 0)
                return;

            int val = UserList.SelectedIndices[0];
            UsersViewModel.Instance.InviteClient(UsersViewModel.Instance.LoggedUsers[val]);
        }

        private void RefreshUsers()
        {
            UsersViewModel.Instance.UpdateOnlineUsers();
            UserList.Items.Clear();
            foreach (LoggedClient client in UsersViewModel.Instance.LoggedUsers)
            {
                ListViewItem item = new ListViewItem(client.RealName + " [" + client.Nickname + "]");
                UserList.Items.Add(item);
            }
        }
    }
}