using System;
using System.Windows.Forms;

using NitroLogger.Network;
using NitroInterceptor.Message;
using System.Collections.Generic;

namespace NitroLogger.Windows
{
    public partial class MainForm : Form
    {
        private readonly LoggerForm loggerForm;

        private readonly ClientInterceptor clientInterceptor;
        private readonly ConnectionHandler connectionHandler;

        private const string CONNECTED = "NitroLogger - Connected";
        private const string DISCONNECTED = "NitroLogger - Disconnected";

        private const string INTERCEPT_CLIENT = "Intercept Client";
        private const string INTERCEPTING_CLIENT = "Intercepting Client";
        private const string WAITING_CONNECTION = "Waiting Connection";

        private readonly List<int> blockedHeaders;

        private NMessage composedPacket;
        private NMessage decomposedPacket;

        public MainForm()
        {
            InitializeComponent();

            loggerForm = new LoggerForm();

            clientInterceptor = new ClientInterceptor();
            connectionHandler = new ConnectionHandler();

            blockedHeaders = new List<int>();

            clientInterceptor.Intercepted += (object sender, InterceptedEventArgs e) => ClientIntercepted(e.WebSocket_Url);

            connectionHandler.OnConnected += ConnectionHandler_OnConnected;
            connectionHandler.OnDisconnected += ConnectionHandler_OnDisconnected;
            connectionHandler.OnData += ConnectionHandler_OnData;

            loggerForm.Show();
        }

        private void ConnectionHandler_OnData(object sender, NMessage e)
        {
            if (blockedHeaders.Contains(e.Header))
                e.IsBlocked = true;

            else if (BtnStartTrigger.Text == "Stop")
            {
                NMessage triggerPacket = new NMessage(txtTriggerPacket.Text);
                NMessage bulletPacket = new NMessage(txtBulletPacket.Text)
                {
                    IsOutgoing = cbIsOutgoing.Checked
                };

                if (e.Header == triggerPacket.Header && !bulletPacket.IsCorrupted)
                    connectionHandler.SendData(bulletPacket);
            }

            loggerForm.AppendLog(e);
        }

        private void ConnectionHandler_OnConnected(object sender, EventArgs e)
        {
            Text = CONNECTED;
            BtnInterceptClient.Enabled = false;
            BtnInterceptClient.Text = "Connected";
        }

        private void ConnectionHandler_OnDisconnected(object sender, EventArgs e)
        {
            Text = DISCONNECTED;
            BtnInterceptClient.Enabled = true;
            BtnInterceptClient.Text = INTERCEPT_CLIENT;
        }

        private void ClientIntercepted(string websocket_url)
        {
            BtnInterceptClient.Text = WAITING_CONNECTION;

            clientInterceptor.Switch();
            connectionHandler.StartConnection(websocket_url);
        }

        private void CbAlwaysOnTop_CheckedChanged(object sender, EventArgs e) => TopMost = cbAlwaysOnTop.Checked;

        private void BtnInterceptClient_Click(object sender, EventArgs e)
        {
            BtnInterceptClient.Text = clientInterceptor.isIntercepting ? INTERCEPT_CLIENT : INTERCEPTING_CLIENT;
            clientInterceptor.Switch();
        }

        #region Packet Sender
        private void BtnSendToServer_Click(object sender, EventArgs e)
        {
            NMessage nmessage = new NMessage(txtPacket.Text);
            if (!nmessage.IsCorrupted)
            {
                nmessage.IsOutgoing = true;
                connectionHandler.SendData(nmessage);
            }
        }

        private void SendToClient_Click(object sender, EventArgs e)
        {
            NMessage nmessage = new NMessage(txtPacket.Text);
            if (!nmessage.IsCorrupted)
            {
                nmessage.IsOutgoing = false;
                connectionHandler.SendData(nmessage);
            }
        }
        #endregion

        #region Packet Blocker
        private void BtnBlock_Click(object sender, EventArgs e)
        {
            NMessage nmessage = new NMessage(txtPacketToBeBlocked.Text);
            if (!nmessage.IsCorrupted)
            {
                if (!blockedHeaders.Contains(nmessage.Header))
                    blockedHeaders.Add(nmessage.Header);
            }
        }

        private void BtnUnblock_Click(object sender, EventArgs e)
        {
            NMessage nmessage = new NMessage(txtPacketToBeBlocked.Text);
            if (!nmessage.IsCorrupted)
            {
                if (blockedHeaders.Contains(nmessage.Header))
                    blockedHeaders.Remove(nmessage.Header);
            }
        }
        #endregion

        #region Trigger
        private void BtnStartTrigger_Click(object sender, EventArgs e)
        {
            if (BtnStartTrigger.Text == "Start")
                BtnStartTrigger.Text = "Stop";
            else
                BtnStartTrigger.Text = "Start";
        }
        #endregion

        #region Packet Decomposer
        private void BtnReadString_Click(object sender, EventArgs e)
        {
            try
            {
                if (composedPacket == null)
                    composedPacket = new NMessage(txtPacketToDecompose.Text);

                txtDecomposed.Text = composedPacket.ReadString();
            }
            catch { }
        }

        private void BtnReadBool_Click(object sender, EventArgs e)
        {
            try
            {
                if (composedPacket == null)
                    composedPacket = new NMessage(txtPacketToDecompose.Text);

                txtDecomposed.Text = composedPacket.ReadBoolean().ToString();
            }
            catch { }
        }

        private void BtnReadInt_Click(object sender, EventArgs e)
        {
            try
            {
                if (composedPacket == null)
                    composedPacket = new NMessage(txtPacketToDecompose.Text);

                txtDecomposed.Text = composedPacket.ReadInteger().ToString();
            }
            catch { }
        }

        private void BtnResetPacket_Click(object sender, EventArgs e)
        {
            composedPacket = null;
            txtDecomposed.Text = "";
        }
        #endregion

        #region Packet Composer
        private void BtnWriteInt_Click(object sender, EventArgs e)
        {
            try
            {

                if (decomposedPacket == null)
                    decomposedPacket = new NMessage(short.Parse(txtHeader.Text));

                if (txtValue.TextLength > 0)
                    decomposedPacket.WriteInteger(int.Parse(txtValue.Text));

                txtComposed.Text = decomposedPacket.ToString();

            }
            catch { }
        }

        private void BtnWriteString_Click(object sender, EventArgs e)
        {
            try
            {

                if (decomposedPacket == null)
                    decomposedPacket = new NMessage(short.Parse(txtHeader.Text));

                if (txtValue.TextLength > 0)
                    decomposedPacket.WriteString(txtValue.Text);

                txtComposed.Text = decomposedPacket.ToString();
            }
            catch { }
        }

        private void BtnWriteBoolean_Click(object sender, EventArgs e)
        {
            try
            {
                if (decomposedPacket == null)
                    decomposedPacket = new NMessage(short.Parse(txtHeader.Text));

                if (txtValue.TextLength > 0)
                    decomposedPacket.WriteBoolean(bool.Parse(txtValue.Text));

                txtComposed.Text = decomposedPacket.ToString();
            }
            catch { }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            decomposedPacket = null;
            txtComposed.Text = "";
        }
        #endregion
    }
}