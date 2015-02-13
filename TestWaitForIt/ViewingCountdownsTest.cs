using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WaitForIt.Model;

namespace TestWaitForIt
{
    [TestClass]
    public class ViewingCountdownsTest : TestHelper
    {
        // As a user
        // In order to have hope in my life
        // I want to see the countdowns to the events that I'm looking forward to
        [ClassInitialize]
        public static void Setup(TestContext _context)
        {
            TestHelper.SetupClass(_context);
        }

        [TestInitialize]
        public void SetupTests()
        {
            GivenTheseEvents(
                new Event("Valentine's Eve", "02/13/15"),
                new Event("Christmas", "12/25/14")
                );
            TestHelper.TestPrep();
            
        }
        
        [TestCleanup]
        public void CleanUp()
        {
            TestHelper.CleanThisUp();
        }

        [TestMethod]
        public void ScenarioViewingCountdownsWhenThereAreEvents()
        {
            ThenIShouldSeeXEvents(2);
            AndIShouldSeeACountdownFor("Valentine's Eve", "02/13/15");
            AndIShouldSeeACountdownFor("Christmas", "12/25/14");
            AndIShouldNotSeeTheHelperText();
            AndTheButtonShouldBeEnabled("+");
        }
    }
}
