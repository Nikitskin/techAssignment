using OpenQA.Selenium;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element;
using WAES.UI.Core.Element.Interfaces;

namespace WAES.UI.Pages
{
    /// <summary>
    /// Basic web model for all pages
    /// </summary>
    public class BaseWebContainer
    {
        /// <summary>
        /// Browser that will be called for element finding
        /// </summary>
        protected IBrowser browserSession;

        public BaseWebContainer(IBrowser browser)
        {
            browserSession = browser;
        }

        /// <summary>
        /// Header home link shown in all pages
        /// </summary>
        public IBaseWebElement Heading => new BaseWebElement(browserSession, By.Id("home_link"));

    }
}
