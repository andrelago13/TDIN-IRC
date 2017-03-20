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
        public string Hash { get; }

        public IClient Owner { get; }

        public List<IClient> Users { get; }

        private Dictionary<string, PeerCommunicator> Peers;

        public ChatRoom(IClient owner, List<IClient> users)
        {
            this.Owner = owner;
            this.Users = users;
            this.Peers = new Dictionary<string, PeerCommunicator>();
            // Generate random hash
            string guidString = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            guidString = guidString.Replace("=", "");
            guidString = guidString.Replace("+", "");
            this.Hash = guidString;
        }

        public void InviteAllUsers()
        {
            foreach(IClient client in Users)
            {
                InviteUser(client);
            }
        }

        private void InviteUser(IClient client)
        {
            if (client == null)
                return;

            PeerCommunicator pc = GetClientCommunicator(client.Address, client.Port);
            bool result = pc.RequestChat(Owner);
            if (result)
            {
                this.Peers.Add(client.Nickname, pc);
                NewChatEvent?.Invoke(client);
            }
            return;
        }

        public void SendMessage(IClient client, string message)
        {
            
        }
    }
}
