using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IRC_Common.Models;
using IRC_Common;
using IRC_Client.Comunication;

namespace IRC_Client.Views
{
    public partial class ChatUserControl : UserControl
    {
        private IClient user;
        private PeerCommunicator pc;

        public ChatUserControl(IClient user, PeerCommunicator pc)
        {
            InitializeComponent();
            this.user = user;
            this.pc = pc;
            chatText.Text = "==> Chatting with " + user.RealName + " [" + user.Nickname + "] <==" + '\n';
        }
    }
}
