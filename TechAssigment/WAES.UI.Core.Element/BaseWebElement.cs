using OpenQA.Selenium;
using System;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element.Interfaces;

namespace WAES.UI.Core.Element
{
    /// <summary>
    /// Wraps Selenium's IWebElement and extends it's functionality
    /// </summary>
    public class BaseWebElement : IBaseWebElement
    {
        private By _by;
        protected IBrowser browser;
        protected Func<IWebElement> coreElement;

        public BaseWebElement(IBrowser browser, By by)
        {
            _by = by;
            coreElement = () => browser.FindElement(_by);
            this.browser = browser;
        }

        public string Text => coreElement().Text;

        public bool Displayed
        {
            get
            {
                try
                {
                    return coreElement().Displayed;
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
            coreElement().Click();
        }

    }
}
