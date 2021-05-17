using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_ObserverPattern2
{
    public interface ISubject
    {
        public void Attach(IObserver o);
        public void Detach(IObserver o);
        public void Notify();
    }
}
