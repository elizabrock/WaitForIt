using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WaitForIt.Repository;
using WaitForIt;
using WaitForIt.Model;

namespace TestWaitForIt
{
    /// <summary>
    /// Summary description for EventRepositoryTest
    /// </summary>
    [TestClass]
    public class EventRepositoryTest
    {
        private static EventRepository repo;

        [ClassInitialize]
        public static void SetUp(TestContext _context)
        {
            repo = new EventRepository();
            repo.Clear();
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            repo.Clear();
            repo.Dispose();
        }
 
        [TestCleanup]
        public void ClearDatabase()
        {
            repo.Clear();
        }

        [TestMethod]
        public void TestAddToDatabase() //Valid
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new Event("New Years Eve", "12/31/2015"));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestAllMethod()
        {
            repo.Add(new Event("New Years Eve", "12/31/2015"));
            repo.Add(new Event("Valentine's Day", "02/14/2015"));
            Assert.AreEqual(2, repo.GetCount());
        }

        [TestMethod]
        public void TestGetCount()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new Event("New Years Eve", "12/31/2015"));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestClear()
        {
            repo.Add(new Event("New Years Eve", "12/31/2015"));
            repo.Clear();
            Assert.AreEqual(0, repo.GetCount());
        }
    }
}
