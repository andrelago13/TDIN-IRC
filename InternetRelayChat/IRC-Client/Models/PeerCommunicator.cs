using IRC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Client.Models
{
    public delegate void HandleMessage(Client sender, string message);

    public class PeerCommunicator : MarshalByRefObject
    {
        private Client MyClient { get; set; }

        public PeerCommunicator(Client client)
        {
            MyClient = client;
        }

        public bool RequestChat(Client requestingClient)
        {
            return MyClient.HandleInvite(requestingClient);
        }

        public void SendMessage(Client sender, string message)
        {
            MyClient.ReceiveMessage(sender, message);
        }
    }

    public interface InviteListener
    {
        bool HandleInvite(Client client);
    }
}
