using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex_14Sorting;

namespace Ex14_ArraySorting.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SockMarchantTest1()
        {
            int[] arr = { 10, 10, 20, 20, 30, 30, 40, 40, 50 };
            Assert.AreEqual(4, Program.SockMerchant(arr));
        }

        [TestMethod]
        public void SockMarchantTest2()
        {
            int[] arr = { 40, 20, 10, 20, 30, 40, 40, 30, 40 };
            Assert.AreEqual(4, Program.SockMerchant(arr));
        }

        [TestMethod]
        public void SockMarchantTest3()
        {
            int[] arr = { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3, 1, 3, 4, 5, 4, 3, 7, 5, 4, 9, 1, 2 };
            Assert.AreEqual(9, Program.SockMerchant(arr));
        }

    }
}
