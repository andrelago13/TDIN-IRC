using IRC_Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRC_Client.Views
{
    class ChatTabPage : TabPage
    {
        private LoggedClient user;

        public ChatTabPage(LoggedClient user)
        {
            this.user = user;
            Initialize();
        }

        private void Initialize()
        {
            Controls.Add(new ChatUserControl(user) { Dock = DockStyle.Fill });
            Text = user?.RealName;
        }
    }
}
