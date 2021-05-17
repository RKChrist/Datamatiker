using System;

namespace Ex13_OSAndMultipleChoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal to binary converter.\n\n");
            while (true)
            {
                Console.Write("Skriv et heltal: ");
                int userInput = InputIntValidator(Console.ReadLine());
                Console.WriteLine("\t{0} konverteret til binær er: \n\t{1}\n",userInput, BinaryFromDecimal(userInput));
            }
        }

        static string BinaryFromDecimal(int decNum)
        {
            string tempBinaryResult = ""; 
            string endResult = "";

            if(decNum == 0)
            {
                endResult = "0";
            } else
            {
                // Save user supplied value into temp var...
                int tempNum = decNum;

                while(tempNum > 0)
                {
                    tempBinaryResult += tempNum % 2;    // Remainder of modulus 2, is stored to string var
                    tempNum = tempNum / 2;              // Overwrite original tempvar with new value, which is orig / 2.
                }

                // Now we have the result, but in reverse order, soo let's fix.
                for(int i = tempBinaryResult.Length - 1; i >= 0; i--)
                {
                    endResult += tempBinaryResult[i];
                }
            }

            return endResult;
        }
    
        static int InputIntValidator(string input)
        {
            int result;
            while (!int.TryParse(input, out result))
            {
                if (input == "clear")
                    Console.Clear();
                else
                    Console.WriteLine("Incorrect datatype. Only integers are allowed.\n");
                
                
                Console.Write("Try again:");
                input = Console.ReadLine();
            }

            return result;
        }
    }
}