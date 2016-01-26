using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AFGmailTestsPOM.Patterns
{
    public class FactoryMethodFF : FactoryMethod
    {
        public override IWebDriver CreateDriver()
        {
            Console.WriteLine("Create Factory FF WD");
            FirefoxProfile profile = new FirefoxProfile();
            profile.EnableNativeEvents = true;
            profile.DeleteAfterUse = true;
            IWebDriver factoryDriver = new FirefoxDriver(profile);
            factoryDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            factoryDriver.Manage().Window.Maximize();
            return factoryDriver;
        }
    }
}
