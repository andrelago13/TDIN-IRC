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
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.NicknameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.NicknameInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ServerAddressInput = new System.Windows.Forms.TextBox();
            this.ServerPortInput = new System.Windows.Forms.TextBox();
            this.ServerAddressLabel = new System.Windows.Forms.Label();
            this.ServerPortLabel = new System.Windows.Forms.Label();
            this.LoginViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LoginViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(79, 221);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButtonClick);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(192, 221);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 1;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButtonClick);
            // 
            // NicknameLabel
            // 
            this.NicknameLabel.AutoSize = true;
            this.NicknameLabel.Location = new System.Drawing.Point(61, 37);
            this.NicknameLabel.Name = "NicknameLabel";
            this.NicknameLabel.Size = new System.Drawing.Size(61, 13);
            this.NicknameLabel.TabIndex = 2;
            this.NicknameLabel.Text = "Nickname :";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(61, 79);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(59, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password :";
            // 
            // NicknameInput
            // 
            this.NicknameInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LoginViewBindingSource, "Nickname", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NicknameInput.Location = new System.Drawing.Point(151, 34);
            this.NicknameInput.Name = "NicknameInput";
            this.NicknameInput.Size = new System.Drawing.Size(142, 20);
            this.NicknameInput.TabIndex = 4;
            // 
            // PasswordInput
            // 
            this.PasswordInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LoginViewBindingSource, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PasswordInput.Location = new System.Drawing.Point(151, 76);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(142, 20);
            this.PasswordInput.TabIndex = 5;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel.Location = new System.Drawing.Point(137, 196);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(80, 13);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "Invalid login!";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StatusLabel.Visible = false;
            // 
            // ServerAddressInput
            // 
            this.ServerAddressInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LoginViewBindingSource, "ServerAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ServerAddressInput.Location = new System.Drawing.Point(151, 118);
            this.ServerAddressInput.Name = "ServerAddressInput";
            this.ServerAddressInput.Size = new System.Drawing.Size(142, 20);
            this.ServerAddressInput.TabIndex = 7;
            // 
            // ServerPortInput
            // 
            this.ServerPortInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LoginViewBindingSource, "ServerPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ServerPortInput.Location = new System.Drawing.Point(151, 159);
            this.ServerPortInput.Name = "ServerPortInput";
            this.ServerPortInput.Size = new System.Drawing.Size(142, 20);
            this.ServerPortInput.TabIndex = 8;
            // 
            // ServerAddressLabel
            // 
            this.ServerAddressLabel.AutoSize = true;
            this.ServerAddressLabel.Location = new System.Drawing.Point(61, 121);
            this.ServerAddressLabel.Name = "ServerAddressLabel";
            this.ServerAddressLabel.Size = new System.Drawing.Size(85, 13);
            this.ServerAddressLabel.TabIndex = 9;
            this.ServerAddressLabel.Text = "Server Address :";
            // 
            // ServerPortLabel
            // 
            this.ServerPortLabel.AutoSize = true;
            this.ServerPortLabel.Location = new System.Drawing.Point(61, 162);
            this.ServerPortLabel.Name = "ServerPortLabel";
            this.ServerPortLabel.Size = new System.Drawing.Size(66, 13);
            this.ServerPortLabel.TabIndex = 10;
            this.ServerPortLabel.Text = "Server Port :";
            // 
            // LoginViewBindingSource
            // 
            this.LoginViewBindingSource.DataSource = typeof(IRC_Client.ViewModels.LoginViewModel);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 262);
            this.Controls.Add(this.ServerPortLabel);
            this.Controls.Add(this.ServerAddressLabel);
            this.Controls.Add(this.ServerPortInput);
            this.Controls.Add(this.ServerAddressInput);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.NicknameInput);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NicknameLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.LoginViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label NicknameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox NicknameInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox ServerAddressInput;
        private System.Windows.Forms.TextBox ServerPortInput;
        private System.Windows.Forms.Label ServerAddressLabel;
        private System.Windows.Forms.Label ServerPortLabel;
        private System.Windows.Forms.BindingSource LoginViewBindingSource;
    }
}