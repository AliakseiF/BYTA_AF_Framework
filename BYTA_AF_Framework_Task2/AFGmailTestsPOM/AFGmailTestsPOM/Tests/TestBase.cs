using System;
using System.ComponentModel;
using AFGmailTestsPOM.Patterns;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;


namespace AFGmailTestsPOM.Tests
{
    public class TestBase
    {
        //public static IWebDriver driver = new FirefoxDriver();
        //public string Username = "BYTAAFTestUser";
        //public string Userpass = "BYTAAFTestUser1";
        //public string Homepage = "https://gmail.com/";

        public string UserName = Properties.Resources.userName;
        public string UserPass = Properties.Resources.userPass;
        //public string HomePage = Properties.Resources.homepage;

        //Using App.config
        public string HomePage = System.Configuration.ConfigurationSettings.AppSettings["HomePage"];

        static Randomizer rnd = new Randomizer();
        public string Random = rnd.GetString(10);

        public static IWebDriver driver;
        
        [SetUp]
        public void InitBrowser()
        {
            //DesiredCapabilities capabilities = new DesiredCapabilities();
            //capabilities = DesiredCapabilities.InternetExplorer();
            //capabilities.SetCapability(CapabilityType.BrowserName, "internet explorer");
            //capabilities = DesiredCapabilities.Firefox();
            //capabilities.SetCapability(CapabilityType.BrowserName, "firefox");
            //driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);

            //Using App.config
            string browserName = System.Configuration.ConfigurationSettings.AppSettings["BrowserName"].ToLower();
            if (browserName == "ff")
            {
                driver = new FirefoxDriver();
            }
            else
            {
                driver = new InternetExplorerDriver();
            }
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            driver.Manage().Window.Maximize();

        }

        public static void WaitForElement(IWebDriver browser,IWebElement element)
        {
            new WebDriverWait(browser, TimeSpan.FromSeconds(20)).Until(e => element.Enabled && element.Displayed);
        }

        public static void WaitForTab(IWebDriver browser, string text)
        {
            new WebDriverWait(browser, TimeSpan.FromSeconds(20)).Until(b => browser.Url.EndsWith(text));
        }
    }
}
