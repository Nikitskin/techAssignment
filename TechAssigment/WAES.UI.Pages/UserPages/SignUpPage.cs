using OpenQA.Selenium;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element;

namespace WAES.UI.Pages.UserPages
{
    public class SignUpPage : BaseWebContainer
    {
        public SignUpPage(IBrowser browser) : base(browser)
        { }

        public IBaseWebElement UserNameInput => new BaseWebElement(browserSession, By.Id("username_input"));

        public IBaseWebElement PasswordInput => new BaseWebElement(browserSession, By.Id("password_input"));

        public IBaseWebElement NameInput => new BaseWebElement(browserSession, By.Id("name_input"));

        public IBaseWebElement EmailInput => new BaseWebElement(browserSession, By.Id("email_input"));

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
