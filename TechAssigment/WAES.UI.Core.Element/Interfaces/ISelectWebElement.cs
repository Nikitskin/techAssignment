namespace WAES.UI.Core.Element.Interfaces
{
    /// <summary>
    /// Interface for dropdown web elements
    /// </summary>
    public interface ISelectWebElement
    {
        /// <summary>
        /// Selects value by text
        /// </summary>
        /// <param name="text">Text that should be equal to select ones</param>
        /// <returns>Selected text</returns>
        string SelectByText(string text);

        /// <summary>
        /// Select by index
        /// </summary>
        /// <param name="index">Index of selecte element</param>
        /// <returns>Text of selected option</returns>
        string SelectByIndex(int index);

        /// <summary>
        /// Select random value from all options
        /// </summary>
        /// <returns>Text of selected value</returns>
        string SelectRandomValue();
    }
}
