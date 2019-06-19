using WAES.UI.Core.Browser;
using WAES.UI.Core.Element;

namespace WAES.UI.Pages
{
    public class BaseWebContainer
    {
        protected IBrowser browserSession;

        public BaseWebContainer(IBrowser browser)
        {
            browser = browserSession;
        }

        public IBaseWebElement Heading => new BaseWebElement(browserSession, By.Id("home_link"));

    }
}
