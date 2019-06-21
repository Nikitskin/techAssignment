using WAES.UI.Core.Browser;
using WAES.UI.CoreBrowser.BrowserFactory;
using WAES.UI.Pages.TopNavigationBar;
using WAES.UI.Pages.UserPages;

namespace WAES.UI.Pages
{
    public class PageProvider
    {
        private IBrowser _browser { get; set; }

        public IBrowser Browser
        {
            get
            {
                if(_browser == null)
                {
                    _browser = BrowserFactory.GetBrowser(BrowserTypes.Chrome);
                }
                return _browser;
            }
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
