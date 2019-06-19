using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using WAES.UI.Core.Browser;

namespace WAES.UI.Core.Element
{
    public class SelectWebElement : BaseWebElement, ISelectWebElement
    {
        private SelectElement _selectElement;

        public SelectWebElement(IBrowser browser, By by) : base(browser, by)
        {
            _selectElement = new SelectElement(_coreElement);
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
