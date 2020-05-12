namespace UdpClient
{
    partial class FrmUdpClient
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSend = new System.Windows.Forms.Button();
            this.TxtBxMessage = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSend
            // 
            this.BtnSend.Enabled = false;
            this.BtnSend.Location = new System.Drawing.Point(118, 57);
            this.BtnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(94, 31);
            this.BtnSend.TabIndex = 1;
            this.BtnSend.Text = "發送";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtBxMessage
            // 
            this.TxtBxMessage.Location = new System.Drawing.Point(15, 16);
            this.TxtBxMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBxMessage.Name = "TxtBxMessage";
            this.TxtBxMessage.Size = new System.Drawing.Size(400, 31);
            this.TxtBxMessage.TabIndex = 0;
            this.TxtBxMessage.TextChanged += new System.EventHandler(this.TxtBxMessage_TextChanged);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(322, 57);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(94, 31);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "關閉";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(220, 57);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(94, 31);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "清除";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // FrmUdpClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 105);
            this.ControlBox = false;
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TxtBxMessage);
            this.Controls.Add(this.BtnSend);
            this.Font = new System.Drawing.Font("新細明體", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmUdpClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UDP Client";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUdpClient_FormClosed);
            this.Load += new System.EventHandler(this.FrmUdpClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox TxtBxMessage;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnClear;
    }
}

