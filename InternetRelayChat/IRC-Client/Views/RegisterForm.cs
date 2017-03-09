using IRC_Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRC_Client.Views
{
    public partial class RegisterForm : Form
    {
        private IServer server;

        public RegisterForm(IServer server)
        {
            this.server = server;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = server.Register(nicknameText.Text, nameText.Text, passwordText.Text);
            switch (result)
            {
                case 0:
                    statusLabel.ForeColor = Color.Green;
                    break;
                default:
                    statusLabel.ForeColor = Color.Red;
                    break;
            }
            string reason;
            Utils.ErrorCodes.TryGetValue(result, out reason);
            statusLabel.Text = reason;
        }
    }
}
