using System;
using System.Collections.Generic;
using System.Text;

namespace Ex30_ObserverPattern
{
    public class ConcreteSubject : Subject
    {
        private int state = 0;  

        public int State
        {
            get { return state; }
            set { 
                state = value;
                this.Notify();
            }
        }

    }
}
