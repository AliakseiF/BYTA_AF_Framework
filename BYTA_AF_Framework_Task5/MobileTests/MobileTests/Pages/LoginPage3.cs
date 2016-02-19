using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;

namespace MobileTests.Pages
{
    public class LoginPage3 : BasePage
    {
        private string login = ConfigurationSettings.AppSettings["login"];
        private string pass = ConfigurationSettings.AppSettings["password"]; 

        public LoginPage3(AndroidDriver<IWebElement> browser) : base(browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public AndroidDriver<IWebElement> PageBrowser
        {
            get { return Browser; }
        }

        //[FindsBy(How = How.Id, Using = "passwordless_email_address")]
        //public IWebElement EmailFld { get; set; }

        public void EnterPassAndSubmit()
        {
            //EmailFld.SendKeys("login");
        }
    }
}
