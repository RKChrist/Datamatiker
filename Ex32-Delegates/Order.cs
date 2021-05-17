using System;
using System.Collections.Generic;
using System.Text;

namespace Ex32_Delegates
{
    public class Order
    {
        public BonusProvider Bonus { get; set; }
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product p)
        {
            _products.Add(p);
        }

        public double GetValueOfProducts()
        {
            double result = 0;

            // Add value of each item to result
            foreach(Product p in _products)
            {
                result += p.Value;
            }

            return result;
        }

        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }

        public double GetTotalPrice()
        {
            return GetValueOfProducts() - GetBonus();
        }
    }
}
