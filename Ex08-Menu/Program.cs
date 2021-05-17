using System;

namespace Ex08_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                CWTitle();

                // Let's use an array for menu points.
                string[] menuPoints = { "1. Medarbejder", "2. Gæster", "3. Test3", "4. Waifu"};

                foreach(string mp in menuPoints)
                {
                    Console.WriteLine("\t{0}", mp);
                }

                int userChoice = InputIntCheck(Console.ReadLine());
                string message = "";

                // The menu logic itself. 
                switch(userChoice)
                {
                    #region Medarbejder
                    case 1:
                        Console.Clear();
                        CWTitle();
                        Console.WriteLine("\tMedarbejder menu.");
                        Console.WriteLine("\t1. Mulighed 1.");
                        Console.WriteLine("\t2. Mulighed 2.");
                        Console.WriteLine("\t3. Oversigt over medarbejderer og deres status.");

                        int workerChoice = InputIntCheck(Console.ReadLine());

                        // Error check.
                        while (workerChoice > 3 || workerChoice < 1)
                        {
                            Console.WriteLine("Vælg en valid mulighed.");
                            workerChoice = InputIntCheck(Console.ReadLine());
                        }

                        // Vi lader lige som om det her kommer fra en fil med data.
                        string[,] workers = new string[,] { { "Jesper", "1" }, { "Karl", "3" }, { "Lissnerboy", "1" } };

                        if (workerChoice == 3) {

                            Console.Clear();
                            CWTitle();
                            Console.WriteLine("\tOversigt over medarbejdere og deres status.");

                            // Loop through the nested array's top layer
                            for(int i = 0; i < workers.GetLength(0); i++)
                            {
                                string workerMood = "";
                                switch (workers[i, 1])
                                {
                                    case "1":
                                        workerMood = ":)";
                                        break;
                                    case "2":
                                        workerMood = ":I";
                                        break;
                                    case "3":
                                        workerMood = ":(";
                                        break;
                                }
                                Console.WriteLine("\t{0} er i et {1} humør.", workers[i, 0], workerMood);
                            }
                        }

                        Console.ReadKey();
                        break;
                    #endregion

                    #region Gæst
                    case 2:
                        Console.Clear();
                        CWTitle();
                        Console.WriteLine("\tGæste menu.");
                        Console.WriteLine("\t1. Jeg har et møde.");
                        Console.WriteLine("\t2. Jeg har ikke et møde.");

                        int guestChoice = InputIntCheck(Console.ReadLine());

                        // Error check.
                        while (guestChoice > 2 || guestChoice < 1) {
                            Console.WriteLine("Vælg en valid mulighed.");
                            guestChoice = InputIntCheck(Console.ReadLine());
                        }

                        if(guestChoice == 1)
                        {
                            Console.WriteLine("Gucci, du har et møde. Så kalder vi på en method der viser muligheder for at få en menu.");
                        } else if (guestChoice == 2)
                        {
                            Console.WriteLine("Right, du har sgu ikke et møde. Så kalder vi på en method der viser muligheder for at få en menu.");
                        }

                        Console.ReadKey();
                        break;

                    #endregion

                    case 3:
                        message = "Inside case 3.";
                        break;

                    case 4:
                        message = "Zero Two.";
                        break;

                    default:
                        message = "Inside default case.";
                        break;
                }

                Console.WriteLine("\n\t{0}\n", message);

                // Returns to menu... Du'h
                ReturnToMenu();
            }
        }

        private static void CWTitle()
        {
            Console.WriteLine("Datamatiker 2020.\nMenusystem baseret på viden fra de første 2 uger.");
            Console.WriteLine("");
        }

        private static void ReturnToMenu()
        {
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
            Console.Clear();
        }

        private static int InputIntCheck(string inputToCheck)
        {
            int tempVar = 0;
            while(!int.TryParse(inputToCheck, out tempVar))
            {
                Console.WriteLine("Only use integers.");
                inputToCheck = Console.ReadLine();
            }
            return tempVar;
        }
    }
}