using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AFEbayTestBDD.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AFEbayTestBDD.Steps
{
    [Binding]
    public sealed class SearchSteps : TestBase
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        
        [Given("I have entered (.*) into search field")]
        public void EnterQueryIntoSearchField(string query)
        {
            driver.Navigate().GoToUrl(HomePage);
            MainPage mainPage = new MainPage(driver);
            mainPage.SearchFld.SendKeys(query);
        }

        [When("I press search button")]
        public void PressSearchButton()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.SearchBtn.Click();
        }

        [Then("The result should contain (.*) in search results")]
        public void CheckSearchResults(string query)
        {
            MainPage mainPage = new MainPage(driver);
            string expectedResult = mainPage.FirstResultTitle.Text.ToLower();
            Assert.That(expectedResult.Contains(query));
        }
    }
}
