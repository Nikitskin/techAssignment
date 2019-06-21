using NUnit.Framework;
using TechTalk.SpecFlow;
using WAES.UI.Pages;

namespace WAES.UI.Test.Scenarios.Steps
{
    public class LoginStepDefinitions : BaseDefinitions
    {
        public LoginStepDefinitions(ScenarioContext injectedContext) : base(injectedContext)
        { }

        [Given(@"I log in as '(.*)' into application")]
        public void GivenILogInAsIntoApplication(string username)
        {
            string password = Settings.Default[username].ToString();

            GivenIEnterAndOnLoginPage(username, password);
        }

        [When(@"I press log out link")]
        public void WhenIPressLogOutLink()
        {
            PageProvider.AuthorizedTopBar.LogOutLink.Click();
        }

        [Then(@"I should be on to login page")]
        public void ThenIShouldBeNavigatedToLoginPage()
        {
            Assert.That(PageProvider.Browser.Url.Contains("/app/login"), "User should be navigated to login page");
            Assert.IsTrue(PageProvider.LoginPage.LogInButton.Displayed, "User should see login button on login page");
            Assert.IsTrue(PageProvider.LoginPage.UserNameInput.Displayed, "User should see username text field on login page");
            Assert.IsTrue(PageProvider.LoginPage.PasswordInput.Displayed, "User should see password text field on login page");
            Assert.IsTrue(PageProvider.UnAuthorizedTopBar.LogInLink.Displayed, "User should see login link on login page");
        }

        [Given(@"I login as (.*) and (.*) on login page")]
        public void GivenIEnterAndOnLoginPage(string username, string password)
        {
            PageProvider.UnAuthorizedTopBar.LogInLink.Click();
            PageProvider.LoginPage.UserNameInput.SendKeys(username);
            PageProvider.LoginPage.PasswordInput.SendKeys(password);
            PageProvider.LoginPage.LogInButton.Click();
        }

        [Then(@"I see error with text '(.*)'")]
        public void ThenISeeErrorWithText(string errorText)
        {
            Assert.AreEqual(errorText, PageProvider.UnAuthorizedTopBar.StatusLabel.Text.Trim(),
                "Incorrect error message appeared in status bar");
        }

        [When(@"Click Profile link")]
        public void WhenClickProfileLink()
        {
            PageProvider.AuthorizedTopBar.ProfileLink.Click();
        }

        [When(@"Click Details link")]
        public void WhenClickDetailsLink()
        {
            PageProvider.AuthorizedTopBar.DetailsLink.Click();
        }

        [Then(@"I see '(.*)' in my profile")]
        public void ThenISeeInMyProfile(string profileText)
        {
            var profileInfo = PageProvider.ProfilePage.InformationSection.Text.Trim();
            Assert.That(profileInfo.Contains(profileText),
                $"Profile text should be equal to {profileText}, but was {profileInfo}");
        }

        [Then(@"I see '(.*)' and '(.*)' in details page")]
        public void ThenISeeAndAs_TesterWearewaes_ComInDetailsPage(string name, string email)
        {
            Assert.AreEqual($"Name: {name}", PageProvider.DetailsPage.NameLabel.Text.Trim(),
                $"{name} should be displayed in name field");
            Assert.AreEqual($"Email address: {email}", PageProvider.DetailsPage.EmailLabel.Text.Trim(),
                $"{email} should be displayed in email address");
        }

    }
}
