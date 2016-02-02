using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AFEbayTestBDD.Pages
{
    public class MyEbayPage : BasePage
    {
        public MyEbayPage(IWebDriver browser) : base(browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public IWebDriver PageBrowser
        {
            get { return Browser; }
        }

        //have no idea or another way to catch this element :(
        [FindsBy(How = How.XPath, Using = "html/body/div[3]/div[2]/div[2]/div[2]/div[2]/ul/li[3]/a")]
        public IWebElement WishListLnk { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[starts-with(@id,'ttl_')]")]
        public IWebElement ItemTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[starts-with(@id,'AddItem')]")]
        public IWebElement AddToCartBtn { get; set; }


    }
}
