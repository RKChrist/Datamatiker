using System;
using System.Security.Cryptography;

namespace numberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("\nPlease select a difficulty by entering its number: ");
            Console.WriteLine("\tEasy (1): 6 tries. 0 - 10.");
            Console.WriteLine("\tMedium (2): 7 tries. 0 - 50.");
            Console.WriteLine("\tHard (3): 10 tries. 0 - 1000.\n");

            int difficulty = int.Parse(Console.ReadLine());
            Random rnd = new Random();

            //Stupid hack, but it works for now. Need to figure out local/global scopes.
            int numberToGuess = 1;
            int allowedGuesses = 6;

            // Find random num based on difficulty
            switch (difficulty)
            {
                case 1:
                    numberToGuess = rnd.Next(0,11);
                    allowedGuesses = 6;
                    Console.WriteLine("\nEasy difficulty has been selected.");
                    break;

                case 2:
                    numberToGuess = rnd.Next(0, 51);
                    allowedGuesses = 7;
                    Console.WriteLine("\nMedium difficulty has been selected.");
                    break;

                case 3:
                    numberToGuess = rnd.Next(0, 1001);
                    allowedGuesses = 10;
                    Console.WriteLine("\nHard difficulty has been selected.");
                    break;
            }

            Console.WriteLine("Number has been generated. To start, simply enter your guess: \n");

            // Another hack. Due to me not knowing local/global scope (it's 5 just to have a random int).
            int resultCheck = 5;
            int guessesLeft = allowedGuesses;

            // Go through for loop. If user guesses correctly, resultCheck gets changed to 1, meaning they won. Otherwise stays 0, meaning lost.
            for(int i = 0; i < allowedGuesses; i++)
            {
                Console.WriteLine("Guesses left: " + guessesLeft);
                guessesLeft--;

                // Call our method to check for the number, and save whatever is returns
                resultCheck = numberCheck(Console.ReadLine(), numberToGuess);

                // If user guesses correctly, break out of for loop.
                if(resultCheck == 1)
                {
                    break;
                }
            }

            // If they won or no
            if(resultCheck == 1)
            {
                Console.WriteLine("\nCongratulations, you guessed the number.");
                Console.WriteLine("You had " + allowedGuesses + " guesses at the start, and you used " + (allowedGuesses - guessesLeft) + " of them.");
            } else
            {
                Console.WriteLine("\nThough luck, didn't get it this time. Try again!");
                Console.WriteLine("The correct number was: " + numberToGuess);
            }

            // Make sure program won't just end.
            Console.ReadLine();
        }

        static int numberCheck(string guessNumber, int numberToGuess)
        {
            int numberGuess = int.Parse(guessNumber);

            // Let's compare numberGuess with numberToGuess
            if (numberGuess > numberToGuess)
            {
                Console.WriteLine("High.\n");
            }
            else if (numberGuess < numberToGuess)
            {
                Console.WriteLine("Low.\n");
            }
            else
            {
                Console.WriteLine("Correct.\n");
                return 1;
            }

            // If it couldn't be guessed, return 0
            return 0;
        }
    }
}
