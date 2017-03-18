namespace IRC_Client.Views
{
    partial class ChatView
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
            this.MessageInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SendButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ChatTabsControl = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // MessageInput
            // 
            this.MessageInput.AccessibleName = "";
            this.MessageInput.Depth = 0;
            this.MessageInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageInput.Hint = "Write your message here";
            this.MessageInput.Location = new System.Drawing.Point(44, 378);
            this.MessageInput.MaxLength = 32767;
            this.MessageInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.MessageInput.Name = "MessageInput";
            this.MessageInput.PasswordChar = '\0';
            this.MessageInput.SelectedText = "";
            this.MessageInput.SelectionLength = 0;
            this.MessageInput.SelectionStart = 0;
            this.MessageInput.Size = new System.Drawing.Size(337, 23);
            this.MessageInput.TabIndex = 16;
            this.MessageInput.TabStop = false;
            this.MessageInput.UseSystemPasswordChar = false;
            // 
            // SendButton
            // 
            this.SendButton.AutoSize = true;
            this.SendButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SendButton.Depth = 0;
            this.SendButton.Icon = null;
            this.SendButton.Location = new System.Drawing.Point(396, 371);
            this.SendButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SendButton.Name = "SendButton";
            this.SendButton.Primary = true;
            this.SendButton.Size = new System.Drawing.Size(56, 36);
            this.SendButton.TabIndex = 23;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ChatTabsControl
            // 
            this.ChatTabsControl.HotTrack = true;
            this.ChatTabsControl.Location = new System.Drawing.Point(34, 79);
            this.ChatTabsControl.Name = "ChatTabsControl";
            this.ChatTabsControl.SelectedIndex = 0;
            this.ChatTabsControl.Size = new System.Drawing.Size(427, 286);
            this.ChatTabsControl.TabIndex = 25;
            // 
            // ChatView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 434);
            this.Controls.Add(this.ChatTabsControl);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MessageInput);
            this.Name = "ChatView";
            this.Text = "Active Chats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField MessageInput;
        private MaterialSkin.Controls.MaterialRaisedButton SendButton;
        private System.Windows.Forms.TabControl ChatTabsControl;
    }
}