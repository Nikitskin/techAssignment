using OpenQA.Selenium;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element;
using WAES.UI.Core.Element.Interfaces;

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
