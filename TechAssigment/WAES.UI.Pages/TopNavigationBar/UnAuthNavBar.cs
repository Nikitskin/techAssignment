using OpenQA.Selenium;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element;
using WAES.UI.Core.Element.Interfaces;

namespace WAES.UI.Pages.TopNavigationBar
{
    public class UnAuthNavBar : BaseWebContainer
    {
        public UnAuthNavBar(IBrowser browser) : base(browser)
        { }

        public IBaseWebElement LogInLink => new BaseWebElement(browserSession, By.Id("login_link"));

        public IBaseWebElement SignUpLink => new BaseWebElement(browserSession, By.Id("signup_link"));

        public IBaseWebElement StatusLabel => new BaseWebElement(browserSession, By.Id("status"));
    }
}
