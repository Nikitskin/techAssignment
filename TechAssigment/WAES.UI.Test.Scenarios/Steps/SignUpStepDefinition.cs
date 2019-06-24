using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using WAES.UI.Pages;

namespace WAES.UI.Test.Scenarios.Steps
{
    public class SignUpStepDefinition : BaseDefinitions
    {
        public SignUpStepDefinition(ScenarioContext injectedContext) : base(injectedContext)
        { }

        [Given(@"I create user with configured '(.*)', '(.*)', '(.*)', '(.*)' and '(.*)'")]
        public void GivenICreateNewUserWithAnd(string username, string password, string name, string email, DateTime birthDate)
        {
            InputFields(username, password, name, email);
            PageProvider.SignUpPage.DaySelect.SelectByText(birthDate.Day.ToString());
            PageProvider.SignUpPage.MonthSelect.SelectByText(birthDate.ToString("MMMM"));
            PageProvider.SignUpPage.YearSelect.SelectByText(birthDate.Year.ToString());
            PageProvider.SignUpPage.SubmitButton.Click();
        }

        [Given(@"I create new user with '(.*)', '(.*)', '(.*)', '(.*)' and random date")]
        public void GivenICreateNewUserWithAndRandomDate(string username, string password, string name, string email)
        {
            InputFields(username, password, name, email);
            PageProvider.SignUpPage.SetDateOfBirth();
            PageProvider.SignUpPage.SubmitButton.Click();
        }

        private void InputFields(string username, string password, string name, string email)
        {
            PageProvider.UnAuthorizedTopBar.SignUpLink.Click();
            PageProvider.SignUpPage.UserNameInput.SendKeys(username);
            PageProvider.SignUpPage.PasswordInput.SendKeys(password);
            PageProvider.SignUpPage.NameInput.SendKeys(name);
            PageProvider.SignUpPage.EmailInput.SendKeys(email);
        }

        [When(@"I click Profile link")]
        public void WhenIClickProfileLink()
        {
            PageProvider.AuthorizedTopBar.ProfileLink.Click();
        }

        [Then(@"I should be on signup page")]
        public void ThenIShouldBeOnSignupPage()
        {
            Assert.IsTrue(PageProvider.SignUpPage.NameInput.Displayed, "User should see name field");
            Assert.IsTrue(PageProvider.SignUpPage.PasswordInput.Displayed, "User should see password field");
            Assert.IsTrue(PageProvider.SignUpPage.EmailInput.Displayed, "User should see email field");
            Assert.IsTrue(PageProvider.UnAuthorizedTopBar.SignUpLink.Displayed, "User should see signup link");
            Assert.IsTrue(PageProvider.UnAuthorizedTopBar.LogInLink.Displayed, "User should see login link");
        }

        [Then(@"I see invalidity state of input fields for (.*) and (.*)")]
        public void ThenISeeInValidityStateOfInputFieldsForAnd(string input, string email)
        {
            Assert.IsFalse(bool.Parse(PageProvider.SignUpPage.EmailInput.Validity()),
                $"Email field should be in invalid for value {email}");
            Assert.IsFalse(bool.Parse(PageProvider.SignUpPage.UserNameInput.Validity()),
                $"Username field should be in invalid for value {input}");
            Assert.IsFalse(bool.Parse(PageProvider.SignUpPage.NameInput.Validity()),
                $"Name field should be in invalid for value {input}");
        }

        [Given(@"I open signup page")]
        public void GivenIOpenSignupPage()
        {
            PageProvider.UnAuthorizedTopBar.SignUpLink.Click();
        }

        [Then(@"I check date time that there is no '(.*)'")]
        public void ThenICheckDateTimeThatThereIsNo(DateTime birthDate)
        {
            var selectedDay = PageProvider.SignUpPage.DaySelect.SelectByText(birthDate.Day.ToString());
            var month = PageProvider.SignUpPage.MonthSelect.SelectByText(birthDate.ToString("MMMM"));
            Assert.AreNotEqual(birthDate.Day.ToString(), selectedDay, 
                $"User should not be able to select {birthDate.ToString("dd/MM")} in signup page");
        }

    }
}
