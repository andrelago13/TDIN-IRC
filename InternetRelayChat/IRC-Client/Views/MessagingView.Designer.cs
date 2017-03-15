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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.InviteButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.LoggedUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MessagingViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LoggedUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessagingViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UserList
            // 
            this.UserList.DataSource = this.LoggedUsersBindingSource;
            this.UserList.FormattingEnabled = true;
            this.UserList.Location = new System.Drawing.Point(13, 30);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(214, 212);
            this.UserList.TabIndex = 0;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MessagingViewBindingSource, "Nickname", true));
            this.WelcomeLabel.Location = new System.Drawing.Point(22, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(35, 13);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "label1";
            // 
            // InviteButton
            // 
            this.InviteButton.Location = new System.Drawing.Point(247, 30);
            this.InviteButton.Name = "InviteButton";
            this.InviteButton.Size = new System.Drawing.Size(130, 23);
            this.InviteButton.TabIndex = 2;
            this.InviteButton.Text = "Invite to Chat";
            this.InviteButton.UseVisualStyleBackColor = true;
            this.InviteButton.MouseCaptureChanged += new System.EventHandler(this.InviteButtonClick);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(247, 59);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(130, 23);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh List";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.MouseCaptureChanged += new System.EventHandler(this.RefreshButtonClick);
            // 
            // LoggedUsersBindingSource
            // 
            this.LoggedUsersBindingSource.DataMember = "LoggedUsers";
            this.LoggedUsersBindingSource.DataSource = this.MessagingViewBindingSource;
            // 
            // MessagingViewBindingSource
            // 
            this.MessagingViewBindingSource.DataSource = typeof(IRC_Client.ViewModels.MessagingViewModel);
            // 
            // MessagingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 261);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.InviteButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.UserList);
            this.Name = "MessagingView";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MessagingViewClosing);
            this.Load += new System.EventHandler(this.MessagingViewLoad);
            ((System.ComponentModel.ISupportInitialize)(this.LoggedUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessagingViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UserList;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button InviteButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.BindingSource MessagingViewBindingSource;
        private System.Windows.Forms.BindingSource LoggedUsersBindingSource;
    }
}