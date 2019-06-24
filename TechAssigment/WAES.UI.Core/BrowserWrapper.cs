using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace WAES.UI.Core.Browser
{
    /// <summary>
    /// Purpose of this class is to wrap core functionality of selenium webdriver
    /// and add extended functionality specified for concrete project
    /// </summary>
    public class BrowserWrapper : IBrowser
    {
        /// <summary>
        /// Selenium web driver
        /// </summary>
        private IWebDriver _coreDriver;

        public BrowserWrapper (IWebDriver driver)
        {
            _coreDriver = driver;
        }

        public string Title => _coreDriver.Title;

        public string CurrentWindowHandle => _coreDriver.CurrentWindowHandle;

        public ReadOnlyCollection<string> WindowHandles => _coreDriver.WindowHandles;

        public string Url { get => _coreDriver.Url; set => _coreDriver.Url = value; }

        public void Quit()
        {
            _coreDriver.Quit();
        }

        public IWebElement FindElement(By by)
        {
            return _coreDriver.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return _coreDriver.FindElements(by);
        }

        public IOptions Manage()
        {
            return _coreDriver.Manage();
        }

        public INavigation Navigate()
        {
            return _coreDriver.Navigate();
        }

        public ITargetLocator SwitchTo()
        {
            return _coreDriver.SwitchTo();
        }

        public object ExecuteScript(string script, params object[] args)
        {
            return ((IJavaScriptExecutor)_coreDriver).ExecuteScript(script, args);
        }

        public void TakeScreenshot(string path = "")
        {
            Screenshot ss = ((ITakesScreenshot)_coreDriver).GetScreenshot();
            string screenshot = ss.AsBase64EncodedString;
            byte[] screenshotAsByteArray = ss.AsByteArray;
            ss.SaveAsFile(path + ".png");
        }
    }
}
