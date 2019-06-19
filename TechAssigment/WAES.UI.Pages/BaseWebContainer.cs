using WAES.UI.Core.Browser;

namespace WAES.UI.Pages
{
    public class BaseWebContainer
    {
        protected IBrowser browserSession;

        public BaseWebContainer(IBrowser browser)
        {
            browser = browserSession;
        }
    }
}
