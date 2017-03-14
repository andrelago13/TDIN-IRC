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
    public partial class MessagingView : Form
    {
        private IServer server;
        private LoggedUserInfo userInfo;

        private List<LoggedUserInfo> users;

        public MessagingView()
        {
            this.server = ClientBk.Instance.Connection;
            this.userInfo = ClientBk.Instance.LoggedUser;
            InitializeComponent();
            ClientBk.Instance.sessionsEvent += new SessionUpdateHandler(HandleSession);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = "Logged in as: " + userInfo.Nickname;
            updateList();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            updateList();
        }

        private void updateList()
        {
            List<string> values = new List<string>();
            users = server.LoggedUsers(userInfo.Nickname);
            foreach (LoggedUserInfo i in users)
            {
                values.Add(i.RealName + " [" + i.Nickname + "]");
            }
            userList.DataSource = values;
        }

        private void inviteButton_Click(object sender, EventArgs e)
        {
            int val = userList.SelectedIndex;
            Console.WriteLine(val);
        }

        private void HandleSession(SessionUpdateArgs info)
        {
            List<string> values = new List<string>();
            values.Add(info.Username + " [" + "+" + "]");
            userList.DataSource = values;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClientBk.Instance.MaybeLogout("");
        }
    }
}
