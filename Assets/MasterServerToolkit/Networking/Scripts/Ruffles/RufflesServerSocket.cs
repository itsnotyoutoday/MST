using System;
using Ruffles;

namespace MasterServerToolkit.Networking
{

    public class RufflesServerSocket : IServerSocket, IUpdatable
    {
        public bool UseSsl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CertificatePath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CertificatePassword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event PeerActionHandler OnPeerConnectedEvent;
        public event PeerActionHandler OnPeerDisconnectedEvent;

        public void Listen(int port)
        {
            throw new NotImplementedException();
        }

        public void Listen(string ip, int port)
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

}