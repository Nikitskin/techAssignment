using OpenQA.Selenium;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element;

namespace WAES.UI.Pages
{
    public class TopBar : BaseWebContainer
    {
        public TopBar(IBrowser browser) : base(browser)
        { }

        public IBaseWebElement Heading => new BaseWebElement(browserSession, By.Id("home_link"));
    }
}
