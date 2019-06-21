using OpenQA.Selenium;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element.Interfaces;

namespace WAES.UI.Core.Element
{
    public class InputField : BaseWebElement, IInputField
    {
        public InputField(IBrowser browser, By by) : base(browser, by)
        { }

        public void Clear()
        {
            _coreElement.SendKeys(string.Empty);
        }

        public void SendKeys(string text)
        {
            Clear();
            _coreElement.SendKeys(text);
        }
    }
}
