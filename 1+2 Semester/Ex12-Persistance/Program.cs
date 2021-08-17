using System;
using System.IO;

namespace Ex12_Persistance
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopControl = true;
            do
            {
                Console.WriteLine("## MENU ##\n");
                string[] menuItems = { "1) Add Entry", "2) Remove entry", "3) Update entry", "4) View specific entry", "5) View list of entries", "6) Exit" };

                foreach (string item in menuItems)
                {
                    Console.WriteLine("\t{0}", item);
                }

                int userValue = int.Parse(Console.ReadLine());

                switch(userValue)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine("Type what ya wanna add: ");
                        string userInput = Console.ReadLine();
                        FileHelper.AddEntry(userInput);

                        break;

                    case 2:

                        Console.Clear();
                        Console.WriteLine("What linje ya wanna delete?: ");
                        int userInputInt = int.Parse(Console.ReadLine());
                        FileHelper.RemoveEntry(userInputInt);

                        break;

                    case 3:

                        Console.Clear();
                        Console.WriteLine("What line to change?");
                        userInputInt = int.Parse(Console.ReadLine());
                        Console.WriteLine("New content?: ");
                        userInput = Console.ReadLine();
                        FileHelper.UpdateEntry(userInputInt, userInput);
                        break;

                    case 4:

                        Console.Clear();
                        Console.WriteLine("What line ya wanna see?");
                        userInputInt = int.Parse(Console.ReadLine());
                        string requestedEntry = FileHelper.DisplayEntry(userInputInt);
                        Console.WriteLine("\n\t{0}",requestedEntry);

                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Content of entrylog.txt\n\n");
                        FileHelper.DisplayEntries();

                        break;

                    case 6:
                        loopControl = false;
                        break;

                    default:
                        FileHelper.ClearFile();
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            } while (loopControl);
        }
    }
}
