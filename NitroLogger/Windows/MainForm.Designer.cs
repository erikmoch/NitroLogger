
namespace NitroLogger.Windows
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnInterceptClient = new System.Windows.Forms.Button();
            this.BtnSendToServer = new System.Windows.Forms.Button();
            this.SendToClient = new System.Windows.Forms.Button();
            this.txtPacket = new System.Windows.Forms.TextBox();
            this.cbAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnUnblock = new System.Windows.Forms.Button();
            this.BtnBlock = new System.Windows.Forms.Button();
            this.txtPacketToBeBlocked = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbIsOutgoing = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBulletPacket = new System.Windows.Forms.TextBox();
            this.txtTriggerPacket = new System.Windows.Forms.TextBox();
            this.BtnStartTrigger = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnResetPacket = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDecomposed = new System.Windows.Forms.TextBox();
            this.BtnReadBool = new System.Windows.Forms.Button();
            this.BtnReadString = new System.Windows.Forms.Button();
            this.BtnReadInt = new System.Windows.Forms.Button();
            this.txtPacketToDecompose = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComposed = new System.Windows.Forms.TextBox();
            this.BtnWriteBoolean = new System.Windows.Forms.Button();
            this.BtnWriteString = new System.Windows.Forms.Button();
            this.BtnWriteInt = new System.Windows.Forms.Button();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnInterceptClient
            // 
            this.BtnInterceptClient.Location = new System.Drawing.Point(10, 12);
            this.BtnInterceptClient.Name = "BtnInterceptClient";
            this.BtnInterceptClient.Size = new System.Drawing.Size(600, 20);
            this.BtnInterceptClient.TabIndex = 0;
            this.BtnInterceptClient.Text = "Intercept Client";
            this.BtnInterceptClient.UseVisualStyleBackColor = true;
            this.BtnInterceptClient.Click += new System.EventHandler(this.BtnInterceptClient_Click);
            // 
            // BtnSendToServer
            // 
            this.BtnSendToServer.Location = new System.Drawing.Point(154, 45);
            this.BtnSendToServer.Name = "BtnSendToServer";
            this.BtnSendToServer.Size = new System.Drawing.Size(138, 22);
            this.BtnSendToServer.TabIndex = 2;
            this.BtnSendToServer.Text = "Send to Server";
            this.BtnSendToServer.UseVisualStyleBackColor = true;
            this.BtnSendToServer.Click += new System.EventHandler(this.BtnSendToServer_Click);
            // 
            // SendToClient
            // 
            this.SendToClient.Location = new System.Drawing.Point(8, 45);
            this.SendToClient.Name = "SendToClient";
            this.SendToClient.Size = new System.Drawing.Size(138, 22);
            this.SendToClient.TabIndex = 3;
            this.SendToClient.Text = "Send to Client";
            this.SendToClient.UseVisualStyleBackColor = true;
            this.SendToClient.Click += new System.EventHandler(this.SendToClient_Click);
            // 
            // txtPacket
            // 
            this.txtPacket.Location = new System.Drawing.Point(8, 19);
            this.txtPacket.Name = "txtPacket";
            this.txtPacket.Size = new System.Drawing.Size(284, 20);
            this.txtPacket.TabIndex = 4;
            // 
            // cbAlwaysOnTop
            // 
            this.cbAlwaysOnTop.AutoSize = true;
            this.cbAlwaysOnTop.Location = new System.Drawing.Point(10, 385);
            this.cbAlwaysOnTop.Name = "cbAlwaysOnTop";
            this.cbAlwaysOnTop.Size = new System.Drawing.Size(98, 17);
            this.cbAlwaysOnTop.TabIndex = 7;
            this.cbAlwaysOnTop.Text = "Always On Top";
            this.cbAlwaysOnTop.UseVisualStyleBackColor = true;
            this.cbAlwaysOnTop.CheckedChanged += new System.EventHandler(this.CbAlwaysOnTop_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPacket);
            this.groupBox1.Controls.Add(this.BtnSendToServer);
            this.groupBox1.Controls.Add(this.SendToClient);
            this.groupBox1.Location = new System.Drawing.Point(10, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 77);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Packet Sender";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnUnblock);
            this.groupBox2.Controls.Add(this.BtnBlock);
            this.groupBox2.Controls.Add(this.txtPacketToBeBlocked);
            this.groupBox2.Location = new System.Drawing.Point(10, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 77);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Packet Blocker";
            // 
            // BtnUnblock
            // 
            this.BtnUnblock.Location = new System.Drawing.Point(154, 45);
            this.BtnUnblock.Name = "BtnUnblock";
            this.BtnUnblock.Size = new System.Drawing.Size(138, 22);
            this.BtnUnblock.TabIndex = 6;
            this.BtnUnblock.Text = "Unblock Packet";
            this.BtnUnblock.UseVisualStyleBackColor = true;
            this.BtnUnblock.Click += new System.EventHandler(this.BtnUnblock_Click);
            // 
            // BtnBlock
            // 
            this.BtnBlock.Location = new System.Drawing.Point(8, 45);
            this.BtnBlock.Name = "BtnBlock";
            this.BtnBlock.Size = new System.Drawing.Size(138, 22);
            this.BtnBlock.TabIndex = 5;
            this.BtnBlock.Text = "Block Packet";
            this.BtnBlock.UseVisualStyleBackColor = true;
            this.BtnBlock.Click += new System.EventHandler(this.BtnBlock_Click);
            // 
            // txtPacketToBeBlocked
            // 
            this.txtPacketToBeBlocked.Location = new System.Drawing.Point(8, 19);
            this.txtPacketToBeBlocked.Name = "txtPacketToBeBlocked";
            this.txtPacketToBeBlocked.Size = new System.Drawing.Size(284, 20);
            this.txtPacketToBeBlocked.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbIsOutgoing);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtBulletPacket);
            this.groupBox3.Controls.Add(this.txtTriggerPacket);
            this.groupBox3.Controls.Add(this.BtnStartTrigger);
            this.groupBox3.Location = new System.Drawing.Point(10, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 177);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trigger";
            // 
            // cbIsOutgoing
            // 
            this.cbIsOutgoing.AutoSize = true;
            this.cbIsOutgoing.Checked = true;
            this.cbIsOutgoing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsOutgoing.Location = new System.Drawing.Point(9, 121);
            this.cbIsOutgoing.Name = "cbIsOutgoing";
            this.cbIsOutgoing.Size = new System.Drawing.Size(97, 17);
            this.cbIsOutgoing.TabIndex = 10;
            this.cbIsOutgoing.Text = "Send to Server";
            this.cbIsOutgoing.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Packet to be sended";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Packet to be intercepted";
            // 
            // txtBulletPacket
            // 
            this.txtBulletPacket.Location = new System.Drawing.Point(9, 91);
            this.txtBulletPacket.Name = "txtBulletPacket";
            this.txtBulletPacket.Size = new System.Drawing.Size(284, 20);
            this.txtBulletPacket.TabIndex = 5;
            // 
            // txtTriggerPacket
            // 
            this.txtTriggerPacket.Location = new System.Drawing.Point(9, 44);
            this.txtTriggerPacket.Name = "txtTriggerPacket";
            this.txtTriggerPacket.Size = new System.Drawing.Size(284, 20);
            this.txtTriggerPacket.TabIndex = 4;
            // 
            // BtnStartTrigger
            // 
            this.BtnStartTrigger.Location = new System.Drawing.Point(8, 144);
            this.BtnStartTrigger.Name = "BtnStartTrigger";
            this.BtnStartTrigger.Size = new System.Drawing.Size(284, 22);
            this.BtnStartTrigger.TabIndex = 3;
            this.BtnStartTrigger.Text = "Start";
            this.BtnStartTrigger.UseVisualStyleBackColor = true;
            this.BtnStartTrigger.Click += new System.EventHandler(this.BtnStartTrigger_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnResetPacket);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtDecomposed);
            this.groupBox4.Controls.Add(this.BtnReadBool);
            this.groupBox4.Controls.Add(this.BtnReadString);
            this.groupBox4.Controls.Add(this.BtnReadInt);
            this.groupBox4.Controls.Add(this.txtPacketToDecompose);
            this.groupBox4.Location = new System.Drawing.Point(316, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 150);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Packet Decomposer";
            // 
            // BtnResetPacket
            // 
            this.BtnResetPacket.Location = new System.Drawing.Point(6, 112);
            this.BtnResetPacket.Name = "BtnResetPacket";
            this.BtnResetPacket.Size = new System.Drawing.Size(282, 23);
            this.BtnResetPacket.TabIndex = 11;
            this.BtnResetPacket.Text = "Reset Packet";
            this.BtnResetPacket.UseVisualStyleBackColor = true;
            this.BtnResetPacket.Click += new System.EventHandler(this.BtnResetPacket_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Result";
            // 
            // txtDecomposed
            // 
            this.txtDecomposed.Location = new System.Drawing.Point(6, 86);
            this.txtDecomposed.Name = "txtDecomposed";
            this.txtDecomposed.ReadOnly = true;
            this.txtDecomposed.Size = new System.Drawing.Size(282, 20);
            this.txtDecomposed.TabIndex = 9;
            this.txtDecomposed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnReadBool
            // 
            this.BtnReadBool.Location = new System.Drawing.Point(192, 44);
            this.BtnReadBool.Name = "BtnReadBool";
            this.BtnReadBool.Size = new System.Drawing.Size(96, 23);
            this.BtnReadBool.TabIndex = 8;
            this.BtnReadBool.Text = "Read Boolean";
            this.BtnReadBool.UseVisualStyleBackColor = true;
            this.BtnReadBool.Click += new System.EventHandler(this.BtnReadBool_Click);
            // 
            // BtnReadString
            // 
            this.BtnReadString.Location = new System.Drawing.Point(99, 44);
            this.BtnReadString.Name = "BtnReadString";
            this.BtnReadString.Size = new System.Drawing.Size(96, 23);
            this.BtnReadString.TabIndex = 7;
            this.BtnReadString.Text = "Read String";
            this.BtnReadString.UseVisualStyleBackColor = true;
            this.BtnReadString.Click += new System.EventHandler(this.BtnReadString_Click);
            // 
            // BtnReadInt
            // 
            this.BtnReadInt.Location = new System.Drawing.Point(6, 44);
            this.BtnReadInt.Name = "BtnReadInt";
            this.BtnReadInt.Size = new System.Drawing.Size(96, 23);
            this.BtnReadInt.TabIndex = 6;
            this.BtnReadInt.Text = "Read Integer";
            this.BtnReadInt.UseVisualStyleBackColor = true;
            this.BtnReadInt.Click += new System.EventHandler(this.BtnReadInt_Click);
            // 
            // txtPacketToDecompose
            // 
            this.txtPacketToDecompose.Location = new System.Drawing.Point(6, 19);
            this.txtPacketToDecompose.Name = "txtPacketToDecompose";
            this.txtPacketToDecompose.Size = new System.Drawing.Size(282, 20);
            this.txtPacketToDecompose.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtValue);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.BtnReset);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtComposed);
            this.groupBox5.Controls.Add(this.BtnWriteBoolean);
            this.groupBox5.Controls.Add(this.BtnWriteString);
            this.groupBox5.Controls.Add(this.BtnWriteInt);
            this.groupBox5.Controls.Add(this.txtHeader);
            this.groupBox5.Location = new System.Drawing.Point(316, 194);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(294, 185);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Packet Composer";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(6, 42);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(282, 20);
            this.txtValue.TabIndex = 13;
            this.txtValue.Text = "Value";
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Header / ID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(6, 152);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(282, 23);
            this.BtnReset.TabIndex = 11;
            this.BtnReset.Text = "Reset Packet";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Result";
            // 
            // txtComposed
            // 
            this.txtComposed.Location = new System.Drawing.Point(6, 126);
            this.txtComposed.Name = "txtComposed";
            this.txtComposed.ReadOnly = true;
            this.txtComposed.Size = new System.Drawing.Size(282, 20);
            this.txtComposed.TabIndex = 9;
            this.txtComposed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnWriteBoolean
            // 
            this.BtnWriteBoolean.Location = new System.Drawing.Point(192, 67);
            this.BtnWriteBoolean.Name = "BtnWriteBoolean";
            this.BtnWriteBoolean.Size = new System.Drawing.Size(96, 23);
            this.BtnWriteBoolean.TabIndex = 8;
            this.BtnWriteBoolean.Text = "Write Boolean";
            this.BtnWriteBoolean.UseVisualStyleBackColor = true;
            this.BtnWriteBoolean.Click += new System.EventHandler(this.BtnWriteBoolean_Click);
            // 
            // BtnWriteString
            // 
            this.BtnWriteString.Location = new System.Drawing.Point(99, 67);
            this.BtnWriteString.Name = "BtnWriteString";
            this.BtnWriteString.Size = new System.Drawing.Size(96, 23);
            this.BtnWriteString.TabIndex = 7;
            this.BtnWriteString.Text = "Write String";
            this.BtnWriteString.UseVisualStyleBackColor = true;
            this.BtnWriteString.Click += new System.EventHandler(this.BtnWriteString_Click);
            // 
            // BtnWriteInt
            // 
            this.BtnWriteInt.Location = new System.Drawing.Point(6, 67);
            this.BtnWriteInt.Name = "BtnWriteInt";
            this.BtnWriteInt.Size = new System.Drawing.Size(96, 23);
            this.BtnWriteInt.TabIndex = 6;
            this.BtnWriteInt.Text = "Write Integer";
            this.BtnWriteInt.UseVisualStyleBackColor = true;
            this.BtnWriteInt.Click += new System.EventHandler(this.BtnWriteInt_Click);
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(76, 19);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(212, 20);
            this.txtHeader.TabIndex = 5;
            this.txtHeader.Text = "0";
            this.txtHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 414);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnInterceptClient);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbAlwaysOnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "NitroLogger - Disconnected";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInterceptClient;
        private System.Windows.Forms.Button BtnSendToServer;
        private System.Windows.Forms.Button SendToClient;
        private System.Windows.Forms.TextBox txtPacket;
        internal System.Windows.Forms.CheckBox cbAlwaysOnTop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnUnblock;
        private System.Windows.Forms.Button BtnBlock;
        private System.Windows.Forms.TextBox txtPacketToBeBlocked;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.CheckBox cbIsOutgoing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBulletPacket;
        private System.Windows.Forms.TextBox txtTriggerPacket;
        private System.Windows.Forms.Button BtnStartTrigger;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnResetPacket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDecomposed;
        private System.Windows.Forms.Button BtnReadBool;
        private System.Windows.Forms.Button BtnReadString;
        private System.Windows.Forms.Button BtnReadInt;
        private System.Windows.Forms.TextBox txtPacketToDecompose;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComposed;
        private System.Windows.Forms.Button BtnWriteBoolean;
        private System.Windows.Forms.Button BtnWriteString;
        private System.Windows.Forms.Button BtnWriteInt;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.TextBox txtValue;
    }
}

