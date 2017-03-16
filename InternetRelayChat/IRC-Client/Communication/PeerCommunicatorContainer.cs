using System;

namespace IRC_Client.Comunication
{
    public class PeerCommunicatorContainer : MarshalByRefObject
    {
        public static PeerCommunicator Communicator { get; set; }

        public PeerCommunicator GetCommunicator()
        {
            return Communicator;
        }
    }
}
