using System;
using System.Collections.Generic;
using System.Text;

namespace Ex16_MorgenGry
{
    public class Controller
    {
        public ValuableRepository ValuableRepo { get; set; }

        public Controller()
        {
            ValuableRepo = new ValuableRepository();
        }

        public void AddToList(IValuable valuable)
        {
            ValuableRepo.AddValuable(valuable);
        }
    }
}
