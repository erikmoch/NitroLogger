using System;
using NitroInterceptor.Message;
using NitroInterceptor.Websocket;

namespace NitroInterceptor
{
    public class Interceptor
    {
        private NitroCommunication communication;

        public event EventHandler<NMessage> OnMessageReceived;
        public event EventHandler<string> OnConnectionStopped;
        public event EventHandler OnConnectionStarted;

        public Interceptor()
        {
            communication = new NitroCommunication(this);
            communication.StartListener();
        }

        public void Connect(string socket_url) => communication.StartRemote(socket_url);
        public void Stop() => communication.Stop();

        public void SendToServer(NMessage message) => communication.SendToServer(message);
        public void SendToClient(NMessage message) => communication.SendToClient(message);

        public void OnMessage(NMessage message) => OnMessageReceived?.Invoke(this, message);
        public void OnConnected() => OnConnectionStarted?.Invoke(this, EventArgs.Empty);
        public void OnDisconnected(string reason) => OnConnectionStopped?.Invoke(this, reason);
    }
}