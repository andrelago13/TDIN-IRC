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

        public static bool Exists
        {
            get
            {
                return instance != null;
            }
        }

        private ChatView()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            Client.Instance.MessageEvent += HandleMessage;
        }

        #endregion

        #region Public methods

        public bool IsActive
        {
            get
            {
                return instance == null;
            }
        }

        public static void StartChatView()
        {
            if (instance == null)
                instance = new ChatView();

            instance.Show();
        }

        public void StartChat(IClient client)
        {
            PeerCommunicator pc = Client.Instance.GetClientCommunicator(client);
            AddChat(client, pc);
            Show();
        }

        public void AddChat(IClient client, PeerCommunicator pc)
        {
            ChatTabPage t = new ChatTabPage(client, pc);
            ChatTabsControl.TabPages.Add(t);
        }

        public void Terminate()
        {
            // TODO
            Dispose();
        }

        #endregion

        private void SendButton_Click(object sender, EventArgs e)
        {
            string text = MessageInput.Text;
            if (text == null || text.Length == 0)
                return;

            ((ChatTabPage) ChatTabsControl.TabPages[ChatTabsControl.SelectedIndex]).SendMessage(text);
        }

        public void HandleMessage(Client sender, string message)
        {
            TabPageCollection pages = ChatTabsControl.TabPages;
            foreach(TabPage page in pages)
            {
                if (((ChatTabPage)page).HandleMessage(sender, message))
                    return;
            }
        }
    }
}
