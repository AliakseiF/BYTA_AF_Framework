using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AFEbayTestBDD.Pages
{
    public class MainPage : BasePage
    {
        public MainPage(IWebDriver browser) : base(browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public IWebDriver PageBrowser
        {
            get { return Browser; }
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='gh-ac']")]
        public IWebElement SearchFld { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[@id='gh-btn']")]
        public IWebElement SearchBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='ResultSetItems']/ul/li[1]/h3/a")]
        public IWebElement FirstResultTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='http://my.ebay.com/ws/eBayISAPI.dll?MyEbay&gbh=1']")]
        public IWebElement MyEbayLink { get; set; }
        
    }
}
