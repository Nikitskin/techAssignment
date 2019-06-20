using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WAES.UI.Core.Browser;

namespace WAES.UI.CoreBrowser.BrowserFactory
{
    public static class BrowserFactory
    {
        /// <summary>
        /// Generate browser instance of required browser type
        /// </summary>
        /// <param name="browserType">Browser enumeration which should be created</param>
        /// <returns>Browser wrapper instance that covers browser functionality</returns>
        public static BrowserWrapper GetBrowser (BrowserTypes browserType)
        {
            IWebDriver driver;

            switch (browserType)
            {
                case BrowserTypes.Chrome:
                    driver = new ChromeDriver();
                    driver.Manage().Cookies.DeleteAllCookies();
                    driver.Manage().Window.FullScreen();
                    return new BrowserWrapper(driver);
                default:
                    throw new WebDriverException("Driver type is not defined");
            }

        }
    }
}
