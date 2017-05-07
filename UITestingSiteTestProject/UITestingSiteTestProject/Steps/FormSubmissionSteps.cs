using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using UITestingSiteTestProject.PageObjects;

namespace UITestingSiteTestProject.Steps
{

    [Binding]
    public class FormSubmissionSteps
    {

        private IWebDriver _driver;

        public FormSubmissionSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"I enter (.*) to the form")]
        public void WhenIEnterTheNameToTheForm(string name)
        {
            new FormPageObject(_driver).EnterNameIntoHelloTextInput(name);
        }

        [When(@"I click on the Go button")]
        public void WhenIClickOnTheGoButton()
        {
            new FormPageObject(_driver).SubmitHelloForm();
        }

        [Then(@"the Hello page should welcome (.*)")]
        public void ThenTheHelloPageShouldWelcomeTheName(string name)
        {
            HelloPageObject helloPageObject = new HelloPageObject(_driver);
            Assert.That(helloPageObject.IsPageOpened(), "Hello page is not opened");
            string expectedHelloMessage = helloPageObject.ParseHelloMessage();
            Assert.AreEqual("Hello " + name + "!", expectedHelloMessage, "Hello text does not cointan the expected value");
        }
    }
}
