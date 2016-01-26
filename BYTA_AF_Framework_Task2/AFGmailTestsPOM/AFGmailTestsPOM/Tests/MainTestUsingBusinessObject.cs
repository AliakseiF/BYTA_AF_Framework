//using System;
//using System.Threading;
//using AFGmailTestsPOM.BusinessObjects;
//using AFGmailTestsPOM.Pages;
//using AFGmailTestsPOM.Patterns;
//using AFGmailTestsPOM.Workflows;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Remote;

////copy of maintest for selenium grid task execution
//namespace AFGmailTestsPOM.Tests
//{
//    [TestFixture]
//    //[Parallelizable]
//    public class MainTestUsingBusinessObject : TestBase
//    {
//        //private IWebDriver driver;
//        [SetUp]
//        public void SayHello()
//        {
//            Console.WriteLine("Starting gmail test...");
//            driver.Navigate().GoToUrl(HomePage);
//        }

//        [TearDown]
//        public void SayBye()
//        {
//            Console.WriteLine("Finishing gmail test...");
//            driver.Quit();
//        }

//        [Test]
//        public void MainGmailTestBO()
//        {
//            LoginPage loginPage = new LoginPage(driver);
//            LoginPageWf.LoginToGmail(loginPage, UserName, UserPass);
//            Assert.That(driver.Url.Equals("https://mail.google.com/mail/#inbox"), "Log in failed");
//            string to = UserName + "@gmail.com";
//            string subj = "Test subject " + Random;
//            string body = "Test mail body text: " + Random;
//            Mail mail = new Mail();
//            mail = mail.createMail(subj, to, body);
//            MailBoxPage mailPage = new MailBoxPage(driver);
//            MailBoxPageWf.CreateAndSaveNewMail(mailPage, mail);
//            MailBoxPageWf.CheckDraft(mailPage, mail);
//            MailBoxPageWf.SendMailAndCheck(mailPage, mail);
//            MailBoxPageWf.LogOut(mailPage);
//            Assert.That(driver.Title == "Gmail");

//        }
//    }
//}
