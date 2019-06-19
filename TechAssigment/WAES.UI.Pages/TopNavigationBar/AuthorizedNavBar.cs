using OpenQA.Selenium;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element;

namespace WAES.UI.Pages.TopNavigationBar
{
    public class AuthorizedNavBar : BaseWebContainer
    {
        public AuthorizedNavBar(IBrowser browser) : base(browser)
        {
        }

        public IBaseWebElement Profile => new BaseWebElement(browserSession, By.Id("home_link"));

        public IBaseWebElement Details => new BaseWebElement(browserSession, By.Id("home_link"));

        public IBaseWebElement LogOut => new BaseWebElement(browserSession, By.Id("home_link"));
    }
}
