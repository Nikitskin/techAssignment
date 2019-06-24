using System;
using WAES.UI.Core.Browser;
using WAES.UI.CoreBrowser.BrowserFactory;
using WAES.UI.Pages.TopNavigationBar;
using WAES.UI.Pages.UserPages;

namespace WAES.UI.Pages
{
    /// <summary>
    /// List for all pages which can be called in tests
    /// </summary>
    public class PageProvider
    {
        private IBrowser _browser { get; set; }

        private BrowserTypes _browserType;

        public IBrowser Browser
        {
            get
            {
                if (_browser == null)
                {
                    _browser = BrowserFactory.GetBrowser(_browserType);
                }
                return _browser;
            }
        }

        public PageProvider(string browserType)
        {
            _browserType = (BrowserTypes) Enum.Parse(typeof(BrowserTypes), browserType, true);
        }

        public AuthorizedNavBar AuthorizedTopBar => new AuthorizedNavBar(Browser);

        public UnAuthNavBar UnAuthorizedTopBar => new UnAuthNavBar(Browser);

        public StartPage StartPage => new StartPage(Browser);

        public LoginPage LoginPage => new LoginPage(Browser);

        public SignUpPage SignUpPage => new SignUpPage(Browser);

        public DetailsPage DetailsPage => new DetailsPage(Browser);

        public ProfilePage ProfilePage => new ProfilePage(Browser);

        public void Flush()
        {
            Browser.Quit();
        }
    }
}
