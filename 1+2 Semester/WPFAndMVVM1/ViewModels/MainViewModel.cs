using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WPFAndMVVM1.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string myLabelText = "Text not set yet";
        public string MyLabelText
        {
            get { return myLabelText; }
            set { 
                myLabelText = value;
                OnPropertyChanged("MyLabelText");
            }
        }

        private string myTextBoxText = "Text not set yet";

        public string MyTextBoxText
        {
            get { return myTextBoxText; }
            set { 
                myTextBoxText = value;
                OnPropertyChanged("MyTextBoxText");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if(handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
