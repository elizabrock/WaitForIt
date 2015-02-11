using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WaitForIt.Model;

namespace TestWaitForIt
{
    [TestClass]
    public class EventModelTest
    {
        /*
        [TestMethod]
        public void CreatingAnEventStoresItInEvents()
        {
            Event valentines = new Event("Valentine's", "02/14/14");
            CollectionAssert.Contains(Event.Events, valentines);
        }
         * */

        [TestMethod]
        public void CreatingAnEventStoresItsProperties()
        {
            Event valentines = new Event("Valentine's", "02/14/14");
            Assert.AreEqual("Valentine's", valentines.Name);
            Assert.AreEqual("02/14/14", valentines.Date);
        }
    }
}
