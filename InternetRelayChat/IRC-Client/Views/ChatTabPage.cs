using IRC_Client.Comunication;
using IRC_Common;
using IRC_Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRC_Client.Views
{
    class ChatTabPage : TabPage
    {
        private IClient user;
        private PeerCommunicator pc;

        public ChatTabPage(IClient user, PeerCommunicator pc)
        {
            this.user = user;
            this.pc = pc;
            Initialize();
        }

        private void Initialize()
        {
            Controls.Add(new ChatUserControl(user, pc) { Dock = DockStyle.Fill });
            Text = user?.RealName;
        }
    }
}
