using OpenQA.Selenium;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element.Interfaces;

namespace WAES.UI.Core.Element
{
    /// <summary>
    /// Extends BaseWebElement with input methods
    /// </summary>
    public class InputField : BaseWebElement, IInputField
    {
        public InputField(IBrowser browser, By by) : base(browser, by)
        { }

        public void Clear()
        {
            coreElement().SendKeys(string.Empty);
        }

        public void SendKeys(string text)
        {
            Clear();
            coreElement().SendKeys(text);
        }

        public string Validity()
        {
            return browser.ExecuteScript("return arguments[0].validity.valid", coreElement()).ToString();
        }
    }
}
