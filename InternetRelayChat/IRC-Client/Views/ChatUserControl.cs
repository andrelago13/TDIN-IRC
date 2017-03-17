using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IRC_Common.Models;

namespace IRC_Client.Views
{
    public partial class ChatUserControl : UserControl
    {
        private LoggedClient user;

        public ChatUserControl(LoggedClient user)
        {
            InitializeComponent();
            this.user = user;
        }
    }
}
