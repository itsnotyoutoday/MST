using System;
using Ruffles;

namespace MasterServerToolkit.Networking
{
    public class RufflesPeerServer : BasePeer
    {
        public override bool IsConnected => throw new NotImplementedException();

        public override void Disconnect(string reason)
        {
            throw new NotImplementedException();
        }

        public override void SendMessage(IMessage message, DeliveryMethod deliveryMethod)
        {
            throw new NotImplementedException();
        }
    }

}