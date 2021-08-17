using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class StackUnitTest
    {
        [TestMethod]
        public void TestStack()
        {
            // Standard queue implemented by .NET
            System.Collections.Generic.Stack<int> stdStack = new System.Collections.Generic.Stack<int>();
            // Your manually implemented ADT stack
            Stack<int> yourStack = new Stack<int>();

            // Test generates 100 random integers and adds to both queues
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                int randVal = r.Next();
                stdStack.Push(randVal);
                yourStack.Push(randVal);
            }

            // Test reading back half the added integers
            for (int i = 0; i < 50; i++)
            {
                Assert.AreEqual(stdStack.Pop(), yourStack.Pop());
                Assert.AreEqual(stdStack.Peek(), yourStack.Peek());
                Assert.AreEqual(stdStack.Count, yourStack.Count);
            }

            // Test adding 50 more random integers
            for (int i = 0; i < 50; i++)
            {
                int randVal = r.Next();
                stdStack.Push(randVal);
                yourStack.Push(randVal);
            }

            // Test reading back all the remaining values
            for (int i = 0; i < 100; i++)
            {
                Assert.AreEqual(stdStack.Peek(), yourStack.Peek());
                Assert.AreEqual(stdStack.Pop(), yourStack.Pop());
                Assert.AreEqual(stdStack.Count, yourStack.Count);
            }
        }
    }
}
