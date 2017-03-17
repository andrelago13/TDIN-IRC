using IRC_Client.Models;
using IRC_Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Client.ViewModels
{
    public class ChatViewModel : INotifyPropertyChanged
    {
        #region Singleton

        private static ChatViewModel instance;

        public static ChatViewModel Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChatViewModel();
                return instance;
            }
        }

        private ChatViewModel() { }

        #endregion

        #region Accessors

       /*private LoggedClient externalClient;

        public LoggedClient ExternalPeer
        {
            get
            {
                return externalClient;
            }

            set
            {
                if (externalClient != value)
                {
                    externalClient = value;
                    this.NotifyPropertyChanged(nameof(ExternalPeer));
                }
            }
        }*/

        #endregion


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
