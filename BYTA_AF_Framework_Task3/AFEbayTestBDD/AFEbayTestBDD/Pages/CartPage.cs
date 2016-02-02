using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AFEbayTestBDD.Pages
{
    public class CartPage : BasePage
    {
        public CartPage(IWebDriver browser) : base(browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public IWebDriver PageBrowser
        {
            get { return Browser; }
        }

        [FindsBy(How = How.Id, Using = "ShopCart")]
        public IWebElement ItemsInCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='imganchor']")]
        public IWebElement AddedItemImage { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@id='gh-cart-n']")]
        public IWebElement ItemsInCartCount { get; set; }
        
    }
}
