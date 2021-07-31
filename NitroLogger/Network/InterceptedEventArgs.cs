using System;

namespace NitroLogger.Network
{
    public class InterceptedEventArgs : EventArgs
    {
        public string WebSocket_Url { get; }

        public InterceptedEventArgs(string websocket_url)
        {
            WebSocket_Url = websocket_url;
        }
    }
}