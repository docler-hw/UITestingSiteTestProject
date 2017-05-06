using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestingSiteTestProject.PageObjects
{
    class HomePageObject
    {

        private IWebDriver _driver;

        public HomePageObject(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "form")]
        public IWebElement btnForm { get; set; }

        public void NavigateToFormPage()
        {
            btnForm.Click();
        }

    }
}
