using System;

namespace askInputShowInput
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Purpose of program:
            Ask the user for their name and year of birth.
            Then print their name and their current age.

            Problems with this program:
            Current year is hardcoded for now, meaning it will be obsolete when the current year no longer matches up with whatever is hardcoded.

            Extra feature:
            Fail check. If user inputs a string when an int is needed, program will ask user again, and continue to do so.
            */

            Console.WriteLine("Hello.\nPlease enter your firstname: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("\nThank you " + firstName + ", now please also enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("\nOnce again, much appreciated. However, your birthyear is also needed: ");
            //int birthYear = int.Parse(Console.ReadLine());
            int birthYear = intUserCheck(Console.ReadLine());

            int currentYear = 2020;
            Console.WriteLine("\n\nThank you " + firstName + " " + lastName + ".");
            Console.WriteLine("We can see your age should be around " + (currentYear - birthYear) + " years.");
        }

        public static int intUserCheck(string userInputFromConsole)
        {
            if (int.TryParse(userInputFromConsole, out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Incorrect input. Please only use numbers.\n");
                return intUserCheck(Console.ReadLine());
            }
        }
    }
}
