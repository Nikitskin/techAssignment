using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace WAES.UI.Core.Browser
{
    public interface IBrowser
    {
        string Url { get; set; }
        string Title { get; }
        string CurrentWindowHandle { get; }
        ReadOnlyCollection<string> WindowHandles { get; }
        IWebElement FindElement(By by);
        ReadOnlyCollection<IWebElement> FindElements(By by);
        void Close();
        IOptions Manage();
        INavigation Navigate();
        ITargetLocator SwitchTo();
    }
}
