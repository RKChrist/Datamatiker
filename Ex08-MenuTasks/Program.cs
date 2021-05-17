using System;

namespace Ex08_MenuTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = new Menu("Min menu");

            mainMenu.AddMenuItem("1. Mit dejlige første menu punkt.");
            mainMenu.AddMenuItem("2. Punkt nummero duo.");
            mainMenu.AddMenuItem("3. dasnjadsnmjksa");
            mainMenu.AddMenuItem("4. eksde");

            mainMenu.Show();

            int itemId = mainMenu.SelectMenuItem();
            string message = "";
            while(itemId > 0)
            {
                // Figure out what to display based on user value
                switch (itemId)
                {
                    case 0:
                        message = "Du valgte 0, for at forlade menuen.";
                        break;
                    case 1:
                        message = "Du valgte 1.";
                        break;

                    case 2:
                        message = "Du valgte 2.";
                        break;
                    case 3:
                        message = "Здесь нельзя использовать русский язык!";
                        break;
                    case 4:
                        message = "Du valgte 4.";
                        break;

                    default:
                        break;

                }

                // Show the main menu again. Print the message. Ask for input again.
                mainMenu.Show();
                Console.WriteLine("\n\t{0}", message);
                itemId = mainMenu.SelectMenuItem();
            }
        }
    }
}
