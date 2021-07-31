using System;

using NitroInterceptor;
using NitroInterceptor.Message;

namespace NitroLogger.Network
{
    public class ConnectionHandler
    {
        public bool isConnected;

        private Interceptor interceptor;

        public event EventHandler OnConnected;
        public event EventHandler OnDisconnected;

        public event EventHandler<NMessage> OnData;

        public ConnectionHandler()
        {
            interceptor = new Interceptor();
        }

        public void StartConnection(string websocket_url)
        {
            interceptor.OnConnectionStarted += (object sender, EventArgs e) =>
            {
                isConnected = true;
                OnConnected.Invoke(this, null);
            };

            interceptor.OnConnectionStopped += (object sender, string e) =>
            {
                isConnected = false;
                OnDisconnected.Invoke(this, null);
            };

            interceptor.OnMessageReceived += (object sender, NMessage e) => OnData.Invoke(this, e);
            interceptor.Connect(websocket_url);
        }

        public void SendData(NMessage nmessage)
        {
            if (nmessage.IsOutgoing)
                interceptor.SendToServer(nmessage);
            else
                interceptor.SendToClient(nmessage);
        }

        public void StopConnection()
        {
            interceptor.Stop();
        }
    }
}