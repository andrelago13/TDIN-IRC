using IRC_Client.Models;
using IRC_Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IRC_Client.ViewModels
{
    class MessagingViewModel : INotifyPropertyChanged
    {
        #region Singleton
        private static MessagingViewModel instance;

        public static MessagingViewModel Instance
        {
            get
            {
                if (instance == null)
                    instance = new MessagingViewModel();
                return instance;
            }
        }
        #endregion

        private Client Client;

        private MessagingViewModel()
        {
            this.Client = Client.Instance;
        }

        #region Accessors
        public string WelcomeText
        {
            get
            {
                return "Welcome, " + this.Client.Nickname;
            }
        }

        public string Nickname
        {
            get
            {
                return this.Client.Nickname;
            }

            set
            {
                if(this.Client.Nickname != value)
                {
                    this.Client.Nickname = value;
                    this.NotifyPropertyChanged(nameof(Nickname));
                    this.NotifyPropertyChanged(nameof(WelcomeText));
                }
            }
        }

        public string Password
        {
            get
            {
                return this.Client.Password;
            }

            set
            {
                if (this.Client.Password != value)
                {
                    this.Client.Password = value;
                    this.NotifyPropertyChanged(nameof(Password));
                }
            }
        }

        public string RealName
        {
            get
            {
                return this.Client.RealName;
            }

            set
            {
                if (this.Client.RealName != value)
                {
                    this.Client.RealName = value;
                    this.NotifyPropertyChanged(nameof(RealName));
                }
            }
        }

        private List<LoggedClient> loggedUsers = new List<LoggedClient>();

        public List<LoggedClient> LoggedUsers {
            get
            {
                return this.loggedUsers;
            }

            set
            {
                if (this.loggedUsers != value)
                {
                    this.loggedUsers = value;
                    this.NotifyPropertyChanged(nameof(LoggedUsers));
                }
            }
        }

        #endregion

        #region Public Methods
        public void UpdateOnlineUsers()
        {
            this.LoggedUsers = this.Client.ServerConnection.Connection.LoggedUsers(this.Nickname);
        }

        public async void InviteClient(LoggedClient client)
        {
            bool res = await Task.Run(() => Client.Instance.InviteClient(client.Address, client.Port));
        }
        #endregion

        #region Property Change
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion
    }
}
