using WAES.UI.Core.Browser;
using WAES.UI.CoreBrowser.BrowserFactory;

namespace WAES.UI.Pages
{
    public class PageProvider
    {
        private IBrowser _browser { get; set; }

        public IBrowser Browser => _browser ?? BrowserFactory.GetBrowser(BrowserTypes.Chrome);

        public StartPage StartPage => new StartPage(Browser);
    }
}
