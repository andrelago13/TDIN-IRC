namespace IRC_Client.Views
{
    partial class MessagingView
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
            this.components = new System.ComponentModel.Container();
            this.UserList = new System.Windows.Forms.ListBox();
            this.InviteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RefreshButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.WelcomeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ChatBox = new System.Windows.Forms.Panel();
            this.ChatUserLabel = new MaterialSkin.Controls.MaterialLabel();
            this.MessagingViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MessagingViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UserList
            // 
            this.UserList.FormattingEnabled = true;
            this.UserList.Location = new System.Drawing.Point(6, 111);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(274, 485);
            this.UserList.TabIndex = 0;
            // 
            // InviteButton
            // 
            this.InviteButton.Depth = 0;
            this.InviteButton.Location = new System.Drawing.Point(6, 602);
            this.InviteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.InviteButton.Name = "InviteButton";
            this.InviteButton.Primary = true;
            this.InviteButton.Size = new System.Drawing.Size(134, 45);
            this.InviteButton.TabIndex = 4;
            this.InviteButton.Text = "Invite to Chat";
            this.InviteButton.UseVisualStyleBackColor = true;
            this.InviteButton.MouseCaptureChanged += new System.EventHandler(this.InviteButtonClick);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Depth = 0;
            this.RefreshButton.Location = new System.Drawing.Point(146, 602);
            this.RefreshButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Primary = true;
            this.RefreshButton.Size = new System.Drawing.Size(134, 45);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Refresh List";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.MouseCaptureChanged += new System.EventHandler(this.RefreshButtonClick);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MessagingViewBindingSource, "WelcomeText", true));
            this.WelcomeLabel.Depth = 0;
            this.WelcomeLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.WelcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WelcomeLabel.Location = new System.Drawing.Point(4, 78);
            this.WelcomeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(72, 19);
            this.WelcomeLabel.TabIndex = 6;
            this.WelcomeLabel.Text = "Welcome";
            // 
            // ChatBox
            // 
            this.ChatBox.Location = new System.Drawing.Point(295, 111);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(466, 533);
            this.ChatBox.TabIndex = 7;
            // 
            // ChatUserLabel
            // 
            this.ChatUserLabel.AutoSize = true;
            this.ChatUserLabel.Depth = 0;
            this.ChatUserLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ChatUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChatUserLabel.Location = new System.Drawing.Point(291, 78);
            this.ChatUserLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChatUserLabel.Name = "ChatUserLabel";
            this.ChatUserLabel.Size = new System.Drawing.Size(97, 19);
            this.ChatUserLabel.TabIndex = 8;
            this.ChatUserLabel.Text = "Chatting with";
            // 
            // MessagingViewBindingSource
            // 
            this.MessagingViewBindingSource.DataSource = typeof(IRC_Client.ViewModels.MessagingViewModel);
            // 
            // MessagingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 656);
            this.Controls.Add(this.ChatUserLabel);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.InviteButton);
            this.Controls.Add(this.UserList);
            this.Name = "MessagingView";
            this.Text = "Relay Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MessagingViewClosing);
            this.Load += new System.EventHandler(this.MessagingViewLoad);
            ((System.ComponentModel.ISupportInitialize)(this.MessagingViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UserList;
        private System.Windows.Forms.BindingSource MessagingViewBindingSource;
        private MaterialSkin.Controls.MaterialRaisedButton InviteButton;
        private MaterialSkin.Controls.MaterialRaisedButton RefreshButton;
        private MaterialSkin.Controls.MaterialLabel WelcomeLabel;
        private System.Windows.Forms.Panel ChatBox;
        private MaterialSkin.Controls.MaterialLabel ChatUserLabel;
    }
}