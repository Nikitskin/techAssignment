using OpenQA.Selenium;
using WAES.UI.Core.Browser;

namespace WAES.UI.Core.Element
{
    public class BaseWebElement : IBaseWebElement
    {
        private IWebElement _coreElement;

        public BaseWebElement(IBrowser browser, By by)
        {
            _coreElement = browser.FindElement(by);
        }

        public string Text => _coreElement.Text;

        public bool Displayed => _coreElement.Displayed;

        public void Clear()
        {
            _coreElement.Clear();
        }

        public void Click()
        {
            _coreElement.Click();
        }

        public void Focus()
        {
            throw new System.NotImplementedException();
        }

        public void SendKeys(string text)
        {
            _coreElement.Clear();
            _coreElement.SendKeys(text);
        }
    }
}
