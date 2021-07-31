using System;
using System.Net;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using Titanium.Web.Proxy;
using Titanium.Web.Proxy.Models;
using Titanium.Web.Proxy.EventArguments;

namespace NitroLogger.Network
{
    public class ClientInterceptor
    {
        public bool isIntercepting;

        public event EventHandler<InterceptedEventArgs> Intercepted;

        private ProxyServer server;
        private ExplicitProxyEndPoint endpoint;

        public void Switch()
        {
            if (!isIntercepting)
            {
                isIntercepting = true;

                server = new ProxyServer(true, false, false);
                endpoint = new ExplicitProxyEndPoint(IPAddress.Any, 9090, true);

                server.AddEndPoint(endpoint);
                server.BeforeResponse += new AsyncEventHandler<SessionEventArgs>(Server_BeforeResponse);
                server.Start();
                server.SetAsSystemHttpProxy(endpoint);
                server.SetAsSystemHttpsProxy(endpoint);
            }
            else
            {
                isIntercepting = false;
                server.Dispose();
            }
        }

        private Task Server_BeforeResponse(object sender, SessionEventArgs e)
        {
            try
            {
                string responseBody = e.GetResponseBodyAsString().Result;
                if (responseBody.Contains("socket.url"))
                {
                    string value = Regex.Match(responseBody, "\"socket.url\": \"(.+?)\",").Groups[1].Value;
                    e.SetResponseBodyString(responseBody.Replace(value, "ws://127.0.0.1:8080"));
                    Intercepted.Invoke(this, new InterceptedEventArgs(value));
                }
            }
            catch { }
            return Task.CompletedTask;
        }
    }
}