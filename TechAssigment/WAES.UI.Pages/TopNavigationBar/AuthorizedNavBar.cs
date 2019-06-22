using OpenQA.Selenium;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element;
using WAES.UI.Core.Element.Interfaces;

namespace WAES.UI.Pages.TopNavigationBar
{
    /// <summary>
    /// Page model for top navigation bar of logged in user
    /// </summary>
    public class AuthorizedNavBar : BaseWebContainer
    {
        public AuthorizedNavBar(IBrowser browser) : base(browser)
        { }

        public IBaseWebElement ProfileLink => new BaseWebElement(browserSession, By.Id("profile_link"));

        public IBaseWebElement DetailsLink => new BaseWebElement(browserSession, By.Id("details_link"));

        public IBaseWebElement LogOutLink => new BaseWebElement(browserSession, By.XPath("//a[contains(text(),'log out')]"));
    }
}
