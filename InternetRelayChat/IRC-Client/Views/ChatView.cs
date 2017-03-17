using IRC_Client.ViewModels;
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
    public partial class ChatView : MaterialForm
    {
        #region Singleton

        public static ChatView instance;

        public static ChatView Instance
        {
            get
            {
                if(instance == null)
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

        private ChatView()
        {
            InitializeComponent();
            ChatViewBindingSource.Add(ChatViewModel.Instance);

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
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

        #endregion

        private void SendButton_Click(object sender, EventArgs e)
        {
            ChatTabPage t = new ChatTabPage(null);
            ChatTabsControl.TabPages.Add(t);
        }
    }
}
