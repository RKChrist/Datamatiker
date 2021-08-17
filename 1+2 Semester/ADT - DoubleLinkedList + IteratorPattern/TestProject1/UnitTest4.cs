using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ADT;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class UnitTest5
    {
        ClubMember c1, c2, c3, c4, c5;
        LinkedList<ClubMember> list;

        [TestInitialize]
        public void Init()
        {
            list = new LinkedList<ClubMember>();

            c1 = new ClubMember
            {
                Id = 1,
                FirstName = "Anders",
                LastName = "And",
                Gender = Gender.Male,
                Age = 15
            };
            c2 = new ClubMember
            {
                Id = 2,
                FirstName = "Bjørn",
                LastName = "Borg",
                Gender = Gender.Male,
                Age = 30
            };
            c3 = new ClubMember
            {
                Id = 3,
                FirstName = "Cristian",
                LastName = "Nielsen",
                Gender = Gender.Male,
                Age = 20
            };
            c4 = new ClubMember
            {
                Id = 4,
                FirstName = "Kurt",
                LastName = "Nielsen",
                Gender = Gender.Male,
                Age = 33
            };
            c5 = new ClubMember
            {
                Id = 5,
                FirstName = "Lis",
                LastName = "Sørensen",
                Gender = Gender.Female,
                Age = 18
            };
        }
        [TestMethod]
        public void TestRoundtripString()
        {
            list.Insert(c3);
            list.Insert(c2);
            list.Insert(c1);
            Assert.AreEqual(3, list.Count);
            Assert.AreEqual("1: Anders And (Male, 15 years)\n2: Bjørn Borg (Male, 30 years)\n3: Cristian Nielsen (Male, 20 years)\n2: Bjørn Borg (Male, 30 years)\n1: Anders And (Male, 15 years)", list.RoundtripString());
        }
        [TestMethod]
        public void TestReverse1()
        {
            list.Insert(c1);
            list.Reverse();
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("1: Anders And (Male, 15 years)", list.ToString());
        }
        [TestMethod]
        public void TestReverse2()
        {
            list.Insert(c1);
            list.Insert(c2);
            list.Reverse();
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual("1: Anders And (Male, 15 years)\n2: Bjørn Borg (Male, 30 years)", list.ToString());
        }
        [TestMethod]
        public void TestReverse3()
        {
            list.Insert(c1);
            list.Insert(c2);
            list.Insert(c3);
            list.Reverse();
            Assert.AreEqual(3, list.Count);
            Assert.AreEqual("1: Anders And (Male, 15 years)\n2: Bjørn Borg (Male, 30 years)\n3: Cristian Nielsen (Male, 20 years)", list.ToString());
        }
        [TestMethod]
        public void TestReverse4()
        {
            list.Insert(c1);
            list.Insert(c2);
            list.Insert(c3);
            list.Insert(c4);
            list.Reverse();
            Assert.AreEqual(4, list.Count);
            Assert.AreEqual("1: Anders And (Male, 15 years)\n2: Bjørn Borg (Male, 30 years)\n3: Cristian Nielsen (Male, 20 years)\n4: Kurt Nielsen (Male, 33 years)", list.ToString());
        }
        [TestMethod]
        public void TestSwap()
        {
            list.Insert(c3);
            list.Insert(c1);
            list.Insert(c2); // c2, c1, c3
            list.Swap(1); // c2, c3, c1
            Assert.AreEqual(3, list.Count);
            Assert.AreEqual("2: Bjørn Borg (Male, 30 years)\n3: Cristian Nielsen (Male, 20 years)\n1: Anders And (Male, 15 years)", list.ToString());

            list.Swap(0); // c3, c2, c1
            Assert.AreEqual("3: Cristian Nielsen (Male, 20 years)\n2: Bjørn Borg (Male, 30 years)\n1: Anders And (Male, 15 years)", list.ToString());
        }

       

    }
}
