using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Ex16_MorgenGry
{
    public class ValuableRepository : IPersistable
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string id)
        {
            IValuable returnValue = null;
            foreach(IValuable i in valuables)
            {
                if(i is Book)
                {
                    Book b = i as Book;
                    if(b.ItemId == id)
                    {
                        returnValue = b;
                        break;
                    }
                } else if(i is Amulet)
                {
                    Amulet a = i as Amulet;
                    if (a.ItemId == id)
                    {
                        returnValue = a;
                        break;
                    }
                } else if(i is Course)
                {
                    Course c = i as Course;
                    if (c.Name == id)
                    {
                        returnValue = c;
                        break;
                    }
                }
            }
            return returnValue;
        }

        public double GetTotalValue()
        {
            double returnValue = 0;
            
            // Go through our entire list.
            foreach(IValuable i in valuables)
            {
                returnValue += i.GetValue();
                Console.WriteLine(i.ToString());
            }

            // Return our value, no shit...
            return returnValue;
        }

        public int Count()
        {
            return valuables.Count;   
        }
    
        /*
            Well, method overloading.. As far as I know, it requires us to actually write our entire code base... Twice, which is, you know, gay.
            Oh well, it's done. Will change if better way is found.
        */

        public void Save()
        {
            Save("ValuableRepository.txt");
        }

        public void Save(string fileName)
        {
            // Create file with name.
            StreamWriter sw = File.CreateText(fileName);

            // Loop list through
            foreach (IValuable v in valuables)
            {
                string line = "";

                // Check what type our shit is
                if (v is Book)
                {
                    Book b = v as Book;
                    line = $"BOG;{b.ItemId};{b.Title};{b.GetValue()}";
                }
                else if (v is Amulet)
                {
                    Amulet a = v as Amulet;
                    line = $"AMULET;{a.ItemId};{a.Design};{a.Quality};{a.GetValue()}";
                }
                else if (v is Course)
                {
                    Course c = v as Course;
                    line = $"COURSE;{c.Name};{c.DurationInMinutes};{c.GetValue()}";
                }

                sw.WriteLine(line);
            }
            sw.Close();
        }

        public void Load()
        {
            Load("ValuableRepository.txt");
        }

        public void Load(string fileName)
        {
            // Read from text document.
            StreamReader sr = new StreamReader(fileName);

            // Keep on reading, as long as we have lines to read
            while (!sr.EndOfStream)
            {
                // Take each line
                string line = sr.ReadLine();

                // Split each line into an array, based on ';'
                string[] para = line.Split(';');

                // Need to create objects
                IValuable objectNeeded = null; // NULL ends up being overwritten eksde.. Not perfect, but for this small school project, is fine.

                switch (para[0])
                {
                    case "BOG":
                        objectNeeded = new Book(itemId: para[1], title: para[2], price: Convert.ToDouble(para[3]));
                        break;

                    case "AMULET":
                        objectNeeded = new Amulet(itemId: para[1], design: para[2], quality: (Level)Enum.Parse(typeof(Level), para[3], true));
                        break;

                    case "COURSE":
                        objectNeeded = new Course(name: para[1], duration: int.Parse(para[2]));
                        break;
                }

                // Add valuable to list
                AddValuable(objectNeeded);
            }

            // Close file
            sr.Close();
        }
    }
}