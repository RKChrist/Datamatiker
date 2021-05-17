using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_ObserverPattern2
{
    public class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        public Person(string name)
        {
            this.name = name;
        }
    }
}
