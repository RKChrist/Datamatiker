using System;
using System.Collections.Generic;
using System.Text;

namespace TusindfrydWPF
{
    public class Controller
    {
        public ProductionRepository productionRepo;

        /// <summary>
        /// Constructor for Controller class. Initiailizes new ProductionRepository
        /// </summary>
        public Controller()
        {
            productionRepo = new ProductionRepository();
        }

        public void AddToList(Production production)
        {
            productionRepo.AddProduction(production);
        }
    }
}
