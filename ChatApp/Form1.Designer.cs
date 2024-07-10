namespace ChatApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_LocalPort = new System.Windows.Forms.TextBox();
            this.tb_RemotePort = new System.Windows.Forms.TextBox();
            this.tb_RemoteIP = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_OK_Reset = new System.Windows.Forms.Button();
            this.tb_Chat = new System.Windows.Forms.TextBox();
            this.tb_Message = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remote Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Remote IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name:";
            // 
            // tb_LocalPort
            // 
            this.tb_LocalPort.Location = new System.Drawing.Point(85, 21);
            this.tb_LocalPort.Name = "tb_LocalPort";
            this.tb_LocalPort.Size = new System.Drawing.Size(56, 20);
            this.tb_LocalPort.TabIndex = 4;
            this.tb_LocalPort.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tb_RemotePort
            // 
            this.tb_RemotePort.Location = new System.Drawing.Point(239, 21);
            this.tb_RemotePort.Name = "tb_RemotePort";
            this.tb_RemotePort.Size = new System.Drawing.Size(60, 20);
            this.tb_RemotePort.TabIndex = 5;
            this.tb_RemotePort.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tb_RemoteIP
            // 
            this.tb_RemoteIP.Location = new System.Drawing.Point(380, 21);
            this.tb_RemoteIP.Name = "tb_RemoteIP";
            this.tb_RemoteIP.Size = new System.Drawing.Size(100, 20);
            this.tb_RemoteIP.TabIndex = 6;
            this.tb_RemoteIP.Text = "127.0.0.1";
            this.tb_RemoteIP.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(548, 21);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_Name.TabIndex = 7;
            this.tb_Name.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // btn_OK_Reset
            // 
            this.btn_OK_Reset.Enabled = false;
            this.btn_OK_Reset.Location = new System.Drawing.Point(690, 19);
            this.btn_OK_Reset.Name = "btn_OK_Reset";
            this.btn_OK_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_OK_Reset.TabIndex = 8;
            this.btn_OK_Reset.Text = "Ok";
            this.btn_OK_Reset.UseVisualStyleBackColor = true;
            this.btn_OK_Reset.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // tb_Chat
            // 
            this.tb_Chat.Location = new System.Drawing.Point(24, 79);
            this.tb_Chat.Multiline = true;
            this.tb_Chat.Name = "tb_Chat";
            this.tb_Chat.ReadOnly = true;
            this.tb_Chat.Size = new System.Drawing.Size(373, 317);
            this.tb_Chat.TabIndex = 9;
            // 
            // tb_Message
            // 
            this.tb_Message.Location = new System.Drawing.Point(430, 109);
            this.tb_Message.Name = "tb_Message";
            this.tb_Message.ReadOnly = true;
            this.tb_Message.Size = new System.Drawing.Size(335, 20);
            this.tb_Message.TabIndex = 10;
            this.tb_Message.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Message:";
            // 
            // btn_Send
            // 
            this.btn_Send.Enabled = false;
            this.btn_Send.Location = new System.Drawing.Point(430, 153);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 12;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Message);
            this.Controls.Add(this.tb_Chat);
            this.Controls.Add(this.btn_OK_Reset);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_RemoteIP);
            this.Controls.Add(this.tb_RemotePort);
            this.Controls.Add(this.tb_LocalPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_LocalPort;
        private System.Windows.Forms.TextBox tb_RemotePort;
        private System.Windows.Forms.TextBox tb_RemoteIP;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_OK_Reset;
        private System.Windows.Forms.TextBox tb_Chat;
        private System.Windows.Forms.TextBox tb_Message;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Send;
    }
}

