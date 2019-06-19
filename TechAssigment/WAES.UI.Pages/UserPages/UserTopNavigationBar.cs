using OpenQA.Selenium;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element;

namespace WAES.UI.Pages.UserPages
{
    public class UserTopNavigationBar : TopBar
    {
        public UserTopNavigationBar(IBrowser browser) : base(browser)
        { }

        public IBaseWebElement Profile => new BaseWebElement(browserSession, By.Id("profile_link"));

        public IBaseWebElement Details => new BaseWebElement(browserSession, By.Id("details_link"));

    }
}
