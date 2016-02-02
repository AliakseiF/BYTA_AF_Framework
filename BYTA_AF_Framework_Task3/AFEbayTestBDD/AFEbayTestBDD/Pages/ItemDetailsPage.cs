using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AFEbayTestBDD.Pages
{
    public class ItemDetailsPage : BasePage
    {
        public ItemDetailsPage(IWebDriver browser) : base(browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public IWebDriver PageBrowser
        {
            get { return Browser; }
        }

        [FindsBy(How = How.Id, Using = "itemTitle")]
        public IWebElement ItemTitle { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//a[@id='isCartBtn_btn']")]
        public IWebElement AddToCartBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='qtyTextBox']")]
        public IWebElement QuantityFld { get; set; }
    }
}
