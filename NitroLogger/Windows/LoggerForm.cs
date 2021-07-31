using System.Drawing;
using System.Windows.Forms;

using NitroInterceptor.Message;
using NitroLogger.Messages;

namespace NitroLogger.Windows
{
    public partial class LoggerForm : Form
    {
        private readonly MessageHandler messageHandler;
        private delegate void LogDelegate(string msg, Color color);

        private const string FORMAT = "{0}[{1}] {2} {3}";

        public LoggerForm()
        {
            InitializeComponent();
            FormClosing += (object sender, FormClosingEventArgs e) => e.Cancel = true;
            messageHandler = new MessageHandler();
            messageHandler.LoadMessages("Messages.txt");
        }

        private void AlwaysOnTopToolStripMenuItem_Click(object sender, System.EventArgs e) => TopMost = alwaysOnTopToolStripMenuItem.Checked;
        private void ClearLogsToolStripMenuItem_Click(object sender, System.EventArgs e) => richTextBox1.Clear();

        public void AppendLog(NMessage nMessage)
        {
            if (nMessage.IsOutgoing && viewOutgoingToolStripMenuItem.Checked)
            {
                Log(string.Format(FORMAT, messageHandler.GetOutgoingMessage(nMessage.Header), nMessage.Header, "-->", nMessage.ToString()), Color.Blue);
                Log("------------------------------------------------------------------------------------", Color.White);
            }
            else if (!nMessage.IsOutgoing && viewIncomingToolStripMenuItem.Checked)
            {
                Log(string.Format(FORMAT, messageHandler.GetIncomingMessage(nMessage.Header), nMessage.Header, "<--", nMessage.ToString()), Color.Red);
                Log("------------------------------------------------------------------------------------", Color.White);
            }
        }

        public void Log(string msg, Color color)
        {
            if (InvokeRequired)
            {
                Invoke(new LogDelegate(Log), new object[] { msg, color });
            }
            else
            {
                richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.SelectionLength = 0;
                richTextBox1.SelectionColor = color;
                richTextBox1.AppendText((richTextBox1.TextLength > 0) ? ("\n" + msg) : msg);
                richTextBox1.SelectionColor = richTextBox1.ForeColor;
            }
        }
    }
}