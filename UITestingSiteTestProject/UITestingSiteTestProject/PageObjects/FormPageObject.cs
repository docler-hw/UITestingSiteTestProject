using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestingSiteTestProject.PageObjects
{
    class FormPageObject
    {

        private OpenQA.Selenium.IWebDriver _driver;

        public FormPageObject(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "hello-input")]
        public IWebElement txtHelloInput { get; set; }
        [FindsBy(How = How.Id, Using = "hello-submit")]
        public IWebElement btnSubmitHello { get; set; }

        public void EnterNameIntoHelloTextInput(string name)
        {
            txtHelloInput.SendKeys(name);
        }

        public void SubmitHelloForm()
        {
            btnSubmitHello.Click();
        }
    }
}
