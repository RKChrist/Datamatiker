using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Linq;

namespace Ex12_Persistance
{
    public class FileHelper
    {
        public static void AddEntry(string newEntry)
        {
            // If the array is 1 entity long, and the first line is blank.. THEN OVERWRITE THE DOCUMENT
            if(FileEmpty())
            {
                using (StreamWriter writer = new StreamWriter("entrylog.txt"))
                {
                    writer.WriteLine(newEntry);
                }
            } else
            {
                using (StreamWriter writer = new StreamWriter("entrylog.txt", true))
                {
                    writer.WriteLine(newEntry);
                }
            }
        }

        /*
            I mean, this should probably now be using "File.ReadAllLines()", but oh well, it works.
            But you know, we're working with text files in the size of a few KB.. Sooo File. works.. StreamReader/Writer should be used for very large files..
            But like I said, smol file = File )))))
        */
        public static void RemoveEntry(int lineNumber) 
        {
            // Save content of file to array.
            string[] textContent = File.ReadAllLines("entrylog.txt");

            // Create new array, with length equal to the original, -1
            string[] newTextContent = new string[textContent.Length - 1];

            bool lineSkipped = false;

            // Go through all entries in the array.
            for(int i = 1; i <= textContent.Length; i++)
            {
                // No match, write to array
                if(i != lineNumber)
                {
                   if(lineSkipped)
                        newTextContent[i - 2] = textContent[i - 1];     // -2, cuz we skipped one entry, and newTextContent is 1 entry smaller. Therefore -2
                   else
                        newTextContent[i - 1] = textContent[i - 1];
                } else
                {
                    lineSkipped = true;
                    continue;
                }
            }

            File.WriteAllLines("entrylog.txt", newTextContent);
        }

        public static void UpdateEntry(int lineNumber, string newEntry)
        {
            string[] textContent = File.ReadAllLines("entrylog.txt");
            textContent[lineNumber - 1] = newEntry;
            using (StreamWriter sw = new StreamWriter("entrylog.txt"))
            {
                foreach (string line in textContent)
                {
                    sw.WriteLine(line);
                }
            }
        }

        public static string DisplayEntry(int lineNumber)
        {
            string[] textContent = File.ReadAllLines("entrylog.txt");
            return textContent[lineNumber-1];
        }

        public static void DisplayEntries()
        {
            using (StreamReader reader = new StreamReader("entrylog.txt"))
            {
                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine("\t{0}", line);
                }
            }

            Console.WriteLine("\n");
        }

        public static void ClearFile()
        {
            using (StreamWriter sw = new StreamWriter("entrylog.txt"))
            {
                sw.WriteLine("");
            }
        }

        public static bool FileEmpty()
        {
            string file;
            using (StreamReader reader = new StreamReader("entrylog.txt"))
            {
                file = reader.ReadToEnd();
            }

            // if file has length of 0, or the only content of file is blank space
            if (new FileInfo("entrylog.txt").Length == 0 || file == "\r\n")
                return true;
            else
                return false;

        }
    }
}
