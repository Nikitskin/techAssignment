using OpenQA.Selenium;
using WAES.UI.Core.Browser;

namespace WAES.UI.Core.Element
{
    public class BaseWebElement : IBaseWebElement
    {
        protected IWebElement _coreElement;

        public BaseWebElement(IBrowser browser, By by)
        {
            _coreElement = browser.FindElement(by);
        }

        public string Text => _coreElement.Text;

        public bool Displayed => _coreElement.Displayed;

        public void Click()
        {
            _coreElement.Click();
        }

        public void Focus()
        {
            throw new System.NotImplementedException();
        }
    }
}
