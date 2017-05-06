using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UITestingSiteTestProject.Steps
{   

    [Binding]
    public class NavigationSteps
    {

        private IWebDriver _driver;

        public NavigationSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"I have opened the home page")]
        public void GivenIHaveOpenedTheHomePage(){ }


        [Then(@"the title should be UI Testing Site")]
        public void ThenTheTitleShouldBeUITestingSite()
        {
            Assert.AreEqual("UI Testing Site", _driver.Title, "The title is correct");
        }
    }
}
