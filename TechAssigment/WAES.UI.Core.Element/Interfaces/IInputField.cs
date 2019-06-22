namespace WAES.UI.Core.Element.Interfaces
{
    /// <summary>
    /// Basic interface for input type fields
    /// </summary>
    public interface IInputField : IBaseWebElement
    {
        /// <summary>
        /// Clear input field from text
        /// </summary>
        void Clear();

        /// <summary>
        /// Send text into input field
        /// </summary>
        /// <param name="text">Text that should be sent into input field</param>
        void SendKeys(string text);

        /// <summary>
        /// Check does input field display invalid input event 
        /// </summary>
        /// <returns>True if inputed text validated correctly</returns>
        string Validity();
    }
}
