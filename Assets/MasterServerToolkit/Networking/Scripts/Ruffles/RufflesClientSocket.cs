using System;
using Ruffles;

namespace MasterServerToolkit.Networking {
    public class RufflesClientSocket : BaseClientSocket<RufflesPeer>, IClientSocket, IUpdatable
    {
        public ConnectionStatus Status => throw new NotImplementedException();

        public bool IsConnected => throw new NotImplementedException();

        public bool IsConnecting => throw new NotImplementedException();

        public string ConnectionIp => throw new NotImplementedException();

        public int ConnectionPort => throw new NotImplementedException();

        public bool UseSsl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        IPeer IMsgDispatcher<IPeer>.Peer => throw new NotImplementedException();

        public event Action OnConnectedEvent;
        public event Action OnDisconnectedEvent;
        public event Action<ConnectionStatus> OnStatusChangedEvent;

        public void AddConnectionListener(Action callback, bool invokeInstantlyIfConnected = true)
        {
            throw new NotImplementedException();
        }

        public void AddDisconnectionListener(Action callback, bool invokeInstantlyIfDisconnected = true)
        {
            throw new NotImplementedException();
        }

        public IClientSocket Connect(string ip, int port, float timeoutSeconds)
        {
            throw new NotImplementedException();
        }

        public IClientSocket Connect(string ip, int port)
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public void Reconnect()
        {
            throw new NotImplementedException();
        }

        public void RemoveConnectionListener(Action callback)
        {
            throw new NotImplementedException();
        }

        public void RemoveDisconnectionListener(Action callback)
        {
            throw new NotImplementedException();
        }

        public void RemoveHandler(IPacketHandler handler)
        {
            throw new NotImplementedException();
        }

        public IPacketHandler SetHandler(IPacketHandler handler)
        {
            throw new NotImplementedException();
        }

        public IPacketHandler SetHandler(short opCode, IncommingMessageHandler handlerMethod)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void WaitForConnection(Action<IClientSocket> connectionCallback, float timeoutSeconds)
        {
            throw new NotImplementedException();
        }

        public void WaitForConnection(Action<IClientSocket> connectionCallback)
        {
            throw new NotImplementedException();
        }
    }
}