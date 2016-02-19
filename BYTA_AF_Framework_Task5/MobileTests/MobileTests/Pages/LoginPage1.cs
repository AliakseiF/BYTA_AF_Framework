using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;

namespace MobileTests.Pages
{
    public class LoginPage1 : BasePage
    {
        public LoginPage1(AndroidDriver<IWebElement> browser) : base(browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public AndroidDriver<IWebElement> PageBrowser
        {
            get { return Browser; }
        }

        [FindsBy(How = How.Id, Using = "auth_chooser_passwordless_button")]
        public IWebElement SignInBtn { get; set; }

        public void In()
        {
            SignInBtn.Click();
        }
    }
}
