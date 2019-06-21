using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace WAES.UI.Core.Browser
{
    public interface IBrowser
    {
        /// <summary>
        ///   Gets or sets the URL the browser is currently displaying.
        /// </summary>
        string Url { get; set; }

        /// <summary>
        ///  Gets the title of the current browser window.
        /// </summary>
        string Title { get; }

        /// <summary>
        ///  Gets the current window handle, which is an opaque handle to this window that
        ///     uniquely identifies it within this driver instance.
        /// </summary>
        string CurrentWindowHandle { get; }

        /// <summary>
        ///   Gets the window handles of open browser windows.
        /// </summary>
        ReadOnlyCollection<string> WindowHandles { get; }

        /// <summary>
        /// Searches specific element inside page source
        /// </summary>
        /// <param name="by">Search by specified parameters</param>
        /// <returns>Web element that was found</returns>
        IWebElement FindElement(By by);

        /// <summary>
        /// Searches specific elements inside page source
        /// </summary>
        /// <param name="by">Search by specified parameters</param>
        /// <returns>Collection of found elements</returns>
        ReadOnlyCollection<IWebElement> FindElements(By by);

        /// <summary>
        /// Quits this driver, closing every associated window.
        /// </summary>
        void Quit();

        /// <summary>
        ///  Instructs the driver to change its settings.
        /// </summary>
        /// <returns> An OpenQA.Selenium.IOptions object allowing the user to change the settings of
        ///     the driver.</returns>
        IOptions Manage();

        /// <summary>
        ///  Instructs the driver to navigate the browser to another location.
        /// </summary>
        /// <returns>An OpenQA.Selenium.INavigation object allowing the user to access the browser's
        ///     history and to navigate to a given URL.</returns>
        INavigation Navigate();

        /// <summary>
        /// Instructs the driver to send future commands to a different frame or window.
        /// </summary>
        /// <returns> An OpenQA.Selenium.ITargetLocator object which can be used to select a frame
        ///     or window.</returns>
        ITargetLocator SwitchTo();

        /// <summary>
        /// Executes configured javascript on driver
        /// </summary>
        /// <param name="script">Script to execute</param>
        /// <returns>Retunrs response on script from browser</returns>
        object ExecuteScript(string script, params object[] args);
    }
}
