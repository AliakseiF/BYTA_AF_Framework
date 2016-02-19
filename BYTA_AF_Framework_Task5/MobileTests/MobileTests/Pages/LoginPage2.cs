using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;

namespace MobileTests.Pages
{
    public class LoginPage2 : BasePage
    {
        private string login = ConfigurationSettings.AppSettings["login"];
        
        public LoginPage2(AndroidDriver<IWebElement> browser) : base(browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public AndroidDriver<IWebElement> PageBrowser
        {
            get { return Browser; }
        }

        [FindsBy(How = How.Id, Using = "passwordless_email_address")]
        public IWebElement EmailFld { get; set; }

        public void EnterEmailAndSubmit()
        {
            EmailFld.SendKeys(login);

        //can't submit entered login by 'enter' device system button

            //Browser.HideKeyboard(HideKeyboardStrategy.Press_key,"Done");
            //Browser.KeyEvent(AndroidKeyCode.Keycode_ENTER);
            //Browser.KeyEvent(AndroidKeyCode.Enter);
            //Browser.KeyEvent(66);
            //Browser.Keyboard.SendKeys(Keys.Enter);
        }
    }
}
