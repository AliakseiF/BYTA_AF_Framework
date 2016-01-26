using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AFGmailTestsPOM.Patterns
{
    public abstract class FactoryMethod
    {
        protected IWebDriver FactoryDriver;

        public abstract IWebDriver CreateDriver();
    }
}
