using OpenQA.Selenium;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element;

namespace WAES.UI.Pages.UserPages
{
    public class ProfilePage : BaseWebContainer
    {
        public ProfilePage(IBrowser browser) : base(browser)
        { }

        public IBaseWebElement InformationSection => new BaseWebElement(browserSession,
            By.XPath("//section[contains(@class,'view-module')]"));
    }
}
