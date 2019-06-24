using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
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
        public static BrowserWrapper GetBrowser(BrowserTypes browserType)
        {
            switch (browserType)
            {
                case BrowserTypes.Chrome:
                    return new BrowserWrapper(GetChrome(new ChromeOptions()));
                case BrowserTypes.HeadlessChrome:
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArguments(new List<string> {
                        "--silent-launch",
                        "--no-startup-window",
                        "no-sandbox",
                        "headless"
                    });
                    return new BrowserWrapper(GetChrome(chromeOptions));

                default:
                    throw new WebDriverException("Driver type is not defined");
            }
        }

        private static ChromeDriver GetChrome(ChromeOptions options)
        {
            var driver = new ChromeDriver(Directory.GetCurrentDirectory(), options);
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return driver;
        }
    }
}
