namespace IRC_Client.Views
{
    partial class LoginView
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
            this.NicknameInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NicknameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PasswordInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ServerAddressLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ServerAddressInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ServerPortLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ServerPortInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.StatusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.LoginButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RegisterButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LoginViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LoginViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NicknameInput
            // 
            this.NicknameInput.AccessibleName = "";
            this.NicknameInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NicknameInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LoginViewBindingSource, "Nickname", true));
            this.NicknameInput.Depth = 0;
            this.NicknameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NicknameInput.Hint = "Your nickname";
            this.NicknameInput.Location = new System.Drawing.Point(232, 151);
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
            // NicknameLabel
            // 
            this.NicknameLabel.AutoSize = true;
            this.NicknameLabel.Depth = 0;
            this.NicknameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.NicknameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NicknameLabel.Location = new System.Drawing.Point(103, 151);
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
            this.PasswordLabel.Location = new System.Drawing.Point(103, 191);
            this.PasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(75, 19);
            this.PasswordLabel.TabIndex = 14;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordInput
            // 
            this.PasswordInput.AccessibleName = "";
            this.PasswordInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LoginViewBindingSource, "Password", true));
            this.PasswordInput.Depth = 0;
            this.PasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordInput.Hint = "Your password";
            this.PasswordInput.Location = new System.Drawing.Point(232, 191);
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
            // ServerAddressLabel
            // 
            this.ServerAddressLabel.AutoSize = true;
            this.ServerAddressLabel.Depth = 0;
            this.ServerAddressLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ServerAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ServerAddressLabel.Location = new System.Drawing.Point(68, 229);
            this.ServerAddressLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ServerAddressLabel.Name = "ServerAddressLabel";
            this.ServerAddressLabel.Size = new System.Drawing.Size(110, 19);
            this.ServerAddressLabel.TabIndex = 16;
            this.ServerAddressLabel.Text = "Server Address";
            this.ServerAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerAddressInput
            // 
            this.ServerAddressInput.AccessibleName = "";
            this.ServerAddressInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerAddressInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LoginViewBindingSource, "ServerAddress", true));
            this.ServerAddressInput.Depth = 0;
            this.ServerAddressInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerAddressInput.Hint = "Server address to connect";
            this.ServerAddressInput.Location = new System.Drawing.Point(232, 229);
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
            // ServerPortLabel
            // 
            this.ServerPortLabel.AutoSize = true;
            this.ServerPortLabel.Depth = 0;
            this.ServerPortLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ServerPortLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ServerPortLabel.Location = new System.Drawing.Point(97, 271);
            this.ServerPortLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ServerPortLabel.Name = "ServerPortLabel";
            this.ServerPortLabel.Size = new System.Drawing.Size(83, 19);
            this.ServerPortLabel.TabIndex = 18;
            this.ServerPortLabel.Text = "Server Port";
            this.ServerPortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerPortInput
            // 
            this.ServerPortInput.AccessibleName = "";
            this.ServerPortInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerPortInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LoginViewBindingSource, "ServerPort", true));
            this.ServerPortInput.Depth = 0;
            this.ServerPortInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerPortInput.Hint = "Server port to conect";
            this.ServerPortInput.Location = new System.Drawing.Point(232, 267);
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
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Depth = 0;
            this.StatusLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StatusLabel.Location = new System.Drawing.Point(228, 328);
            this.StatusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(93, 19);
            this.StatusLabel.TabIndex = 21;
            this.StatusLabel.Text = "Invalid Login";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StatusLabel.Visible = false;
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginButton.Depth = 0;
            this.LoginButton.Location = new System.Drawing.Point(137, 390);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Primary = true;
            this.LoginButton.Size = new System.Drawing.Size(132, 46);
            this.LoginButton.TabIndex = 22;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButtonClick);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterButton.Depth = 0;
            this.RegisterButton.Location = new System.Drawing.Point(339, 390);
            this.RegisterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Primary = true;
            this.RegisterButton.Size = new System.Drawing.Size(132, 46);
            this.RegisterButton.TabIndex = 23;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.MouseCaptureChanged += new System.EventHandler(this.RegisterButtonClick);
            // 
            // LoginViewBindingSource
            // 
            this.LoginViewBindingSource.DataSource = typeof(IRC_Client.ViewModels.LoginViewModel);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 529);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ServerPortLabel);
            this.Controls.Add(this.ServerPortInput);
            this.Controls.Add(this.ServerAddressLabel);
            this.Controls.Add(this.ServerAddressInput);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.NicknameLabel);
            this.Controls.Add(this.NicknameInput);
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relay Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginFormClosing);
            this.MouseCaptureChanged += new System.EventHandler(this.LoginButtonClick);
            ((System.ComponentModel.ISupportInitialize)(this.LoginViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource LoginViewBindingSource;
        private MaterialSkin.Controls.MaterialSingleLineTextField NicknameInput;
        private MaterialSkin.Controls.MaterialLabel NicknameLabel;
        private MaterialSkin.Controls.MaterialLabel PasswordLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField PasswordInput;
        private MaterialSkin.Controls.MaterialLabel ServerAddressLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField ServerAddressInput;
        private MaterialSkin.Controls.MaterialLabel ServerPortLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField ServerPortInput;
        private MaterialSkin.Controls.MaterialLabel StatusLabel;
        private MaterialSkin.Controls.MaterialRaisedButton LoginButton;
        private MaterialSkin.Controls.MaterialRaisedButton RegisterButton;
    }
}