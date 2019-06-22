using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.IO;
using TechTalk.SpecFlow;
using WAES.UI.Pages;

namespace WAES.UI.Test.Scenarios.Steps
{
    [Binding]
    public class BaseDefinitions
    {
        protected static PageProvider PageProvider;
        private readonly ScenarioContext context;
        private ExtentReports _extent;
        protected ExtentTest _test;

        public BaseDefinitions(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        /// <summary>
        /// One time setup
        /// </summary>
        [BeforeTestRun]
        public void BeforeTestRun()
        {
            try
            {
                _extent = new ExtentReports();
                var dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
                DirectoryInfo di = Directory.CreateDirectory(dir + "\\Test_Execution_Reports");
                var htmlReporter = new ExtentHtmlReporter(dir + "\\Test_Execution_Reports" + "\\Automation_Report" + ".html");
                _extent.AddSystemInfo("Environment", "Journey of Quality");
                _extent.AddSystemInfo("User Name", "Sanoj");
                _extent.AttachReporter(htmlReporter);
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// Precondition to open a new clear session before each scenario
        /// </summary>
        [BeforeScenario]
        private void BeforeScenario()
        {
            _test = _extent.CreateTest(ScenarioContext.Current.ScenarioInfo.Description);
            string url = Settings.Default.Url;
            PageProvider = new PageProvider();
            PageProvider.Browser.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// After step logging
        /// </summary>
        [AfterStep]
        private void AfterStep()
        {
            _test.Info(ScenarioContext.Current.StepContext.StepInfo.Text);
        }

        /// <summary>
        /// Postcondition to clear all opened browser sessions
        /// </summary>
        [AfterScenario]
        private void AfterScenario()
        {
            PageProvider.Flush();
            var status = ScenarioContext.Current.ScenarioExecutionStatus;
            switch (status)
            {
                case ScenarioExecutionStatus.OK:
                    {
                        _test.Log(Status.Pass);
                        break;
                    }
                case ScenarioExecutionStatus.TestError:
                    {

                        _test.Log(Status.Fail, "Test ended with " + Status.Fail + " – " + ScenarioContext.Current.TestError.Message);
                        break;
                    }
            }
        }

        /// <summary>
        /// One time teardown
        /// </summary>
        [AfterTestRun]
        public void AfterTestRun()
        {
            _extent.Flush();
        }
    }
}
