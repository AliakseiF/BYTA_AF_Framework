using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace MobileTests.Pages
{
    public class BasePage
    {
        private readonly AndroidDriver<IWebElement> _browser;

        protected AndroidDriver<IWebElement> Browser
        {
            get { return _browser; }
        }

        public BasePage(AndroidDriver<IWebElement> browser)
        {
            _browser = browser;
        }
    }
}
