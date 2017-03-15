﻿using IRC_Client.Models;
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

        private Client Client;
        private Connection ServerConnection;

        private MainViewModel()
        {
            this.Client = Client.Instance;
            this.ServerConnection = this.Client.ServerConnection;
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
