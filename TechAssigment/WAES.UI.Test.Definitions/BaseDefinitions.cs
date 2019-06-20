using System.Configuration;
using TechTalk.SpecFlow;
using WAES.UI.Pages;

namespace WAES.UI.Test.Definitions
{
    [Binding]
    public class BaseDefinitions
    {
        protected PageProvider PageProvider;

        [BeforeScenario]
        public void BeforeScenario()
        {
            string url = ConfigurationManager.AppSettings.Get("Url");
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
