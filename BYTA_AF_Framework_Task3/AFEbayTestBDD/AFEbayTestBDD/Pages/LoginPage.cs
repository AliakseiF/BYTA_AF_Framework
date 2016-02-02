using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AFEbayTestBDD.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver browser) : base(browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public IWebDriver PageBrowser
        {
            get { return Browser; }
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='userid']")]
        public IWebElement LoginFld { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='pass']")]
        public IWebElement PasswordFld { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        public IWebElement LogInBtn { get; set; }

        public bool IsOpened()
        {
            if (LoginFld.Displayed) return true;
            else return false;
        }

    }
}
