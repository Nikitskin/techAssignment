using OpenQA.Selenium;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element.Interfaces;

namespace WAES.UI.Core.Element
{
    public class BaseWebElement : IBaseWebElement
    {
        protected IWebElement _coreElement;
        private IBrowser _browser;

        public BaseWebElement(IBrowser browser, By by)
        {
            _coreElement = browser.FindElement(by);
            _browser = browser;
        }

        public string Text => _coreElement.Text;

        public bool Displayed => _coreElement.Displayed;

        public void Click()
        {
            if(!Displayed)
            {
                throw new NoSuchElementException("Element is not displayed");
            }
            _coreElement.Click();
        }

    }
}
