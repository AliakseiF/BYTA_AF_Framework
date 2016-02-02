using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using AFEbayTestBDD.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AFEbayTestBDD.Steps
{
    [Binding]
    public sealed class AddToCartFromWishListSteps : TestBase
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given("I as registered user have opened wish list page")]
        public void LogInAndOpenWishList()
        {
            driver.Navigate().GoToUrl(HomePage);
            MainPage mainPage = new MainPage(driver);
            mainPage.MyEbayLink.Click();
            LoginPage loginPage = new LoginPage(driver);
            if (loginPage.IsOpened())
            {
                loginPage.LoginFld.SendKeys(Properties.Resources.Login);
                loginPage.PasswordFld.SendKeys(Properties.Resources.Pass);
                loginPage.LogInBtn.Click();
            }
            MyEbayPage mePage = new MyEbayPage(driver);
            mePage.WishListLnk.Click();

                
        }

        [When("I press add to cart button")]
        public void AddToCart()
        {
            MyEbayPage mePage = new MyEbayPage(driver);
            ScenarioContext.Current.Add("ItemTitle", mePage.ItemTitle.GetAttribute("data-mtdes"));
            mePage.AddToCartBtn.Click();
        }
    }
}