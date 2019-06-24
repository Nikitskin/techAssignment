using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WAES.UI.Pages;

namespace WAES.UI.Test.Scenarios.Steps
{
    [Binding]
    public class BaseDefinitions
    {
        protected static PageProvider PageProvider;
        private readonly ScenarioContext context;
        private readonly static AventStack.ExtentReports.ExtentReports extentReport = new AventStack.ExtentReports.ExtentReports();
        private static ExtentHtmlReporter reporter;
        private static ExtentTest test;

        public BaseDefinitions(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        /// <summary>
        /// One time setup
        /// </summary>
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            reporter = new ExtentHtmlReporter(TestContext.CurrentContext.TestDirectory + "\\extent\\extent.html");
            extentReport.AttachReporter(reporter);

        }
        /// <summary>
        /// Precondition to open a new clear session before each scenario
        /// </summary>
        [BeforeScenario]
        private void BeforeScenario()
        {
            string url = Settings.Default.Url;
            PageProvider = new PageProvider(Settings.Default.browserType);
            PageProvider.Browser.Navigate().GoToUrl(url);
            test = extentReport.CreateTest(context.ScenarioInfo.Title);
        }

        /// <summary>
        /// Method before each step execution
        /// </summary>
        [AfterStep]
        private void AfterStep()
        {
            var status = context.ScenarioExecutionStatus == ScenarioExecutionStatus.TestError ?
                Status.Fail : Status.Info;
            test.Log(status, "Step finished : " + context.StepContext.StepInfo.Text);
        }

        /// <summary>
        /// Postcondition to clear all opened browser sessions
        /// </summary>
        [AfterScenario]
        private void AfterScenario()
        {
            switch (context.ScenarioExecutionStatus)
            {
                case ScenarioExecutionStatus.OK:
                    {
                        test.Log(Status.Pass);
                        break;
                    }
                case ScenarioExecutionStatus.TestError:
                    {
                        test.Log(Status.Fail, $"{context.TestError.Message} : {context.TestError.StackTrace}");
                        break;
                    }
            }
            extentReport.Flush();
            PageProvider.Flush();
        }
    }
}
