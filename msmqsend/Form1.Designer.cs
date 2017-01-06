namespace msmqsend
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
            this.SEND = new System.Windows.Forms.Button();
            this.MESSAGE = new System.Windows.Forms.TextBox();
            this.ADDRESS = new System.Windows.Forms.ComboBox();
            this.FILEDIR = new System.Windows.Forms.TextBox();
            this.IS_SHIWU = new System.Windows.Forms.CheckBox();
            this.SELECTFILE = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SEND
            // 
            this.SEND.Location = new System.Drawing.Point(151, 280);
            this.SEND.Name = "SEND";
            this.SEND.Size = new System.Drawing.Size(141, 36);
            this.SEND.TabIndex = 0;
            this.SEND.Text = "发送";
            this.SEND.UseVisualStyleBackColor = true;
            this.SEND.Click += new System.EventHandler(this.SEND_Click);
            // 
            // MESSAGE
            // 
            this.MESSAGE.Location = new System.Drawing.Point(6, 20);
            this.MESSAGE.Multiline = true;
            this.MESSAGE.Name = "MESSAGE";
            this.MESSAGE.Size = new System.Drawing.Size(417, 74);
            this.MESSAGE.TabIndex = 1;
            // 
            // ADDRESS
            // 
            this.ADDRESS.FormattingEnabled = true;
            this.ADDRESS.Items.AddRange(new object[] {
            "FORMATNAME:DIRECT=TCP:192.168.104.175\\PRIVATE$\\ciq_receive",
            ".\\Private$\\tielu"});
            this.ADDRESS.Location = new System.Drawing.Point(6, 20);
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.Size = new System.Drawing.Size(417, 20);
            this.ADDRESS.TabIndex = 2;
            // 
            // FILEDIR
            // 
            this.FILEDIR.Location = new System.Drawing.Point(6, 27);
            this.FILEDIR.Name = "FILEDIR";
            this.FILEDIR.Size = new System.Drawing.Size(346, 21);
            this.FILEDIR.TabIndex = 3;
            // 
            // IS_SHIWU
            // 
            this.IS_SHIWU.AutoSize = true;
            this.IS_SHIWU.Location = new System.Drawing.Point(188, 239);
            this.IS_SHIWU.Name = "IS_SHIWU";
            this.IS_SHIWU.Size = new System.Drawing.Size(60, 16);
            this.IS_SHIWU.TabIndex = 4;
            this.IS_SHIWU.Text = "事务性";
            this.IS_SHIWU.UseVisualStyleBackColor = true;
            // 
            // SELECTFILE
            // 
            this.SELECTFILE.Location = new System.Drawing.Point(379, 15);
            this.SELECTFILE.Name = "SELECTFILE";
            this.SELECTFILE.Size = new System.Drawing.Size(44, 43);
            this.SELECTFILE.TabIndex = 5;
            this.SELECTFILE.Text = "选择文件";
            this.SELECTFILE.UseVisualStyleBackColor = true;
            this.SELECTFILE.Click += new System.EventHandler(this.SELECTFILE_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MESSAGE);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送文本";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ADDRESS);
            this.groupBox2.Location = new System.Drawing.Point(12, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 48);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "消息队列地址";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FILEDIR);
            this.groupBox3.Controls.Add(this.SELECTFILE);
            this.groupBox3.Location = new System.Drawing.Point(12, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 63);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送文件";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 356);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.IS_SHIWU);
            this.Controls.Add(this.SEND);
            this.Name = "Form1";
            this.Text = "SendMSMQ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SEND;
        private System.Windows.Forms.TextBox MESSAGE;
        private System.Windows.Forms.ComboBox ADDRESS;
        private System.Windows.Forms.TextBox FILEDIR;
        private System.Windows.Forms.CheckBox IS_SHIWU;
        private System.Windows.Forms.Button SELECTFILE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

