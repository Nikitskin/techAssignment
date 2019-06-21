using OpenQA.Selenium;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element;
using WAES.UI.Core.Element.Interfaces;

namespace WAES.UI.Pages.UserPages
{
    public class LoginPage : BaseWebContainer
    {
        public LoginPage(IBrowser browser) : base(browser)
        { }

        public IBaseWebElement LogInButton => new BaseWebElement(browserSession, By.Id("login_button"));

        public IInputField UserNameInput => new InputField(browserSession, By.Id("username_input"));

        public IInputField PasswordInput => new InputField(browserSession, By.Id("password_input"));
    }
}
