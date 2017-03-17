using IRC_Client.Models;
using IRC_Common;
using IRC_Common.Models;
using System;

namespace IRC_Client.Comunication
{
    public delegate void HandleMessage(Client sender, string message);
    public delegate void HandleChat(IClient sender);

    public class PeerCommunicator : MarshalByRefObject
    {
        public Client MyClient { get; }

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
}
