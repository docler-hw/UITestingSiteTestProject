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

        [Given(@"I have navigated to the Form page")]
        public void GivenIHaveNavigatedToTheFormPage()
        {
            new HomePageObject(_driver).NavigateToFormPage();
        }

        [When(@"I enter (.*) to the form")]
        public void WhenIEnterJohnToTheForm(string name)
        {
            new FormPageObject(_driver).EnterNameIntoHelloTextInput(name);
        }


        [When(@"I click on the Go button")]
        public void WhenIClickOnTheGoButton()
        {
            new FormPageObject(_driver).SubmitHelloForm();
        }

        [Then(@"the Hello page should welcome (.*)")]
        public void ThenTheHelloPageShouldWelcomeJohn(string name)
        {
            string expectedHelloMessage = new HelloPageObject(_driver).ParseHelloMessage();
            Assert.AreEqual("Hello " + name + "!", expectedHelloMessage, "Hello text does not cointan the expected value");
        }

    }
}
