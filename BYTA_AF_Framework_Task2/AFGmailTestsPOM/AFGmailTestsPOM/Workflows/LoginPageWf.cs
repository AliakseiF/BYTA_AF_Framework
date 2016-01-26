using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AFGmailTestsPOM.Pages;
using AFGmailTestsPOM.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AFGmailTestsPOM.Workflows
{
    public static class LoginPageWf
    {
        public static LoginPage LoginToGmail(this LoginPage page,string login, string pass)
        {
            Console.WriteLine("Log in to gmail...");
            //if (page.BackArrow.Displayed)
            //    page.BackArrow.Click();
            if (page.LoginField != null)
            {
                page.LoginField.SendKeys(login);
                page.NextButton.Click();
                TestBase.WaitForElement(page.PageBrowser, page.remember);
            }
            page.PassField.SendKeys(pass);
            page.SingInButton.Click();
            //MailBoxPage mailBox = new MailBoxPage(page.PageBrowser);
            //TestBase.WaitForElement(page.PageBrowser, mailBox.newMailbnt);
            return page;
        }
    }
}
