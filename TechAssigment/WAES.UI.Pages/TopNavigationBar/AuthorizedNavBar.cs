using OpenQA.Selenium;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element;

namespace WAES.UI.Pages.TopNavigationBar
{
    public class AuthorizedNavBar : BaseWebContainer
    {
        public AuthorizedNavBar(IBrowser browser) : base(browser)
        { }

        public IBaseWebElement ProfileLink => new BaseWebElement(browserSession, By.Id("profile_link"));

        public IBaseWebElement Details => new BaseWebElement(browserSession, By.Id("details_link"));

        public IBaseWebElement LogOut => new BaseWebElement(browserSession, By.XPath("//a[contains(text(),'log out')]"));
    }
}
