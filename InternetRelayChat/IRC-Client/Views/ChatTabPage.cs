using IRC_Client.Comunication;
using IRC_Client.Models;
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
        private ChatUserControl control;

        public ChatTabPage(IClient user, PeerCommunicator pc)
        {
            this.user = user;
            this.pc = pc;
            Initialize();
        }

        private void Initialize()
        {
            control = new ChatUserControl(user, pc) { Dock = DockStyle.Fill };
            Controls.Add(control);
            Text = user?.RealName;
        }

        public void SendMessage(string message)
        {
            pc.SendMessage(Client.Instance, message);
            control.SendMessage(message);
        }

        public bool HandleMessage(Client sender, string message)
        {
            if(sender.Nickname != user.Nickname)
                return false;

            control.ReceiveMessage(message);

            return true;
        }
    }
}
