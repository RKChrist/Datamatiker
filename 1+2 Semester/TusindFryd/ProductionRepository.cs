using System;
using System.Collections.Generic;
using System.Text;

namespace TusindFryd
{
    public class ProductionRepository
    {
        private List<Production> production = new List<Production>();

        /// <summary>
        /// Adds a production to the production list.
        /// </summary>
        /// <param name="production"></param>
        public void AddProduction(Production production)
        {
            this.production.Add(production);
        }

        /// <summary>
        /// Returns a specific production, if one is found.
        /// </summary>
        /// <param name="itemId">Id of specified production.</param>
        /// <returns></returns>
        public Production GetProduction(string itemId)
        {
            Production returnVar = null;

            foreach(Production p in production)
            {
                if(p.ProductionId == itemId)
                {
                    returnVar = p;
                    break;
                }
            }

            return returnVar;
        }
    }
}
