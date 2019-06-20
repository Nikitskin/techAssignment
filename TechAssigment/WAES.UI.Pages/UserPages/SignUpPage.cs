using OpenQA.Selenium;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element;
using WAES.UI.Core.Element.Interfaces;

namespace WAES.UI.Pages.UserPages
{
    public class SignUpPage : BaseWebContainer
    {
        public SignUpPage(IBrowser browser) : base(browser)
        { }

        public IInputField UserNameInput => new InputField(browserSession, By.Id("username_input"));

        public IInputField PasswordInput => new InputField(browserSession, By.Id("password_input"));

        public IInputField NameInput => new InputField(browserSession, By.Id("name_input"));

        public IInputField EmailInput => new InputField(browserSession, By.Id("email_input"));

        public ISelectWebElement DaySelect => new SelectWebElement(browserSession, By.Id("day_select"));

        public ISelectWebElement MonthSelect => new SelectWebElement(browserSession, By.Id("month_select"));

        public ISelectWebElement YearSelect => new SelectWebElement(browserSession, By.Id("year_select"));

        public IBaseWebElement SubmitButton => new BaseWebElement(browserSession, By.Id("submit_button"));

        public void SetDateOfBirth()
        {
            DaySelect.SelectRandomValue();
            MonthSelect.SelectRandomValue();
            YearSelect.SelectRandomValue();
        }
        
    }
}
