using System;

namespace ArrayTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            // Setup the different values for array.
            int[] ages = { 25, 24, 20, 28, 22, 23, 23, 25 };
            double average = 0;
            bool getAverages = true;

            int ageToSearchFor = 20; // Could / Should also be supplied from user input.

            // Loop through all values.
            foreach(int age in ages)
            {
                Console.WriteLine("Denne person er {0} år gammel.", age);

                // Set the average variable to its current value + whatever value age has.
                average += age;

                // If match is found, we tell program we won't need the average and break out.
                if(age == ageToSearchFor)
                {
                    // Match found.
                    Console.WriteLine("Matching search result.");
                    getAverages = false;
                    break;
                } 
                
            }

            if(getAverages)
            {
                // Use the length of the array, to find the average.
                average = average / ages.Length;

                Console.WriteLine("Gennemsnittet for disse personer er: {0}", average);
            }
                
        }
    }
}
