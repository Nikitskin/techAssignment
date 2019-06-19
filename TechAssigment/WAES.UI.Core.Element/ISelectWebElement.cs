namespace WAES.UI.Core.Element
{
    public interface ISelectWebElement
    {
        string SelectByText(string text);
        string SelectByIndex(int index);
        string SelectRandomValue();
    }
}
