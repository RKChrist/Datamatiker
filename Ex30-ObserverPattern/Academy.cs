using System;
using System.Collections.Generic;
using System.Text;

namespace Ex30_ObserverPattern
{
    public class Academy : Subject
    {
        public string Name { get; }

        private string message;

        public string Message
        {
            get { return message; }
            set { 
                message = value;
                this.Notify();
            }
        }

        public Academy(string name)
        {
            Name = name;
        }
    }
}
