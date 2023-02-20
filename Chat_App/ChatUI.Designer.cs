namespace Chat_App
{
    partial class ChatUI
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
            this.txtbox_message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.lstbox_received_message = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtbox_message
            // 
            this.txtbox_message.Location = new System.Drawing.Point(94, 51);
            this.txtbox_message.Name = "txtbox_message";
            this.txtbox_message.Size = new System.Drawing.Size(334, 26);
            this.txtbox_message.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(510, 41);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 47);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // lstbox_received_message
            // 
            this.lstbox_received_message.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstbox_received_message.FormattingEnabled = true;
            this.lstbox_received_message.ItemHeight = 20;
            this.lstbox_received_message.Location = new System.Drawing.Point(0, 126);
            this.lstbox_received_message.Name = "lstbox_received_message";
            this.lstbox_received_message.Size = new System.Drawing.Size(708, 324);
            this.lstbox_received_message.TabIndex = 3;
            // 
            // ChatUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.lstbox_received_message);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_message);
            this.Name = "ChatUI";
            this.Text = "ChatUI";
            this.Load += new System.EventHandler(this.ChatUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.ListBox lstbox_received_message;
    }
}