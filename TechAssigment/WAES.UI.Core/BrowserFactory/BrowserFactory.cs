using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WAES.UI.CoreBrowser.BrowserFactory
{
    public static class BrowserFactory
    {
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
