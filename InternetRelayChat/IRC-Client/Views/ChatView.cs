using IRC_Client.Comunication;
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
using static System.Windows.Forms.TabControl;

namespace IRC_Client.Views
{
    public partial class ChatView : MaterialForm
    {
        #region Singleton

        private static ChatView instance;

        public static ChatView Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChatView();
                }

                return instance;
            }
            set
            {
                instance = value;
            }
        }

        public ChatView()
        {
            InitializeComponent();
            ChatViewModel.Instance.Controller = this;
            ChatViewModelBindingSource.Add(ChatViewModel.Instance);
            ChatViewModel.Instance.View = this;
            ChatViewModel.Instance.Pages = ChatTabsControl.TabPages;

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            ChatViewModel.Instance.Start();
        }

        #endregion

        #region Public methods

        public static bool Exists
        {
            get
            {
                return instance != null;
            }
        }

        public void ShowChatView()
        {
            if (instance.IsDisposed)
                instance = new ChatView();

            if (!instance.Visible)
                instance.Show();
        }

        public void AddChat(IClient client, PeerCommunicator pc)
        {
            ChatTabPage t = new ChatTabPage(client, pc);
            ChatTabsControl.TabPages.Add(t);
        }

        public void AddGroupChat(string hash)
        {
            ChatTabPage t = new ChatTabPage(hash);
            ChatTabsControl.TabPages.Add(t);
        }

        public void Terminate()
        {
            Dispose();
        }

        #endregion

        #region Events

        private void SendButton_Click(object sender, EventArgs e)
        {
            ChatViewModel.Instance.SendMessage();
        }

        private void ChatView_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChatViewModel.Instance.Finish();
        }

        private void ChatTabsControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChatViewModel.Instance.ActivePage = ChatTabsControl.SelectedIndex;
        }

        private void MessageInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                ChatViewModel.Instance.MessageText = MessageInput.Text;
            }
        }

        #endregion
    }
}
