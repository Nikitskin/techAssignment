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
        /// Precondition to open a new clear session before each scenario
        /// </summary>
        [BeforeScenario]
        private void BeforeScenario()
        {
            string url = Settings.Default.Url;
            PageProvider = new PageProvider();
            PageProvider.Browser.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Postcondition to clear all opened browser sessions
        /// </summary>
        [AfterScenario]
        private void AfterScenario()
        {
            PageProvider.Flush();
        }
    }
}
