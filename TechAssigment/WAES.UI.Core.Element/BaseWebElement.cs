using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace WAES.UI.Core.Element
{
    public class BaseWebElement : IBaseWebElement
    {
        private IWebElement _coreElement;

        public BaseWebElement()
        {
            _coreElement = new RemoteWebElement();
        }

        public BaseWebElement(IWebElement element)
        {
            _coreElement = element;
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
