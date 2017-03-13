using IRC_Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IRC_Client.ViewModels
{
    class LoginViewModel : INotifyPropertyChanged
    {
        private static LoginViewModel instance;

        public static LoginViewModel Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoginViewModel();
                return instance;
            }
        }

        private Login _model;

        private LoginViewModel()
        {
            _model = new Login();
        }

        public string Nickname
        {
            get
            {
                return _model.Nickname;
            }

            set
            {
                if(_model.Nickname != value)
                {
                    _model.Nickname = value;
                    this.NotifyPropertyChanged(nameof(Nickname));
                }
            }
        }

        public string Password
        {
            get
            {
                return _model.Password;
            }

            set
            {
                _model.Password = value;
                this.NotifyPropertyChanged(nameof(Password));
            }
        }

        public string ServerAddress
        {
            get
            {
                return _model.ServerAddress;
            }

            set
            {
                _model.ServerAddress = value;
                this.NotifyPropertyChanged(nameof(ServerAddress));
            }
        }

        public int ServerPort
        {
            get
            {
                return _model.ServerPort;
            }

            set
            {
                _model.ServerPort = value;
                this.NotifyPropertyChanged(nameof(ServerPort));
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
