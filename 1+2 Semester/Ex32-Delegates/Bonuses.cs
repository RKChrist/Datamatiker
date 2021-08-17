using System;
using System.Collections.Generic;
using System.Text;

namespace Ex32_Delegates
{
    public delegate double BonusProvider(double amount);

    public class Bonuses
    {
        public static double TenPercent(double amount)
        {
            return (amount * 0.1);
        }

        public static double FlatTwoIfAmountMoreThanFive(double amount)
        {
            double result = 0;

            if(amount > 5)
                result = 2;

            return result;
        }
    }
}
