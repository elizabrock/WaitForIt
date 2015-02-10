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
 

        [TestMethod]
        public void TestAddToDatabase()
        {
            
            EventRepository repo = new EventRepository();
            repo.GetDbSet().Add(new Event("New Years Eve", "12/31/2015"));
            Assert.AreEqual(1, repo.GetDbSet().Local.Count);
            
        }

        [TestMethod]
        public void TestAllMethod()
        {
            EventRepository repo = new EventRepository();
            LinkedList<Event> list = new LinkedList<Event>();
            
            list.AddLast(new Event("New Years Eve", "12/31/2015"));
            list.AddLast(new Event("Valentine's Day", "02/14/2015"));
            repo.Add(new Event("New Years Eve", "12/31/2015"));
            repo.Add(new Event("Valentine's Day", "02/14/2015"));
            Assert.AreEqual(list,repo);
        }

        [TestMethod]
        public void TestGetCount()
        {
            EventRepository repo = new EventRepository();
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new Event("New Years Eve", "12/31/2015"));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestClear()
        {
            EventRepository repo = new EventRepository();
            repo.Add(new Event("New Years Eve", "12/31/2015"));
            repo.Clear();
            Assert.AreEqual(0, repo.GetCount());
        }
    }
}
