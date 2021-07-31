using System.IO;
using System.Collections.Generic;

namespace NitroLogger.Messages
{
    public class MessageHandler
    {
        private readonly Dictionary<short, string> OutgoingMessages;
        private readonly Dictionary<short, string> IncomingMessages;

        public MessageHandler()
        {
            OutgoingMessages = new Dictionary<short, string>();
            IncomingMessages = new Dictionary<short, string>();
        }

        public void LoadMessages(string path)
        {
            if (!File.Exists(path))
                return;

            string[] lines = File.ReadAllLines(path);
            bool isOutgoing = true;

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (line == "[Incoming]")
                {
                    isOutgoing = false;
                    continue;
                }

                short header = short.Parse(line.Split(':')[1]);
                string name = line.Split(':')[0];

                if (isOutgoing && !OutgoingMessages.ContainsKey(header))
                    OutgoingMessages.Add(header, name);
                else if (!isOutgoing && !IncomingMessages.ContainsKey(header))
                    IncomingMessages.Add(header, name);
            }
        }

        public string GetOutgoingMessage(short header)
        {
            OutgoingMessages.TryGetValue(header, out string value);
            return value;
        }
        public string GetIncomingMessage(short header)
        {
            IncomingMessages.TryGetValue(header, out string value);
            return value;
        }
    }
}