using System;
using System.Collections.Generic;
using System.Text;

namespace Ex30_ObserverPattern
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject subject;
        public int State { get; set; } = 0;

        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
        } 

        public override void Update()
        {
            State = subject.State;
        }
    }
}
