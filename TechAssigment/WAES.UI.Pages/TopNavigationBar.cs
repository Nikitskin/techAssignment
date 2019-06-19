using OpenQA.Selenium;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element;

namespace WAES.UI.Pages
{
    public class TopNavigationBar : TopBar
    {
        public TopNavigationBar(IBrowser browser) : base(browser)
        { }

        

        public IBaseWebElement LogIn=> new BaseWebElement(browserSession, By.Id("login_link"));

        public IBaseWebElement SignUp => new BaseWebElement(browserSession, By.Id("signup_link"));
    }
}
