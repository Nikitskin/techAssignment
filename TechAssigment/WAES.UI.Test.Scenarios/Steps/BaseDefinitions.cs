using Allure.Commons;
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
            Environment.SetEnvironmentVariable(
                AllureConstants.ALLURE_CONFIG_ENV_VARIABLE,
                Path.Combine(Environment.CurrentDirectory, AllureConstants.CONFIG_FILENAME));
        }
        /// <summary>
        /// Precondition to open a new clear session before each scenario
        /// </summary>
        [BeforeScenario]
        private void BeforeScenario()
        {
            string url = Settings.Default.Url;
            PageProvider = new PageProvider();
            PageProvider.Browser.Navigate().GoToUrl(url);
        }

        [BeforeStep]
        private void BeforeStep()
        {
        }

        /// <summary>
        /// After step logging
        /// </summary>
        [AfterStep]
        private void AfterStep()
        {
        }

        /// <summary>
        /// Postcondition to clear all opened browser sessions
        /// </summary>
        [AfterScenario]
        private void AfterScenario()
        {
            PageProvider.Flush();
        }

        /// <summary>
        /// One time teardown
        /// </summary>
        [AfterTestRun]
        public static void AfterTestRun()
        {
        }
    }
}
