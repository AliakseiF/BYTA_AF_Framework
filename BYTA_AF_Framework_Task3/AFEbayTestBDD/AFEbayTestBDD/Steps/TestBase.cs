using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using TechTalk.SpecFlow;

namespace AFEbayTestBDD
{
    [Binding]
    public class TestBase
    {
        public string HomePage = System.Configuration.ConfigurationSettings.AppSettings["HomePage"];
        public static IWebDriver driver;

        [BeforeScenario()]
        public static void InitBrowser()
        {
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

        [AfterScenario()]
        public static void CloseBrowser()
        {

            try
            {
                driver.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                driver = null;
            }

            //public static void WaitForElement(IWebDriver browser, IWebElement element)
            //{
            //    new WebDriverWait(browser, TimeSpan.FromSeconds(20)).Until(e => element.Enabled && element.Displayed);
            //}

            //public static void WaitForTab(IWebDriver browser, string text)
            //{
            //    new WebDriverWait(browser, TimeSpan.FromSeconds(20)).Until(b => browser.Url.EndsWith(text));
            //}
        }
    }
}
