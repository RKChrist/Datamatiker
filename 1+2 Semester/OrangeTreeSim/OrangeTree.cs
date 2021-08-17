using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        // Fuck ton of properties
        public int Age
        {
            get { return age; }
            set
            {
                // Make sure one can't give tree negative age.
                if(value >= 0)
                {
                    this.age = value;
                } else
                {
                    this.age = 0;
                }
            }
        }

        public int Height {
            get { return height; }
            set {
                this.height = value;
            }
        }

        public bool TreeAlive
        {
            get { return treeAlive; }
            set
            {
                treeAlive = value;
            }
        }

        public int NumOranges
        {
            get { return numOranges; }
        }

        public int OrangesEaten
        {
            get { return orangesEaten; }
        }

        // Methods for simulating stuff
        public void OneYearPasses()
        {

            age++;

            // When one year passes, either grow tree, or make it dead.
            if (age < 80 && treeAlive)      // Lowkey don't think I need to make sure the tree is alive... But fuck it, can't use unit testing to be sure... ¯\_(ツ)_/¯
            {
                height += 2;

                // Make sure it won't give fruit the first year.
                if (age > 1)
                {
                    numOranges = (age - 1) * 5;
                    orangesEaten = 0;
                }
            }
            else
            {
                // if tree dead, make sure it also won't have any fruit from prev year.
                treeAlive = false;
                numOranges = 0;
            }
        }

        public void EatOrange(int count)
        {
            if (numOranges >= count)
            {
                orangesEaten += count; // Add to the total amount of oranges eaten.
                                       //_numOranges -= count;   // Subtract count eaten from available oranges this season 
            }
        }
    }
}
