using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using WAES.UI.Core.Browser;
using WAES.UI.Core.Element.Interfaces;

namespace WAES.UI.Core.Element
{
    /// <summary>
    /// Extends BaseWebElement to cover Select element methods
    /// </summary>
    public class SelectWebElement : BaseWebElement, ISelectWebElement
    {
        private SelectElement _selectElement;

        public SelectWebElement(IBrowser browser, By by) : base(browser, by)
        {
            _selectElement = new SelectElement(coreElement());
        }

        public string SelectByText(string text)
        {
            _selectElement.SelectByText(text);
            return _selectElement.SelectedOption.Text;
        }

        public string SelectByIndex(int index)
        {
            _selectElement.SelectByIndex(index);
            return _selectElement.SelectedOption.Text;
        }

        public string SelectRandomValue()
        {
            Random rand = new Random();
            var amount = _selectElement.Options.Count;
            var randomValue = rand.Next(1, amount);
            _selectElement.SelectByIndex(randomValue);
            return _selectElement.SelectedOption.Text;
        }
    }
}
