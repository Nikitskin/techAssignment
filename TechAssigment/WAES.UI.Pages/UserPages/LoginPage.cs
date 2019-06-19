using OpenQA.Selenium;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element;

namespace WAES.UI.Pages.UserPages
{
    public class LoginPage : TopNavigationBar
    {
        public LoginPage(IBrowser browser) : base(browser)
        { }

        public IBaseWebElement LogInButton => new BaseWebElement(browserSession, By.Id("login_button"));

        public IBaseWebElement UserNameInput => new BaseWebElement(browserSession, By.Id("login_button"));

        public IBaseWebElement PasswordInput => new BaseWebElement(browserSession, By.Id("login_button"));
    }
}
