namespace SocketServer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            //this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.btn_SendFile = new System.Windows.Forms.Button();
            this.btn_CloseListen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // skinEngine1
            // 
            //this.skinEngine1.@__DrawButtonFocusRectangle = true;
            //this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            //this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            //this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            //this.skinEngine1.SerialNumber = "";
            //this.skinEngine1.SkinFile = null;
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(87, 36);
            this.txt_IP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(219, 25);
            this.txt_IP.TabIndex = 0;
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(384, 36);
            this.txt_Port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(143, 25);
            this.txt_Port.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "端口：";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(536, 34);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(100, 29);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "开始监听";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(87, 189);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(440, 100);
            this.txtLog.TabIndex = 6;
            // 
            // txt_Message
            // 
            this.txt_Message.Location = new System.Drawing.Point(87, 332);
            this.txt_Message.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Message.Size = new System.Drawing.Size(440, 124);
            this.txt_Message.TabIndex = 7;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(536, 429);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(100, 29);
            this.btn_Send.TabIndex = 8;
            this.btn_Send.Text = "发送消息";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(87, 122);
            this.txt_Path.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(440, 25);
            this.txt_Path.TabIndex = 9;
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(536, 120);
            this.btn_OpenFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(100, 29);
            this.btn_OpenFile.TabIndex = 10;
            this.btn_OpenFile.Text = "选择文件";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // btn_SendFile
            // 
            this.btn_SendFile.Location = new System.Drawing.Point(656, 120);
            this.btn_SendFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SendFile.Name = "btn_SendFile";
            this.btn_SendFile.Size = new System.Drawing.Size(100, 29);
            this.btn_SendFile.TabIndex = 11;
            this.btn_SendFile.Text = "发送文件";
            this.btn_SendFile.UseVisualStyleBackColor = true;
            this.btn_SendFile.Click += new System.EventHandler(this.btn_SendFile_Click);
            // 
            // btn_CloseListen
            // 
            this.btn_CloseListen.Location = new System.Drawing.Point(656, 34);
            this.btn_CloseListen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CloseListen.Name = "btn_CloseListen";
            this.btn_CloseListen.Size = new System.Drawing.Size(100, 29);
            this.btn_CloseListen.TabIndex = 13;
            this.btn_CloseListen.Text = "关闭监听";
            this.btn_CloseListen.UseVisualStyleBackColor = true;
            this.btn_CloseListen.Click += new System.EventHandler(this.btn_CloseListen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 502);
            this.Controls.Add(this.btn_CloseListen);
            this.Controls.Add(this.btn_SendFile);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_IP);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "服务器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Button btn_SendFile;
        private System.Windows.Forms.Button btn_CloseListen;
    }
}

