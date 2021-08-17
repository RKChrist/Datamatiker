using System;
using System.Collections.Generic;
using System.Text;

namespace Ex08_MenuTasks
{
    class Menu
    {
        public string Title;
        private MenuItem[] menuItems = new MenuItem[10];
        private static int itemCount = 0;

        // Constructor
        /*
         Code placed within here, will automaticly be run on initialization.
         */
        public Menu(string title)
        {
            Title = title;
        }

        // Show the menu.
        public void Show()
        {
            Console.Clear();
            Console.WriteLine(Title);
            for(int i = 0; i < itemCount; i++)
            {
                Console.WriteLine(menuItems[i].Title);
            }
        }

        // Add new menu item. 
        public void AddMenuItem(string mT)
        {
            // Initialize new object. No checks for array length etc
            MenuItem mi = new MenuItem(mT);
            menuItems[itemCount] = mi;
            itemCount++;
        }

        // Select whatev menu item user wants.. Some code inside here (to check if input is int) could be placed inside a method for repetition. However, not allowed.
        public int SelectMenuItem()
        {
            // Check if input is int
            int mUV = 0;
            while(!int.TryParse(Console.ReadLine(), out mUV))
            {
                Console.Write("\nOnly use integers: ");
            }
            
            // Check if input is in a valid range
            while(mUV < 0 || mUV > itemCount)
            {
                Console.Write("\nIkke et validt valg, forsøg igen.");

                // Check if input is int
                mUV = 0;
                while (!int.TryParse(Console.ReadLine(), out mUV))
                {
                    Console.Write("\nOnly use integers: ");
                }
            }

            return mUV;
        }
    }
}
