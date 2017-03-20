using IRC_Common;
using System;

namespace IRC_Client.Comunication
{
    public delegate void HandleMessage(IClient sender, string message);
    public delegate void HandleChat(IClient sender);

    public class PeerCommunicator : MarshalByRefObject
    {
        public IClient MyClient { get; }

        public PeerCommunicator(IClient client)
        {
            MyClient = client;
        }

        public bool RequestChat(IClient requestingClient)
        {
            return MyClient.HandleInvite(requestingClient);
        }

        public void SendMessage(IClient sender, string message)
        {
            MyClient.ReceiveMessage(sender, message);
        }
    }
}
