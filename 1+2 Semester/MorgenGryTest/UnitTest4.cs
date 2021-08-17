//using System;
//using System.Collections.Generic;
//using System.Text;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Ex16_MorgenGry;
//using UtilityLib;

//namespace MorgenGryTest
//{
//    [TestClass]
//    public class UnitTest4
//    {
//        Book b1, b2, b3;
//        Amulet a1, a2, a3;
//        Course c1, c2;

//        CourseRepository courses;
//        MerchandiseRepository mr;
//        /* These no longer exist.
//        BookRepository books;
//        AmuletRepository amulets;
//        */

//        [TestInitialize]
//        public void Init()
//        {
//            // Arrange
//            b1 = new Book("1");
//            b2 = new Book("2", "Falling in Love with Yourself");
//            b3 = new Book("3", "Spirits in the Night", 123.55);

//            a1 = new Amulet("11");
//            a2 = new Amulet("12", Level.high);
//            a3 = new Amulet("13", Level.low, "Capricorn");

//            c1 = new Course("Eufori med røg");
//            c2 = new Course("Nuru Massage using Chia Oil", 157);

//            courses = new CourseRepository();
//            mr = new MerchandiseRepository();

//            #region plz no
//            /* These no longer exist.
//            books = new BookRepository();
//            amulets = new AmuletRepository();
//            */

//            // Act
//            /* These should not reference the book / amulet repo
//            books.AddBook(b1);
//            books.AddBook(b2);
//            books.AddBook(b3);

//            amulets.AddAmulet(a1);
//            amulets.AddAmulet(a2);
//            amulets.AddAmulet(a3); */

//            #endregion

//            mr.AddMerchandise(b1);
//            mr.AddMerchandise(b2);
//            mr.AddMerchandise(b3);

//            mr.AddMerchandise(a1);
//            mr.AddMerchandise(a2);
//            mr.AddMerchandise(a3);

//            courses.AddCourse(c1);
//            courses.AddCourse(c2);
//        }

//        [TestMethod]
//        public void TestGetBook()
//        {
//            // Assert
//            Assert.AreEqual(b2, mr.GetMerchandise("2"));
//        }
//        [TestMethod]
//        public void TestGetAmulet()
//        {
//            // Assert
//            Assert.AreEqual(a3, mr.GetMerchandise("13"));
//        }
//        [TestMethod]
//        public void TestGetCourse()
//        {
//            // Assert
//            Assert.AreEqual(c1, courses.GetCourse("Eufori med røg"));
//        }
        
//        /* Baseret på DCD, skal MerdhandiseRepository retunere den totale værdi på alt merchandise. Dette betyder, det skal altså IKKE deles op i "Book" og "Amulet".
//         * Grundet dette, har jeg valgt at udkommentere disse to tests, og sætte en anden ind, som tester om det passer med værdien af ALT merchandise.
//        [TestMethod]
//        public void TestGetTotalValueForBook()
//        {
//            // Assert
//            Assert.AreEqual(123.55, mr.GetTotalValue());
//        }
//        [TestMethod]
//        public void TestGetTotalValueForAmulet()
//        {
//            // Assert
//            Assert.AreEqual(60.0, mr.GetTotalValue());
//        }*/
//        [TestMethod]
//        public void TestGetTotalValueForMerchandise()
//        {
//            // Assert
//            // 1 bog, 3 amuletter.
//            // Bog: 123.55
//            // Amuletter: low, medium & high:  12,5, 20, 27,5 = 60
//            // Alt together = 183,55
//            Assert.AreEqual(183.55, mr.GetTotalValue());
//        }

//        [TestMethod]
//        public void TestGetTotalValueForCourse()
//        {
//            // Assert
//            Assert.AreEqual(2625.0, courses.GetTotalValue());
//        }
//    }

//}
