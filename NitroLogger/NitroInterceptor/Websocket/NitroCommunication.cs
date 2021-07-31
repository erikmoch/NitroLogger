using WebSocketSharp;
using WebSocketSharp.Server;

using NitroInterceptor.Message;

namespace NitroInterceptor.Websocket
{
    public class NitroCommunication
    {

        private static WebSocketServer _server;

        public static WebSocketSessionManager Local => _server.WebSocketServices["/"].Sessions;
        public static Interceptor _interceptor;
        public static WebSocket remote;

        public NitroCommunication(Interceptor interceptorInstance)
        {
            _interceptor = interceptorInstance;
        }

        public void StartListener()
        {
            _server = new WebSocketServer(8080);
            _server.AddWebSocketService<Server>("/");
            _server.Start();
        }

        public void StartRemote(string socket_url)
        {
            remote = new WebSocket(socket_url);
            remote.SslConfiguration.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12;

            remote.OnMessage += (object sender, MessageEventArgs e) =>
            {
                NMessage message = new NMessage(e.RawData, false);
                _interceptor.OnMessage(message);

                if (!message.IsBlocked)
                    Local.Broadcast(message.ToBytes());
            };
            remote.OnOpen += (object sender, System.EventArgs e) => _interceptor.OnConnected();
            remote.OnClose += (object sender, CloseEventArgs e) => _interceptor.OnDisconnected(e.Reason);
        }

        public void Stop()
        {
            if (remote.IsAlive)
                remote.Close();
            if (_server.IsListening)
                _server.Stop();
        }

        public void SendToServer(NMessage message) => remote.Send(message.ToBytes());
        public void SendToClient(NMessage message) => Local.Broadcast(message.ToBytes());
    }


    public class Server : WebSocketBehavior
    {
        protected override void OnOpen()
        {
            if (!NitroCommunication.remote.IsAlive)
                NitroCommunication.remote.Connect();
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            if (e.IsBinary)
            {
               NMessage message = new NMessage(e.RawData, true);
               NitroCommunication._interceptor.OnMessage(message);

                if (!message.IsBlocked)
                    NitroCommunication.remote.Send(message.ToBytes());
            }
        }
    }
}