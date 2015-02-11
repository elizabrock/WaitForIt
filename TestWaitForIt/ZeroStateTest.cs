using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.UIItems.WindowItems;
using TestStack.White;
using System.IO;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.Finders;

namespace TestWaitForIt
{
    [TestClass]
    public class ZeroStateTest
    {

        private static TestContext test_context;
        private static Window window;
        private static Application application;

        [ClassInitialize]
        public static void Setup(TestContext _context)
        {
            test_context = _context;
            var applicationDir = _context.DeploymentDirectory;
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\TestWaitForIt\\bin\\Debug\\WaitForIt");
            application = Application.Launch(applicationPath);
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);
        }

        [TestMethod]
        public void TestZeroStateAddButton()
        {
            Button button = window.Get<Button>("Add");
            Assert.AreEqual("+", button.Text);
        }

        [TestMethod]
        public void TestZeroStateDefaultCountdown()
        {
            ListBox countdowns = window.Get<ListBox>("CountdownList");
            Assert.AreEqual(0, countdowns.Items.Count);
            //Assert.AreEqual("New Year's Eve", countdowns.Items[0].Text);
        }

        [TestMethod]
        public void TestZeroStateHelpElements()
        {
            var text = window.Get(SearchCriteria.ByAutomationId("GettingStartedText"));
            Assert.IsTrue(text.Visible);
        }

        [ClassCleanup]
        public static void CleanThisUp()
        {
            window.Close();
            application.Close();
        }
    }
}
