using System;

namespace hp_shoppingList
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("######################################");
            Console.WriteLine("#            INDKØBSLISTE            #");
            Console.WriteLine("######################################");
            Console.WriteLine("\n\t[1] Bananer (2,- stk)");
            Console.WriteLine("\t[2] Æbler (2,- stk)");
            Console.WriteLine("\t[3] Vandmelon (25,- stk)");
            Console.WriteLine("\t[4] Ananas (20,- stk)\n");
            Console.WriteLine("######################################");
            Console.WriteLine("\n\tTryk (0) for at stoppe med at tilføje ting, og se den fulde pris.");

            Console.Write("\nIndtast et tal, for at tilføje et produkt til indkøbslisten: ");

            bool continueBuy = true;
            int totalPrice = 0;
            int item01 = 0;
            int item02 = 0;
            int item03 = 0;
            int item04 = 0;

            while (continueBuy == true)
            {
                int userBoyItem = int.Parse(Console.ReadLine());

                switch(userBoyItem)
                {
                    case 1:
                        totalPrice = totalPrice + 2;
                        item01++;
                        break;
                    case 2:
                        totalPrice = totalPrice + 2;
                        item02++;
                        break;
                    case 3:
                        totalPrice = totalPrice + 25;
                        item03++;
                        break;
                    case 4:
                        totalPrice = totalPrice + 20;
                        item04++;
                        break;
                    case 0:
                        continueBuy = false;
                        break;
                }
                Console.WriteLine("Tilføjet.");
            }

            Console.WriteLine("\nDu valgte at tilføje " + (item01 + item02 + item03 + item04) + " ting.");
            Console.WriteLine("Dette endte med at koste " + totalPrice + ",-");
        }
    }
}
