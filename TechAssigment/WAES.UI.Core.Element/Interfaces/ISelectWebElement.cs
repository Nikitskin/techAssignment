namespace WAES.UI.Core.Element.Interfaces
{
    public interface ISelectWebElement
    {
        string SelectByText(string text);
        string SelectByIndex(int index);
        string SelectRandomValue();
    }
}
