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
    public class SingletonDriverTest
    {
        private string UserName = Properties.Resources.userName;
        private string UserPass = Properties.Resources.userPass;
        private string HomePage = System.Configuration.ConfigurationSettings.AppSettings["HomePage"];
        static Randomizer rnd = new Randomizer();
        public string Random = rnd.GetString(10);
        private IWebDriver driver;


        [SetUp]
        public void SayHello()
        {
            Console.WriteLine("Starting singleton test...");
        }

        [TearDown]
        public void SayBye()
        {
            Console.WriteLine("Finishing singleton test...");
        }

        [Test]
        public void SingletonDriverTest1()
        {
            driver = SingletonDriver.getWebDriverInstance();
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
        }

        [Test]
        public void SingletonDriverTest2()
        {
            driver = SingletonDriver.getWebDriverInstance();
            driver.Navigate().GoToUrl("http://tut.by");
            Assert.That(driver.Title == "Белорусский портал TUT.BY");
            Console.WriteLine("test2 passed!");
            SingletonDriver.closeWebBrowser();
        }
    }
}
