using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace AFGmailTestsPOM.Patterns
{
    public class SingletonDriver
    {
        private static IWebDriver driver;

        private SingletonDriver()
        {
        }

        public static IWebDriver getWebDriverInstance()
        {
            if (null == driver)
            {
                driver = new FirefoxDriver();
                //var prefs = new InternetExplorerOptions
                //{
                //    EnsureCleanSession = true
                //};
                //driver = new InternetExplorerDriver(prefs);
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public static void closeWebBrowser()
        {
            driver.Close();
            driver = null;
        }
    }
}
