using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestingSiteTestProject.PageObjects
{
    class HelloPageObject
    {

        private IWebDriver _driver;

        public HelloPageObject(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        //_driver.FindElement(By.Id("form")).Click();

        [FindsBy(How = How.Id, Using = "hello-text")]
        public IWebElement txtHello { get; set; }

        public string ParseHelloMessage()
        {
            return txtHello.Text;
        }

    }
}
