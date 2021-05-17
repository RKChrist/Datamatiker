//using System;
//using System.Collections.Generic;
//using System.Text;
//using Ex16_MorgenGry;

//namespace UtilityLib // Changed namespace, cuz we're in a new namespace.
//{
//    public class Utility
//    {
//        /// <summary>
//        /// Returns the price of the book.
//        /// </summary>
//        /// <param name="book">Book object.</param>
//        /// <returns>Price, in double datatype.</returns>
//        public static double GetValueOfBook(Book book)
//        {
//            return book.Price;
//        }

//        public static double GetValueOfAmulet(Amulet amulet)
//        {
//            double value = 0;

//            switch(amulet.Quality)
//            {
//                case (Level)0:
//                    value = 12.5;
//                    break;
//                case (Level)1:
//                    value = 20;
//                    break;
//                case (Level)2:
//                    value = 27.5;
//                    break;
//                default:
//                    value = 0;
//                    break;
//            }

//            return value;
//        }
    
//        public static double GetValueOfCourse(Course course)
//        {
//            int duration = course.DurationInMinutes;
//            int pricePrHour = 875;

//            // Get hour count, rounds down.
//            int hourCount = duration / 60;

//            // Check if we have started a new hour
//            if (duration % 60 > 0) hourCount++;

//            return pricePrHour * hourCount;
//        }
//    }
//}
