namespace RiveScriptSample
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
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnStreamCode = new System.Windows.Forms.Button();
            this.txtChatArea = new System.Windows.Forms.TextBox();
            this.txtUserMessage = new System.Windows.Forms.TextBox();
            this.btnGetReply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(22, 12);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(307, 369);
            this.txtCode.TabIndex = 0;
            // 
            // btnStreamCode
            // 
            this.btnStreamCode.Location = new System.Drawing.Point(43, 388);
            this.btnStreamCode.Name = "btnStreamCode";
            this.btnStreamCode.Size = new System.Drawing.Size(75, 23);
            this.btnStreamCode.TabIndex = 1;
            this.btnStreamCode.Text = "Stream";
            this.btnStreamCode.UseVisualStyleBackColor = true;
            this.btnStreamCode.Click += new System.EventHandler(this.btnStreamCode_Click);
            // 
            // txtChatArea
            // 
            this.txtChatArea.Location = new System.Drawing.Point(359, 12);
            this.txtChatArea.Multiline = true;
            this.txtChatArea.Name = "txtChatArea";
            this.txtChatArea.ReadOnly = true;
            this.txtChatArea.Size = new System.Drawing.Size(429, 343);
            this.txtChatArea.TabIndex = 2;
            // 
            // txtUserMessage
            // 
            this.txtUserMessage.Location = new System.Drawing.Point(359, 361);
            this.txtUserMessage.Name = "txtUserMessage";
            this.txtUserMessage.Size = new System.Drawing.Size(429, 20);
            this.txtUserMessage.TabIndex = 3;
            // 
            // btnGetReply
            // 
            this.btnGetReply.Location = new System.Drawing.Point(359, 388);
            this.btnGetReply.Name = "btnGetReply";
            this.btnGetReply.Size = new System.Drawing.Size(75, 23);
            this.btnGetReply.TabIndex = 4;
            this.btnGetReply.Text = "Send";
            this.btnGetReply.UseVisualStyleBackColor = true;
            this.btnGetReply.Click += new System.EventHandler(this.btnGetReply_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetReply);
            this.Controls.Add(this.txtUserMessage);
            this.Controls.Add(this.txtChatArea);
            this.Controls.Add(this.btnStreamCode);
            this.Controls.Add(this.txtCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnStreamCode;
        private System.Windows.Forms.TextBox txtChatArea;
        private System.Windows.Forms.TextBox txtUserMessage;
        private System.Windows.Forms.Button btnGetReply;
    }
}

