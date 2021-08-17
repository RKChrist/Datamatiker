using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_ObserverPattern2
{
    public class Organization
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        public string Address { get; set; }

        public Organization(string name)
        {
            this.name = name;
        } 
    }
}