using WAES.UI.Core.Browser;
using WAES.UI.CoreBrowser.BrowserFactory;
using WAES.UI.Pages.TopNavigationBar;

namespace WAES.UI.Pages
{
    public class PageProvider
    {
        private IBrowser _browser { get; set; }

        public IBrowser Browser => _browser ?? BrowserFactory.GetBrowser(BrowserTypes.Chrome);

        public AuthorizedNavBar AuthorizedTopBar => new AuthorizedNavBar(Browser);

        public UnAuthNavBar UnAuthorizedTopBar => new UnAuthNavBar(Browser);

        public StartPage StartPage => new StartPage(Browser);
    }
}
