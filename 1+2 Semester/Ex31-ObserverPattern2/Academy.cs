using Ex31_ObserverPattern2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Ex30_ObserverPattern
{
    public delegate void NotifyHandler();

    public class Academy : Organization, INotifyPropertyChanged
    {
        // Her er der blevet tilføjet "event"
        //public event NotifyHandler MessageChanged;

        //public event EventHandler MessageChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        private string message;
        public string Message
        {
            get { return message; }
            set { 
                message = value;
                OnMessageChanged();
            }
        }

        // Constructor for class
        public Academy(string name, string address) : base(name)
        {
            this.Address = address;
        }

        public void OnMessageChanged()
        {
            PropertyChanged(this, null);
            
        }
    }
}