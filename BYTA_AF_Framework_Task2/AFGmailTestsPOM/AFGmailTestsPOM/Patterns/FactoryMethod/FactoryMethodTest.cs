using System;
using AFGmailTestsPOM.BusinessObjects;
using AFGmailTestsPOM.Pages;
using AFGmailTestsPOM.Workflows;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;

namespace AFGmailTestsPOM.Patterns
{
    [TestFixture]
    public class FactoryMethodTest
    {
        private string UserName = Properties.Resources.userName;
        private string UserPass = Properties.Resources.userPass;
        private string HomePage = System.Configuration.ConfigurationSettings.AppSettings["HomePage"];
        static Randomizer rnd = new Randomizer();
        public string Random = rnd.GetString(10);
        private static FactoryMethod factoryDriver = new FactoryMethodFF();
        
        [SetUp]
        public void SayHello()
        {
            Console.WriteLine("Starting FactoryMethodTest...");
        }

        [TearDown]
        public void SayBye()
        {
            Console.WriteLine("Finishing FactoryMethodTest...");
        }

        [Test]
        public void FactoryMethodTestMain()
        {
            IWebDriver driver = factoryDriver.CreateDriver();
            driver.Navigate().GoToUrl(HomePage);
            LoginPage loginPage = new LoginPage(driver);
            LoginPageWf.LoginToGmail(loginPage, UserName, UserPass);
            Assert.That(driver.Url.Equals("https://mail.google.com/mail/#inbox"), "Log in failed");
            string to = UserName + "@gmail.com";
            string subj = "Test subject " + Random;
            string body = "Test mail body text: " + Random;
            Mail mail = new Mail();
            mail = mail.createMail(subj, to, body);
            MailBoxPage mailPage = new MailBoxPage(driver);
            MailBoxPageWf.CreateAndSaveNewMail(mailPage, mail);
            MailBoxPageWf.CheckDraft(mailPage, mail);
            MailBoxPageWf.SendMailAndCheck(mailPage, mail);
            MailBoxPageWf.LogOut(mailPage);
            Assert.That(driver.Title == "Gmail");
            driver.Quit();
        }
    }
}
