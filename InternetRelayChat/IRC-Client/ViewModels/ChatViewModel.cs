using IRC_Client.Comunication;
using IRC_Client.Models;
using IRC_Client.Views;
using IRC_Common;
using IRC_Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.TabControl;

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
        
        public ChatView View { get; set; }
        public TabPageCollection Pages { get; set; }

        private ChatViewModel()
        {
            // TODO
        }

        #endregion

        #region Accessors

        private string messageText;

        public string MessageText
        {
            get
            {
                return messageText;
            }

            set
            {
                if (messageText != value)
                {
                    messageText = value;
                    this.NotifyPropertyChanged(nameof(MessageText));
                }
            }
        }

        public int ActivePage { get; set; }

        #endregion

        #region Public Methods

        public void Start()
        {
            Client.Instance.MessageEvent += HandleMessage;
        }

        public void Finish()
        {
            Client.Instance.MessageEvent -= HandleMessage;
        }

        public void HandleMessage(Client sender, string message)
        {
            foreach (TabPage page in Pages)
            {
                if (((ChatTabPage)page).HandleMessage(sender, message))
                    return;
            }
        }

        public void StartChat(IClient client)
        {
            if(View == null)
            {
                View = ChatView.Instance;
            }
            PeerCommunicator pc = Client.Instance.GetClientCommunicator(client);
            View?.AddChat(client, pc);
            View?.Show();
        }

        public void SendMessage()
        {
            string text = MessageText;
            MessageText = "";
            if (text == null || text.Length == 0)
                return;

            ((ChatTabPage) Pages[ActivePage]).SendMessage(text);
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
