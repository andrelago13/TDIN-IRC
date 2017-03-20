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

        #region Invites
        public async void InviteAllUsers()
        {
            bool result;
            foreach(IClient client in Users)
            {
                result = await Task.Run<bool>(() => InviteUser(client));
                Console.WriteLine("Client: " + client.Nickname + " answered " + result);
            }
        }

        private bool InviteUser(IClient client)
        {
            if (client == null)
                return false;

            PeerCommunicator communicator = Utils.GetClientCommunicator(client);
            bool result = communicator.RequestChat(Owner);
            if (result)
            {
                this.Peers.Add(client.Nickname, communicator);
            }
            return result;
        }
        #endregion

        #region Messages
        public void SendMessage(IClient sender, string message)
        {
            PeerCommunicator communicator;
            foreach(IClient client in Users)
            {
                if (!Peers.TryGetValue(client.Nickname, out communicator))
                    return;

                communicator.SendMessage(sender, message);
            }
        }
        #endregion
    }
}
