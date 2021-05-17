using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_ObserverPattern2
{
    public interface IObserver
    {
        public void Update(object o, EventArgs e);
    }
}
