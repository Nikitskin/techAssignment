using OpenQA.Selenium;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element;

namespace WAES.UI.Pages.UserPages
{
    public class DetailsPage : BaseWebContainer
    {
        public DetailsPage(IBrowser browser) : base(browser)
        { }

        public IBaseWebElement NameLabel => new BaseWebElement(browserSession,
            By.XPath("//section[contains(@class,'view-module')]//li[contains(text(),'Name')]"));

        public IBaseWebElement EmailLable => new BaseWebElement(browserSession,
            By.XPath("//section[contains(@class,'view-module')]//li[contains(text(),'Email')]"));
    }
}
