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
    public sealed class AddToCartFromResultsSteps : TestBase
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        
        [When("I open item details page of the first result item")]
        public void OpenItemDetailsFromResults()
        {
            MainPage mainPage = new MainPage(driver);
            ScenarioContext.Current.Add("ItemTitle", mainPage.FirstResultTitle.GetAttribute("data-mtdes"));
            mainPage.FirstResultTitle.Click();
        }

        [When("I enter (.*) in quantity and press add to cart button")]
        public void AddToCart(string quantity)
        {
            ItemDetailsPage idPage = new ItemDetailsPage(driver);
            idPage.QuantityFld.Clear();
            idPage.QuantityFld.SendKeys(quantity);
            idPage.AddToCartBtn.Click();
        }

        [Then("Shopping cart page should be opened")]
        public void IsShoppingCartOpened()
        {
            CartPage cartPage = new CartPage(driver);
            Assert.That(cartPage.ItemsInCart.Displayed);
        }

        
        [Then("Specified item should be in shopping cart")]
        public void IsItemInShoppingCart()
        {
            CartPage cartPage = new CartPage(driver);
            var ItemTitle = ScenarioContext.Current["ItemTitle"];
            var title = cartPage.AddedItemImage.GetAttribute("title");
            Assert.That(title.Equals(ItemTitle));
        }
    }
}
