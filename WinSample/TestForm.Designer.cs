namespace WinSample
{
    partial class TestForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Location = new System.Drawing.Point(3, 16);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(323, 338);
            this.txtCode.TabIndex = 0;
            // 
            // btnStreamCode
            // 
            this.btnStreamCode.Location = new System.Drawing.Point(15, 375);
            this.btnStreamCode.Name = "btnStreamCode";
            this.btnStreamCode.Size = new System.Drawing.Size(75, 23);
            this.btnStreamCode.TabIndex = 1;
            this.btnStreamCode.Text = "Interpret";
            this.btnStreamCode.UseVisualStyleBackColor = true;
            this.btnStreamCode.Click += new System.EventHandler(this.btnStreamCode_Click);
            // 
            // txtChatArea
            // 
            this.txtChatArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChatArea.Location = new System.Drawing.Point(3, 16);
            this.txtChatArea.Multiline = true;
            this.txtChatArea.Name = "txtChatArea";
            this.txtChatArea.ReadOnly = true;
            this.txtChatArea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtChatArea.Size = new System.Drawing.Size(389, 338);
            this.txtChatArea.TabIndex = 2;
            // 
            // txtUserMessage
            // 
            this.txtUserMessage.Location = new System.Drawing.Point(378, 372);
            this.txtUserMessage.Name = "txtUserMessage";
            this.txtUserMessage.Size = new System.Drawing.Size(308, 20);
            this.txtUserMessage.TabIndex = 3;
            // 
            // btnGetReply
            // 
            this.btnGetReply.Location = new System.Drawing.Point(695, 372);
            this.btnGetReply.Name = "btnGetReply";
            this.btnGetReply.Size = new System.Drawing.Size(75, 20);
            this.btnGetReply.TabIndex = 4;
            this.btnGetReply.Text = "Send";
            this.btnGetReply.UseVisualStyleBackColor = true;
            this.btnGetReply.Click += new System.EventHandler(this.btnGetReply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 357);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RivScript Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtChatArea);
            this.groupBox2.Location = new System.Drawing.Point(378, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 357);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chat Area";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGetReply);
            this.Controls.Add(this.txtUserMessage);
            this.Controls.Add(this.btnStreamCode);
            this.Name = "Form1";
            this.Text = "Rivscript Interpreter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnStreamCode;
        private System.Windows.Forms.TextBox txtChatArea;
        private System.Windows.Forms.TextBox txtUserMessage;
        private System.Windows.Forms.Button btnGetReply;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

