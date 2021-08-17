using System;
using ExceptionalLib;

namespace Ex21_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // GetValue
            try
            {
                Console.WriteLine("1: {0}", TotallySafe.GetValueAtPosition(1));
                Console.WriteLine("4: {0}", TotallySafe.GetValueAtPosition(4));
                Console.WriteLine("9: {0}", TotallySafe.GetValueAtPosition(9));
            }
            catch (IndexOutOfRangeException e) {
                Console.WriteLine("That's an error!");
                Console.WriteLine(e.Message);
            }

            // Divider
            try
            {
                TotallySafe.Divider(2);
                TotallySafe.Divider(0);
            } catch (DivideByZeroException e)
            {
                Console.WriteLine("\nSorry fam, but you can't divide by zero.");
            }

            // To int
            try
            {
                TotallySafe.StringToInt("4");
                TotallySafe.StringToInt("fire");
            } catch (FormatException e)
            {
                Console.WriteLine("\nNumber needs to be numeric value, and not spelled out with characters.");
                Console.WriteLine(e.Message);
            }

            
        }
    }
}