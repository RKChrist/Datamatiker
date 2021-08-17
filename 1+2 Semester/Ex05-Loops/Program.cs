using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Ex05_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Øvelse 4.10
            /*
            string StringyBoyo = "Året er 2020, der har været mangel på + (positive) ting, hvorimod der har været et stort overskud på - (negative) ting.";
            string message = "";

            // Loop through all characters of the string.
            for(int i = 0; i < StringyBoyo.Length; i++)
            {

                // Check for ints.
                if(
                    StringyBoyo[i] == '0' ||
                    StringyBoyo[i] == '1' ||
                    StringyBoyo[i] == '2' ||
                    StringyBoyo[i] == '3' ||
                    StringyBoyo[i] == '4' ||
                    StringyBoyo[i] == '5' ||
                    StringyBoyo[i] == '6' ||
                    StringyBoyo[i] == '7' ||
                    StringyBoyo[i] == '8' ||
                    StringyBoyo[i] == '9'
                  )
                {
                    message = "Ciffer";
                } 

                // Check for operators
                else if (
                    StringyBoyo[i] == '+' ||
                    StringyBoyo[i] == '-' 
                  )
                {
                    message = "Operator";
                }

                // If not int or operator, must be letter.
                else
                {
                    message = "Ukendt";
                }

                // Write it out
                Console.WriteLine("Index: {0, 10:0} Karakter: {1, 10:0} Type: {2, 10:0}", i, StringyBoyo[i], message);
            }

            */
            #endregion

            #region Øvelse 4.11

            /*
            Get a string with math.
            Run through each character.
            Check if it's an int.
                - If yes: add value to TempValue.
                - If no (meaning it's an operator): Change OperatorAddition to either true or false, depending on what it needs to be. Also change NextIsCalc.
            
            */
            Console.WriteLine("Rules: ");
            Console.WriteLine("\tMust start and end with an integer.");
            Console.WriteLine("\tNo double digits allowed.");
            Console.WriteLine("\tOnly addition and subtraction are allowed.");
            Console.WriteLine("\tAn operator must be followed by an integer.\n");
            Console.Write("Write some math stuff: ");
            string MathInString = Console.ReadLine();
            int MathFinal = 0;
            int TempValue = 0; 
            bool NextIsCalc = false;
            bool OperatorAddition = true;
            bool PreviousWasInt = false;

            for(int i = 0; i < MathInString.Length; i++)
            {
                switch(MathInString[i])
                {
                    // Check if it's an int.
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '0':

                        // Give an error, if string has double digits.
                        if(PreviousWasInt)
                        {
                            Console.WriteLine("Don't use double digits.");
                            Environment.Exit(0);
                        }

                        // If current character is the first int, assign it to MathFinal. Otherwise TempValue, and check for calculation.
                        if (i == 0)
                        {
                            MathFinal = (int)Char.GetNumericValue(MathInString[i]);
                        } else
                        {
                            TempValue = (int)Char.GetNumericValue(MathInString[i]);

                            // Calculate stuff
                            if(NextIsCalc)
                            {
                                if(OperatorAddition)
                                {
                                    MathFinal += TempValue;
                                } else
                                {
                                    MathFinal -= TempValue;
                                }

                                NextIsCalc = false;
                            }
                        }

                        PreviousWasInt = true;
                        break;
                    case '+':

                        if(NextIsCalc)
                        {
                            Console.WriteLine("An operator must be followed up with an integer.");
                            Environment.Exit(0);
                        }

                        // If current char is '+', then make sure program knows we need to do addition; we need to do a calculation next, and previous char was not an int.
                        OperatorAddition = true;
                        NextIsCalc = true;
                        PreviousWasInt = false;
                        break;
                    case '-':

                        if (NextIsCalc)
                        {
                            Console.WriteLine("An operator must be followed up with an integer.");
                            Environment.Exit(0);
                        }

                        // If current char is '-', then make sure program knows we need to do subtraction; we need to do a calculation next, and previous char was not an int.
                        OperatorAddition = false;
                        NextIsCalc = true;
                        PreviousWasInt = false;
                        break;
                    default:

                        // If current char doesn't match any of our cases, it means user supplied an illegal character.
                        Console.WriteLine("Please only insert single digit numbers, and plus or minus operators.");
                        Environment.Exit(0);
                        break;
                }
            
                // Check if user supplied math stuff, either starts or ends with an operator.
                if(i == MathInString.Length-1 && NextIsCalc || i == 0 && NextIsCalc)
                {
                    Console.WriteLine("Argument must start and end with integer!");
                    Environment.Exit(0);
                }
            }

            Console.WriteLine(MathFinal);

            #endregion
        }
    }
}
