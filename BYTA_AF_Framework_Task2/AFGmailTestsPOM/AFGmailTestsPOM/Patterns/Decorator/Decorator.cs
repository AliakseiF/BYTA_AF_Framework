using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace AFGmailTestsPOM.Patterns
{
    public class Decorator : IWebDriver
    {
        protected IWebDriver decoratorDriver;

        public Decorator(IWebDriver driver)
        {
            this.decoratorDriver = driver;
            decoratorDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            decoratorDriver.Manage().Window.Maximize();
        }

        public IWebElement FindElement(By by)
        {
            Console.WriteLine("Looking for element with locator: " + by);
            return decoratorDriver.FindElement(by);
        }

        public INavigation Navigate()
        {
            Console.WriteLine("Navigate to new page.. ");
            return decoratorDriver.Navigate();
        }

        public string CurrentWindowHandle
        {
            get
            {
                return decoratorDriver.CurrentWindowHandle;
            }
        }

        public string PageSource
        {
            get
            {
                return decoratorDriver.PageSource;
            }
        }

        public string Title
        {
            get
            {
                Console.WriteLine("Taking page title...");
                return decoratorDriver.Title;
            }
        }

        public string Url
        {
            get
            {
                return decoratorDriver.Url;
            }

            set
            {
                decoratorDriver.Url = value;
            }
        }

        public ReadOnlyCollection<string> WindowHandles
        {
            get
            {
                return decoratorDriver.WindowHandles;
            }
        }

        public void Close()
        {
            Console.WriteLine("Closing WD...");
            decoratorDriver.Close();
        }

        public void Dispose()
        {
            decoratorDriver.Dispose();
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            Console.WriteLine("Looking for elements with locator: " + by);
            return decoratorDriver.FindElements(by);
        }

        public IOptions Manage()
        {
            Console.WriteLine("Setting WD options...");
            return decoratorDriver.Manage();
        }
        
        public void Quit()
        {
            Console.WriteLine("Quit WD...");
            decoratorDriver.Quit();
        }

        public ITargetLocator SwitchTo()
        {
            return decoratorDriver.SwitchTo();
        }
    }
}
