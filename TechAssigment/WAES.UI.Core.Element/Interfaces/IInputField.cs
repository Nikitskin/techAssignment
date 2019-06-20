namespace WAES.UI.Core.Element.Interfaces
{
    public interface IInputField : IBaseWebElement
    {
        void Clear();

        void SendKeys(string text);
    }
}
