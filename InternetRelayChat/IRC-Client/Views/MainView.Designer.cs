namespace IRC_Client.Views
{
    partial class MainView
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
            this.TabMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.LoginTab = new System.Windows.Forms.TabPage();
            this.LoginButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ServerAddressInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LoginViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ServerPortInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ServerPortLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ServerAddressLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RegisterTab = new System.Windows.Forms.TabPage();
            this.RealNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RegisterButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RealNameInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NicknameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.NicknameInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PasswordInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.TabMenuSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.TabMenu.SuspendLayout();
            this.LoginTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginViewBindingSource)).BeginInit();
            this.RegisterTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.LoginTab);
            this.TabMenu.Controls.Add(this.RegisterTab);
            this.TabMenu.Depth = 0;
            this.TabMenu.Location = new System.Drawing.Point(9, 210);
            this.TabMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.Size = new System.Drawing.Size(584, 292);
            this.TabMenu.TabIndex = 25;
            // 
            // LoginTab
            // 
            this.LoginTab.BackColor = System.Drawing.Color.White;
            this.LoginTab.Controls.Add(this.LoginButton);
            this.LoginTab.Controls.Add(this.ServerAddressInput);
            this.LoginTab.Controls.Add(this.ServerPortInput);
            this.LoginTab.Controls.Add(this.ServerPortLabel);
            this.LoginTab.Controls.Add(this.ServerAddressLabel);
            this.LoginTab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginTab.Location = new System.Drawing.Point(4, 22);
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Padding = new System.Windows.Forms.Padding(3);
            this.LoginTab.Size = new System.Drawing.Size(576, 266);
            this.LoginTab.TabIndex = 0;
            this.LoginTab.Text = "Login";
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginButton.Depth = 0;
            this.LoginButton.Location = new System.Drawing.Point(232, 152);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Primary = true;
            this.LoginButton.Size = new System.Drawing.Size(132, 46);
            this.LoginButton.TabIndex = 22;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButtonClick);
            // 
            // ServerAddressInput
            // 
            this.ServerAddressInput.AccessibleName = "";
            this.ServerAddressInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LoginViewBindingSource, "ServerAddress", true));
            this.ServerAddressInput.Depth = 0;
            this.ServerAddressInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerAddressInput.Hint = "Server address to connect";
            this.ServerAddressInput.Location = new System.Drawing.Point(217, 20);
            this.ServerAddressInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.ServerAddressInput.Name = "ServerAddressInput";
            this.ServerAddressInput.PasswordChar = '\0';
            this.ServerAddressInput.SelectedText = "";
            this.ServerAddressInput.SelectionLength = 0;
            this.ServerAddressInput.SelectionStart = 0;
            this.ServerAddressInput.Size = new System.Drawing.Size(305, 23);
            this.ServerAddressInput.TabIndex = 15;
            this.ServerAddressInput.UseSystemPasswordChar = false;
            // 
            // LoginViewBindingSource
            // 
            this.LoginViewBindingSource.DataSource = typeof(IRC_Client.ViewModels.MainViewModel);
            // 
            // ServerPortInput
            // 
            this.ServerPortInput.AccessibleName = "";
            this.ServerPortInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LoginViewBindingSource, "ServerPort", true));
            this.ServerPortInput.Depth = 0;
            this.ServerPortInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerPortInput.Hint = "Server port to conect";
            this.ServerPortInput.Location = new System.Drawing.Point(217, 65);
            this.ServerPortInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.ServerPortInput.Name = "ServerPortInput";
            this.ServerPortInput.PasswordChar = '\0';
            this.ServerPortInput.SelectedText = "";
            this.ServerPortInput.SelectionLength = 0;
            this.ServerPortInput.SelectionStart = 0;
            this.ServerPortInput.Size = new System.Drawing.Size(305, 23);
            this.ServerPortInput.TabIndex = 17;
            this.ServerPortInput.UseSystemPasswordChar = false;
            // 
            // ServerPortLabel
            // 
            this.ServerPortLabel.AutoSize = true;
            this.ServerPortLabel.Depth = 0;
            this.ServerPortLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ServerPortLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ServerPortLabel.Location = new System.Drawing.Point(80, 65);
            this.ServerPortLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ServerPortLabel.Name = "ServerPortLabel";
            this.ServerPortLabel.Size = new System.Drawing.Size(83, 19);
            this.ServerPortLabel.TabIndex = 18;
            this.ServerPortLabel.Text = "Server Port";
            this.ServerPortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerAddressLabel
            // 
            this.ServerAddressLabel.AutoSize = true;
            this.ServerAddressLabel.Depth = 0;
            this.ServerAddressLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ServerAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ServerAddressLabel.Location = new System.Drawing.Point(53, 20);
            this.ServerAddressLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ServerAddressLabel.Name = "ServerAddressLabel";
            this.ServerAddressLabel.Size = new System.Drawing.Size(110, 19);
            this.ServerAddressLabel.TabIndex = 16;
            this.ServerAddressLabel.Text = "Server Address";
            this.ServerAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterTab
            // 
            this.RegisterTab.BackColor = System.Drawing.Color.White;
            this.RegisterTab.Controls.Add(this.RealNameLabel);
            this.RegisterTab.Controls.Add(this.RegisterButton);
            this.RegisterTab.Controls.Add(this.RealNameInput);
            this.RegisterTab.Location = new System.Drawing.Point(4, 22);
            this.RegisterTab.Name = "RegisterTab";
            this.RegisterTab.Padding = new System.Windows.Forms.Padding(3);
            this.RegisterTab.Size = new System.Drawing.Size(576, 266);
            this.RegisterTab.TabIndex = 1;
            this.RegisterTab.Text = "Register";
            // 
            // RealNameLabel
            // 
            this.RealNameLabel.AutoSize = true;
            this.RealNameLabel.Depth = 0;
            this.RealNameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.RealNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RealNameLabel.Location = new System.Drawing.Point(80, 20);
            this.RealNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RealNameLabel.Name = "RealNameLabel";
            this.RealNameLabel.Size = new System.Drawing.Size(82, 19);
            this.RealNameLabel.TabIndex = 28;
            this.RealNameLabel.Text = "Real Name";
            this.RealNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterButton
            // 
            this.RegisterButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegisterButton.Depth = 0;
            this.RegisterButton.Location = new System.Drawing.Point(232, 152);
            this.RegisterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Primary = true;
            this.RegisterButton.Size = new System.Drawing.Size(132, 46);
            this.RegisterButton.TabIndex = 25;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.MouseCaptureChanged += new System.EventHandler(this.RegisterButtonClick);
            // 
            // RealNameInput
            // 
            this.RealNameInput.AccessibleName = "";
            this.RealNameInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LoginViewBindingSource, "Nickname", true));
            this.RealNameInput.Depth = 0;
            this.RealNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealNameInput.Hint = "Your real name";
            this.RealNameInput.Location = new System.Drawing.Point(217, 20);
            this.RealNameInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.RealNameInput.Name = "RealNameInput";
            this.RealNameInput.PasswordChar = '\0';
            this.RealNameInput.SelectedText = "";
            this.RealNameInput.SelectionLength = 0;
            this.RealNameInput.SelectionStart = 0;
            this.RealNameInput.Size = new System.Drawing.Size(305, 23);
            this.RealNameInput.TabIndex = 27;
            this.RealNameInput.UseSystemPasswordChar = false;
            // 
            // NicknameLabel
            // 
            this.NicknameLabel.AutoSize = true;
            this.NicknameLabel.Depth = 0;
            this.NicknameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.NicknameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NicknameLabel.Location = new System.Drawing.Point(94, 139);
            this.NicknameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.NicknameLabel.Name = "NicknameLabel";
            this.NicknameLabel.Size = new System.Drawing.Size(77, 19);
            this.NicknameLabel.TabIndex = 12;
            this.NicknameLabel.Text = "Nickname";
            this.NicknameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Depth = 0;
            this.PasswordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordLabel.Location = new System.Drawing.Point(96, 185);
            this.PasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(75, 19);
            this.PasswordLabel.TabIndex = 14;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NicknameInput
            // 
            this.NicknameInput.AccessibleName = "";
            this.NicknameInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LoginViewBindingSource, "Nickname", true));
            this.NicknameInput.Depth = 0;
            this.NicknameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NicknameInput.Hint = "Your nickname";
            this.NicknameInput.Location = new System.Drawing.Point(226, 139);
            this.NicknameInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.NicknameInput.Name = "NicknameInput";
            this.NicknameInput.PasswordChar = '\0';
            this.NicknameInput.SelectedText = "";
            this.NicknameInput.SelectionLength = 0;
            this.NicknameInput.SelectionStart = 0;
            this.NicknameInput.Size = new System.Drawing.Size(305, 23);
            this.NicknameInput.TabIndex = 11;
            this.NicknameInput.UseSystemPasswordChar = false;
            // 
            // PasswordInput
            // 
            this.PasswordInput.AccessibleName = "";
            this.PasswordInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LoginViewBindingSource, "Password", true));
            this.PasswordInput.Depth = 0;
            this.PasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordInput.Hint = "Your password";
            this.PasswordInput.Location = new System.Drawing.Point(226, 185);
            this.PasswordInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '\0';
            this.PasswordInput.SelectedText = "";
            this.PasswordInput.SelectionLength = 0;
            this.PasswordInput.SelectionStart = 0;
            this.PasswordInput.Size = new System.Drawing.Size(305, 23);
            this.PasswordInput.TabIndex = 13;
            this.PasswordInput.UseSystemPasswordChar = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LoginViewBindingSource, "Status", true));
            this.StatusLabel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.StatusLabel.Location = new System.Drawing.Point(5, 505);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(88, 19);
            this.StatusLabel.TabIndex = 24;
            this.StatusLabel.Text = "StatusLabel";
            // 
            // TabMenuSelector
            // 
            this.TabMenuSelector.BaseTabControl = this.TabMenu;
            this.TabMenuSelector.Depth = 0;
            this.TabMenuSelector.Location = new System.Drawing.Point(-13, 64);
            this.TabMenuSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabMenuSelector.Name = "TabMenuSelector";
            this.TabMenuSelector.Size = new System.Drawing.Size(625, 36);
            this.TabMenuSelector.TabIndex = 26;
            this.TabMenuSelector.Text = "TabMenuSelector";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 529);
            this.Controls.Add(this.NicknameLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.TabMenuSelector);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.TabMenu);
            this.Controls.Add(this.NicknameInput);
            this.Controls.Add(this.PasswordInput);
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relay Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginFormClosing);
            this.MouseCaptureChanged += new System.EventHandler(this.LoginButtonClick);
            this.TabMenu.ResumeLayout(false);
            this.LoginTab.ResumeLayout(false);
            this.LoginTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginViewBindingSource)).EndInit();
            this.RegisterTab.ResumeLayout(false);
            this.RegisterTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource LoginViewBindingSource;
        private MaterialSkin.Controls.MaterialTabControl TabMenu;
        private System.Windows.Forms.TabPage RegisterTab;
        private System.Windows.Forms.TabPage LoginTab;
        private System.Windows.Forms.Label StatusLabel;
        private MaterialSkin.Controls.MaterialLabel NicknameLabel;
        private MaterialSkin.Controls.MaterialRaisedButton LoginButton;
        private MaterialSkin.Controls.MaterialLabel PasswordLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField NicknameInput;
        private MaterialSkin.Controls.MaterialSingleLineTextField PasswordInput;
        private MaterialSkin.Controls.MaterialSingleLineTextField ServerAddressInput;
        private MaterialSkin.Controls.MaterialSingleLineTextField ServerPortInput;
        private MaterialSkin.Controls.MaterialLabel ServerPortLabel;
        private MaterialSkin.Controls.MaterialLabel ServerAddressLabel;
        private MaterialSkin.Controls.MaterialTabSelector TabMenuSelector;
        private MaterialSkin.Controls.MaterialRaisedButton RegisterButton;
        private MaterialSkin.Controls.MaterialLabel RealNameLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField RealNameInput;
    }
}