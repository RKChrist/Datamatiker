using System;
using System.IO;

namespace Ex22_ResourceManagementBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "text.txt";
            try
            {
                string[] blah = File.ReadAllLines(file);

                foreach(string b in blah)
                {
                    Console.WriteLine(b);
                }

            } catch(DirectoryNotFoundException e)
            {
                Console.WriteLine("Den angivne mappe eksistere ikke.");
                Console.WriteLine(e.Message);

                using (StreamWriter sw = new StreamWriter("errorlog.txt", true))
                {
                    sw.WriteLine($"DirectoryNotFoundException {DateTime.Now}. Fejlbesked: {e.Message}");
                }
            } catch(FileNotFoundException e)
            {
                Console.WriteLine("Den angivne fil eksisterer ikke.");
                Console.WriteLine(e.Message);

                using (StreamWriter sw = new StreamWriter("errorlog.txt", true))
                {
                    sw.WriteLine($"FileNotFoundException {DateTime.Now}. Fejlbesked: {e.Message}");
                }
            } finally
            {
                Console.WriteLine("Vi har tjekket for alle relevante exceptions.");
            }
        }
    }
}
