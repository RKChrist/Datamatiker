using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestGenericListOnInt()
        {
            // ** int list test *********
            LinkedList<int> listInt = new LinkedList<int>();

            // Insert ints and test
            listInt.Append(105);
            listInt.Append(45);
            listInt.Append(11);
            listInt.Append(3);

            Assert.AreEqual(105, listInt.First);
            Assert.AreEqual(3, listInt.Last);
            Assert.AreEqual(4, listInt.Count);
            Assert.AreEqual(105, listInt.ItemAt(0));
            Assert.AreEqual(45, listInt.ItemAt(1));
            Assert.AreEqual(11, listInt.ItemAt(2));
            Assert.AreEqual(3, listInt.ItemAt(3));
        }
        [TestMethod]
        public void TestGenericListOnString()
        {
            // ** string list test **********
            LinkedList<string> listString = new LinkedList<string>();

            // Insert strings and test
            listString.Append("Hello World!");
            listString.Append("This is a ");
            listString.Append("test of ");
            listString.Append("MyLinkedList<string>");

            Assert.AreEqual("Hello World!", listString.First);
            Assert.AreEqual("MyLinkedList<string>", listString.Last);
            Assert.AreEqual(4, listString.Count);
            Assert.AreEqual("Hello World!", listString.ItemAt(0));
            Assert.AreEqual("This is a ", listString.ItemAt(1));
            Assert.AreEqual("test of ", listString.ItemAt(2));
            Assert.AreEqual("MyLinkedList<string>", listString.ItemAt(3));
        }
        [TestMethod]
        public void TestGenericListOnDecimal()
        {
            // ** decimal list test ***********
            LinkedList<decimal> listDecimal = new LinkedList<decimal>();

            // Insert decimals and test
            listDecimal.Append(3.1415m); // Pi
            listDecimal.Append(1.4142m); // square root of 2
            listDecimal.Append(2.7182m); // e (Euler)
            listDecimal.Append(1.6180m); // Golden ratio

            Assert.AreEqual(3.1415m, listDecimal.First);
            Assert.AreEqual(1.6180m, listDecimal.Last);
            Assert.AreEqual(4, listDecimal.Count);
            Assert.AreEqual(3.1415m, listDecimal.ItemAt(0));
            Assert.AreEqual(1.4142m, listDecimal.ItemAt(1));
            Assert.AreEqual(2.7182m, listDecimal.ItemAt(2));
            Assert.AreEqual(1.6180m, listDecimal.ItemAt(3));
        }

    }
}
