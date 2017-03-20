using IRC_Client.Comunication;
using IRC_Client.Models;
using IRC_Common;
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
        private string GroupHash;
        private PeerCommunicator pc;
        private ChatUserControl control;

        public ChatTabPage(IClient user, PeerCommunicator pc)
        {
            this.user = user;
            this.pc = pc;
            Initialize();
        }

        public ChatTabPage(string group)
        {
            this.GroupHash = group;
            Initialize();
        }

        private void Initialize()
        {
            if (this.GroupHash == null)
            {
                control = new ChatUserControl(user, pc);
                Text = user?.RealName;
            }
            else
            {
                control = new ChatUserControl(this.GroupHash);
                Text = this.GroupHash;
            }

            Controls.Add(control);
        }

        public void SendMessage(string message)
        {
            if(GroupHash == null)
            {
                pc.SendMessage(Client.Instance, message);
            }
            else
            {
                ServerConnection serverConnection = Client.Instance.ServerConnection;
                if (serverConnection == null)
                    return;

                IServer server = serverConnection.Connection;
                if (server == null)
                    return;

                server.SendMessageChatRoom(Client.Instance, GroupHash, message);
            }

            control.SendMessage(message);
        }

        public bool HandleMessage(IClient sender, string message)
        {
            if(sender.Nickname != user.Nickname)
                return false;

            if(message == null || message.Length == 0)
            {
                this.Dispose();
            }

            control.ReceiveMessage(message);

            return true;
        }

        public bool HandleGroupMessage(IClient sender, string hash, string message)
        {
            if (hash.Equals(this.GroupHash))
                return false;

            if (message == null || message.Length == 0)
            {
                this.Dispose();
            }

            control.ReceiveGroupMessage(sender, message);

            return true;
        }
    }
}
