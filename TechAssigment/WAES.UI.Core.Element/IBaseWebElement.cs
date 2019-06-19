namespace WAES.UI.Core.Element
{
    public interface IBaseWebElement
    {
        string Text { get; }

        void Focus();

        bool Displayed { get; }

        void Click();
    }
}
