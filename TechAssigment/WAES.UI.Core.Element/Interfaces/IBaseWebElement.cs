namespace WAES.UI.Core.Element.Interfaces
{
    /// <summary>
    /// Basic web element interface
    /// </summary>
    public interface IBaseWebElement
    {
        /// <summary>
        /// Get text inside of web element
        /// </summary>
        string Text { get; }

        /// <summary>
        /// Check is element is displayed
        /// </summary>
        bool Displayed { get; }

        /// <summary>
        /// Click on found web element if exist
        /// </summary>
        void Click();
    }
}
