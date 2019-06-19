using OpenQA.Selenium;

namespace WAES.UI.CoreBrowser
{
    public class BrowserWrapper
    {
        private IWebDriver _coreDriver;

        public BrowserWrapper (IWebDriver driver)
        {
            _coreDriver = driver;
        }

        public string Url => _coreDriver.Url;

    }
}
