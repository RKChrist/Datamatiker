using Ex31_ObserverPattern2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex30_ObserverPattern
{
    public class Student : Person, IObserver
    {
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        // Constructor
        public Student(string name) : base(name){}

        // Interface
        public void Update(object o, EventArgs e)
        {
            Message = (o as Academy).Message;
            Console.WriteLine($"Studerende {Name} modtog nyheden {Message} fra akademiet {(o as Academy).Name}.");
        }
    }
}