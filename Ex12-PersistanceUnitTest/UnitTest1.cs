using Ex12_Persistance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ex12_PersistanceUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckIfFileIsEmpty()
        {
            // #### ACT ####
            FileHelper.ClearFile();

            // #### ASSERT ####
            Assert.AreEqual(true, FileHelper.FileEmpty());
        }

        [TestMethod]
        public void AddEntry()
        {
            // #### ACT ####
            FileHelper.ClearFile();
            FileHelper.AddEntry("Hello world!");

            // #### ASSERT ####
            Assert.AreEqual("Hello world!", FileHelper.DisplayEntry(1));
        }

        [TestMethod]
        public void RemoveEntry()
        {
            // #### ACT ####
            FileHelper.ClearFile();
            FileHelper.AddEntry("Hello world!");
            FileHelper.RemoveEntry(1);

            // #### ASSERT ####
            Assert.AreEqual(true, FileHelper.FileEmpty());
        }

        [TestMethod]
        public void UpdateEntry()
        {
            // #### ACT ####
            FileHelper.ClearFile();
            FileHelper.AddEntry("Hello world!");
            FileHelper.UpdateEntry(1, "We have updated this entry");

            // #### ASSERT ####
            Assert.AreEqual("We have updated this entry", FileHelper.DisplayEntry(1));
        }

        [TestMethod]
        public void DisplaySpecificEntry()
        {
            // #### ACT ####
            FileHelper.ClearFile();
            FileHelper.AddEntry("Do this");
            FileHelper.AddEntry("Do that");
            FileHelper.AddEntry("Do something");

            // #### ASSERT ####
            Assert.AreEqual("Do something", FileHelper.DisplayEntry(3));
        }

        [TestMethod]
        public void RemoveSpecificEntry()
        {
            // #### ACT ####
            FileHelper.ClearFile();
            FileHelper.AddEntry("Do this");
            FileHelper.AddEntry("Do nothing");
            FileHelper.AddEntry("Do that");
            FileHelper.RemoveEntry(2);

            // #### ASSERT ####
            Assert.AreEqual("Do that", FileHelper.DisplayEntry(2));
        }

        [TestMethod]
        public void UpdateSpecificEntry()
        {
            // #### ACT ####
            FileHelper.ClearFile();
            FileHelper.AddEntry("Do this");
            FileHelper.AddEntry("Do nothing");
            FileHelper.AddEntry("Do that");
            FileHelper.UpdateEntry(2, "Do everything");

            // #### ASSERT ####
            Assert.AreEqual("Do everything", FileHelper.DisplayEntry(2));
        }

        [TestMethod]
        public void AddUpdateRemoveEntries()
        {
            // #### ACT ####
            FileHelper.ClearFile();
            FileHelper.AddEntry("Do this");
            FileHelper.AddEntry("Do that");
            FileHelper.UpdateEntry(1, "Do nothing");
            FileHelper.RemoveEntry(1);
            FileHelper.AddEntry("Do everything");

            // #### ASSERT ####
            Assert.AreEqual("Do everything", FileHelper.DisplayEntry(2));
        }
    }

}
