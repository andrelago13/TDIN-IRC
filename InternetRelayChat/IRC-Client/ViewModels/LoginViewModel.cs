using IRC_Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Client.ViewModels
{
    class LoginViewModel : INotifyPropertyChanged
    {
        private Login _Model;

        public string Nickname
        {
            get
            {
                return _Model.Nickname;
            }

            set
            {
                _Model.Nickname = value;
                this.NotifyPropertyChanged("Nickname");
            }
        }

        public string Password
        {
            get
            {
                return _Model.Password;
            }

            set
            {
                _Model.Password = value;
                this.NotifyPropertyChanged("Password");
            }
        }

        public string ServerAddress
        {
            get
            {
                return _Model.ServerAddress;
            }

            set
            {
                _Model.ServerAddress = value;
                this.NotifyPropertyChanged("ServerAddress");
            }
        }

        public int ServerPort
        {
            get
            {
                return _Model.ServerPort;
            }

            set
            {
                _Model.ServerPort = value;
                this.NotifyPropertyChanged("ServerPort");
            }
        }

        //Implementing INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
