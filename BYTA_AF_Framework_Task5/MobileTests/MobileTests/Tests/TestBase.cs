using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace MobileTests
{
    public class TestBase
    {
        public AndroidDriver<IWebElement> driver;

        [SetUp]
        public void InitBrowser()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("deviceName", "AF2");
            capabilities.SetCapability("app", "D:/BYTA/Framework/BYTA_AF_Framework_Task5/MobileTests/com.basecamp.bc3.apk");
            capabilities.SetCapability("appPackage", "com.basecamp.bc3");
            capabilities.SetCapability("appWaitActivity", "com.basecamp.bc3.activities.AuthChooserActivity");
            capabilities.SetCapability("unicodeKeyboard", true);
            driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
        }

        [TearDown]
        public void CloseBrowser()
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

        }
    }
}
