using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WaitForIt.Model;
using TestStack.White.UIItems.WindowItems;
using TestStack.White;
using System.IO;
using System.Reflection;
using TestStack.White.Factory;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.Finders;
using WaitForIt.Repository;
using WaitForIt;
using System.Windows.Automation;
using TestStack.White.UIItems;

namespace TestWaitForIt
{
    public class TestHelper
    {
        private static TestContext test_context;
        protected static Window window;
        private static Application application;
        private static EventRepository repo = new EventRepository();
        private static EventContext context;

        public static void Setup(TestContext _context)
        {
            test_context = _context;
            
            var applicationDir = _context.DeploymentDirectory;
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\TestWaitForIt\\bin\\Debug\\WaitForIt");

            application = Application.Launch(applicationPath);
            
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);
            context = repo.Context();
        }

        public void AndIShouldSeeAnErrorMessage(string p)
        {
            throw new NotImplementedException();
        }

        public void AndIShouldSeeTheHelperText()
        {
            var text = window.Get(SearchCriteria.ByAutomationId("GettingStartedText"));
            Assert.IsTrue(text.Visible);
        }

        public void ThenIShouldSeeXEvents(int expected)
        {
            Assert.IsNotNull(window);
            SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("CountdownList").AndIndex(0);
            ListBox list_box = (ListBox)window.Get(searchCriteria);
            Assert.AreEqual(expected, list_box.Items.Count);
        }

        public void AndIShouldSeeXEvents(int p)
        {
            throw new NotImplementedException();
        }

        public void AndTheButtonShouldBeEnabled(string buttonContent)
        {
            Button button = window.Get<Button>(SearchCriteria.ByText(buttonContent));
            Assert.IsTrue(button.Enabled);
        }

        public void AndTheButtonShouldBeDisabled(string buttonContent)
        {
            Button button = window.Get<Button>(SearchCriteria.ByText(buttonContent));
            Assert.IsFalse(button.Enabled);
        }

        public void AndIShouldSeeACountdownFor(string p1, string p2)
        {
            var e = repo.GetByDate(p2);
            Assert.IsNotNull(window);
            SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("CountdownList").AndIndex(0);
            ListBox list_box = (ListBox)window.Get(searchCriteria);
            var item = list_box.Items.Find(i => i.Text == p1);
            Assert.AreEqual(p1, item.Text);
           
        }

        public void ThenIShouldNotSeeTheEventForm()
        {
            throw new NotImplementedException();
        }

        public void AndIClick(string p)
        {
            throw new NotImplementedException();
        }

        public void AndIChooseTheEventDate(string p)
        {
            throw new NotImplementedException();
        }

        public void WhenIFillInEventTitleWith(string p)
        {
            throw new NotImplementedException();
        }

        public void AndTheEventDateShouldBe30DaysFromNow()
        {
            throw new NotImplementedException();
        }

        public void AndIShouldNotSeeTheHelperText()
        {
            var text = window.Get(SearchCriteria.ByAutomationId("GettingStartedText"));
            Assert.IsFalse(text.Visible);
        }

        public void ThenIShouldSeeTheEventForm()
        {
            throw new NotImplementedException();
        }

        public void WhenIClick(string p)
        {
            throw new NotImplementedException();
        }

        public void ThenIShouldSeeACountdownFor(string p1, string p2)
        {
            throw new NotImplementedException();
        }

        public void GivenThereAreNoEvents()
        {
            Assert.AreEqual(0,repo.GetCount());
        }

        public static void GivenTheseEvents(params Event[] events)
        {
            foreach (Event evnt in events)
            {
                // Add event to Events here.
                repo.Add(evnt);
            }
            
            //context.SaveChanges();
            Assert.AreEqual(events.Length, repo.GetCount());
        }

        public static void CleanThisUp()
        {
            window.Close();
            application.Close();
            repo.Clear();
        }
    }
}
