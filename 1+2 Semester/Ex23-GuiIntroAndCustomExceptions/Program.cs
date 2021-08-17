using System;
using System.IO;

namespace Ex23_GuiIntroAndCustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Please add some presidents to the \"Good presidents list\".\n");
            while (true)
            {
                Console.Write("> ");
                try
                {
                    using (StreamWriter sw = new StreamWriter("GoodPresidents.txt", true))
                    {
                        input = Console.ReadLine();

                        // Check to see if we need to throw exception
                        if (input == "Donald Trump" || input == "donald trump" || input == "Donald trump" || input == "trump" || input == "Trump")
                            throw new InvalidPresidentName("Not a good president.");

                        sw.WriteLine(input);
                        Console.WriteLine($"\t\"{input}\" added.");
                    }
                } catch(InvalidPresidentName e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
                Console.WriteLine("");
            }
        }
    }
}
