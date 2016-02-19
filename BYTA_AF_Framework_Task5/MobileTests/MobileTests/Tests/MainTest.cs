using System;
using System.Threading;
using MobileTests.Pages;
using NUnit.Framework;

namespace MobileTests
{
    [TestFixture]
    public class MainTest : TestBase
    {
        [Test]
        public void iCanLogin()
        {
            LoginPage1 lp1 = new LoginPage1(driver);
            lp1.In();
            LoginPage2 lp2 = new LoginPage2(driver);
            lp2.EnterEmailAndSubmit();
            Console.WriteLine("hello world!");
            Thread.Sleep(5000);
        }
    }
}
