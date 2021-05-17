using System;
using System.Collections.Generic;
using System.Text;

namespace Ex30_ObserverPattern
{
    public class Student : Observer
    {
        private Academy subject;
        private string message;

        public string Message
        {
            get { return message; }
            set { 
                message = value;
            }
        }

        public string Name { get; }

        public Student(Academy subject, string name)
        {
            this.subject = subject;
            Name = name;
        }

        public override void Update()
        {
            Message = subject.Message;
            Console.WriteLine($"Studerende {Name} modtog nyheden {Message} fra akademiet {subject.Name}.");
        }
    }
}
