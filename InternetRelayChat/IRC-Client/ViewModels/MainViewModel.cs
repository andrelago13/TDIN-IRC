using IRC_Client.Models;
using IRC_Client.Views;
using IRC_Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IRC_Client.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel Instance
        {
            get
            {
                if (instance == null)
                    instance = new MainViewModel();
                return instance;
            }
        }

        private MainViewModel()
        {
            this.Client = Client.Instance;
            this.ServerConnection = this.Client.ServerConnection;
        }
        #endregion

        private Client Client;
        private Connection ServerConnection;

        #region Accessors

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

        public string ServerAddress
        {
            get
            {
                return this.ServerConnection.Address;
            }

            set
            {
                if (this.ServerConnection.Address != value)
                {
                    this.ServerConnection.Address = value;
                    this.NotifyPropertyChanged(nameof(ServerAddress));
                }
            }
        }

        public string ServerPort
        {
            get
            {
                return this.ServerConnection.Port;
            }

            set
            {
                if (this.ServerConnection.Port != value)
                {
                    this.ServerConnection.Port = value;
                    this.NotifyPropertyChanged(nameof(ServerPort));
                }
            }
        }

        public string Status
        {
            get
            {
                return this.ServerConnection.Status;
            }

            set
            {
                if (this.ServerConnection.Status != value)
                {
                    this.ServerConnection.Status = value;
                    this.NotifyPropertyChanged(nameof(Status));
                }
            }
        }

        #endregion

        #region Property Change

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                Delegate[] eventHandlers = PropertyChanged.GetInvocationList();

                foreach (Delegate d in eventHandlers)
                {
                    // Check whether the target of the delegate implements 
                    // ISynchronizeInvoke (Winforms controls do), and see
                    // if a context-switch is required.
                    ISynchronizeInvoke target = d.Target as ISynchronizeInvoke;

                    if (target != null && target.InvokeRequired)
                    {
                        target.Invoke(d, new object[] { this, new PropertyChangedEventArgs(info) });
                    }
                    else
                    {
                        d.DynamicInvoke(new PropertyChangedEventArgs(info));
                    }
                }
            }
        }
        
        #endregion

        #region Public Methods

        public bool Login()
        {
            try
            {
                bool validLogin = this.Client.Login(this.Nickname, this.Password);
                if (!validLogin)
                {
                    this.Status = "Invalid login credentials.";
                }

                return validLogin;
            }
            catch (Exception ex)
            {
                this.Status = ex.Message;
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Register()
        {
            IServer connection = Client.Instance.ServerConnection.Connection;

            try
            {
                int result = connection.Register(this.Nickname, this.RealName, this.Password);

                // Set the reason
                string reason;
                Utils.ErrorCodes.TryGetValue(result, out reason);
                this.Status = reason;

                return result == 0;
            }
            catch (Exception ex)
            {
                this.Status = ex.Message;
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        
        #endregion
    }
}
