namespace WAES.UI.Core.Element.Interfaces
{
    public interface IBaseWebElement
    {
        string Text { get; }

        bool Displayed { get; }

        void Click();
    }
}
