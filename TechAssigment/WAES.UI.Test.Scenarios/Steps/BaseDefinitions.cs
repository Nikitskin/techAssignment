using System.Configuration;
using TechTalk.SpecFlow;
using WAES.UI.Pages;

namespace WAES.UI.Test.Scenarios.Steps
{
    public class BaseDefinitions
    {
        protected PageProvider PageProvider;

        [BeforeScenario]
        public void BeforeScenario()
        {
            string url = Settings.Default.Url;
            PageProvider = new PageProvider();
            PageProvider.Browser.Navigate().GoToUrl(url);
        }
        
        [AfterScenario]
        public void AfterScenario()
        {
            PageProvider.Flush();
        }

    }
}
