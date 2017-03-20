using IRC_Client.Comunication;
using IRC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Server.Models
{
    public class ChatRoom
    {
        public List<IClient> Users { get; set; }

        private Dictionary<string, PeerCommunicator> peers = new Dictionary<string, PeerCommunicator>();

        public ChatRoom(List<IClient> users)
        {
            this.Users = users;
        }

        public void SendMessage(IClient client, string message)
        {
            
        }
    }
}
