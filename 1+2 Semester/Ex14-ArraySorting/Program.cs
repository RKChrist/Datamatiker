using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_14Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Par sokker.
            int[] arr = { 10, 10, 20, 20, 30, 30, 40, 40, 50 }; // Should be 9.
            Console.WriteLine(SockMerchant(arr));


            #endregion

            #region Array sorting task.
            /* Array sorting task.
            int[] arr = new int[] { 3, 2, 4, 1 };
            Console.WriteLine("Before sort: ");
            foreach (int n in arr)
            {
                Console.Write(n);
            }
            arr = IntArrSort(arr);
            Console.WriteLine("\n\nAfter sort: ");
            foreach (int n in arr)
            {
                Console.Write(n);
            }
            */
            #endregion
        }
        /// <summary>
        /// Returns the amount of pairs existing in the array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int SockMerchant(int[] arr)
        {
            int pairAmount = 0;

            // Get length of the array
            int count = arr.Length;

            // wasted indice array keeper
            List<int> wa = new List<int>();

            // Go through the entirety of the array
            for(int i = 0; i < count; i++)
            {
                // Go through the array again, but F A S T E R 
                for(int j = i + 1; j < count; j++)
                {
                    // If numbers are the same
                    if(arr[i] == arr[j] && !wa.Contains(i) && !wa.Contains(j))
                    {
                        pairAmount++;
                        // Need to make sure it won't keep counting for pairs now.
                        wa.Add(j);
                        break;
                    }
                }
            }

            return pairAmount;
        }

        public static int[] IntArrSort(int[] inputArr)
        {
            int count = inputArr.Count();

            /* Insertion sort. 3,j[2],4,1
             * j gets assigned to 1, which is the second first entry in the array.
             * i gets assigned to j's value.
             * Check to see if i (and thus j) is larger than 0.
             * Check to see if the value for indice i is larger than the value for indice i - 1.
             * - This basically means, we compare the current value, with the value behind it.
             * - Then if the current value is smaller than the one before, it will be swapped.
             */
            //for (int j = 1; j < count; j++)
            //{
            //    for (int i = j; i > 0 && inputArr[i] < inputArr[i - 1]; i--)
            //    {
            //        Exchange(inputArr, i, i - 1);
            //    }
            //}

            /* Bubble sort.
             * Go through each element of the array, starting at the last element.
             * Then for each element, create a new loop.
             * This new loop goes through the entire array, up till the current value of old array.
             * Then we compare the value of new loop, with new loop + 1, i.e.  the next value for the loop iteration.
             * If current value is smaller than next, then change those two.
             */
            for (int j = count-1; j > 0; j--)
            {
                for(int i = 0; i < j; i++)
                {
                    if (inputArr[i] > inputArr[i + 1])
                        inputArr = Exchange(inputArr, i, i + 1);
                }
            }



            return inputArr;
        }

        /// <summary>
        /// Swaps the values of two indices in an array.
        /// </summary>
        /// <param name="data">Input array.</param>
        /// <param name="m">Indice of first value to be swapped.</param>
        /// <param name="n">Indice of second value to be swapped.</param>
        public static int[] Exchange(int[] data, int m, int n)
        {
            int temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;

            return data;
        }
    }
}
