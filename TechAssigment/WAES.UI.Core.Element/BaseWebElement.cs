using OpenQA.Selenium;
using System;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element.Interfaces;

namespace WAES.UI.Core.Element
{
    public class BaseWebElement : IBaseWebElement
    {
        private By _by;
        private IBrowser _browser;
        protected Func<IWebElement> _coreElement;

        public BaseWebElement(IBrowser browser, By by)
        {
            _by = by;
            _coreElement = () => browser.FindElement(_by);
            _browser = browser;
        }

        public string Text => _coreElement().Text;

        public bool Displayed
        {
            get
            {
                try
                {
                    return _coreElement().Displayed;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public void Click()
        {
            if(!Displayed)
            {
                throw new NoSuchElementException("Element is not displayed");
            }
            _coreElement().Click();
        }

    }
}
