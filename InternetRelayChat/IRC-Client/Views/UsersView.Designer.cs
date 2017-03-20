namespace IRC_Client.Views
{
    partial class UsersView
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
            this.InviteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.WelcomeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.UserList = new MaterialSkin.Controls.MaterialListView();
            this.OnlineHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MessagingViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MessagingViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InviteButton
            // 
            this.InviteButton.AutoSize = true;
            this.InviteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InviteButton.Depth = 0;
            this.InviteButton.Icon = null;
            this.InviteButton.Location = new System.Drawing.Point(74, 602);
            this.InviteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.InviteButton.Name = "InviteButton";
            this.InviteButton.Primary = true;
            this.InviteButton.Size = new System.Drawing.Size(124, 36);
            this.InviteButton.TabIndex = 4;
            this.InviteButton.Text = "Invite to Chat";
            this.InviteButton.UseVisualStyleBackColor = true;
            this.InviteButton.MouseCaptureChanged += new System.EventHandler(this.InviteButtonClick);
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
            // UserList
            // 
            this.UserList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.UserList.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.UserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OnlineHeader});
            this.UserList.Depth = 0;
            this.UserList.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.UserList.FullRowSelect = true;
            this.UserList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.UserList.LabelWrap = false;
            this.UserList.Location = new System.Drawing.Point(6, 111);
            this.UserList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.UserList.MouseState = MaterialSkin.MouseState.OUT;
            this.UserList.Name = "UserList";
            this.UserList.OwnerDraw = true;
            this.UserList.Size = new System.Drawing.Size(261, 485);
            this.UserList.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.UserList.TabIndex = 9;
            this.UserList.UseCompatibleStateImageBehavior = false;
            this.UserList.View = System.Windows.Forms.View.Details;
            // 
            // OnlineHeader
            // 
            this.OnlineHeader.Text = "Online Users";
            this.OnlineHeader.Width = 251;
            // 
            // MessagingViewBindingSource
            // 
            this.MessagingViewBindingSource.DataSource = typeof(IRC_Client.ViewModels.UsersViewModel);
            // 
            // UsersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 656);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.InviteButton);
            this.Name = "UsersView";
            this.Text = "Relay Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MessagingViewClosing);
            this.Load += new System.EventHandler(this.MessagingViewLoad);
            ((System.ComponentModel.ISupportInitialize)(this.MessagingViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource MessagingViewBindingSource;
        private MaterialSkin.Controls.MaterialRaisedButton InviteButton;
        private MaterialSkin.Controls.MaterialLabel WelcomeLabel;
        private MaterialSkin.Controls.MaterialListView UserList;
        private System.Windows.Forms.ColumnHeader OnlineHeader;
    }
}