using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UITestingSiteTestProject.PageObjects;

namespace UITestingSiteTestProject.Steps
{
    [Binding]
    class VerificationSteps
    {

        private IWebDriver _driver;

        public VerificationSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"the Hello page should welcome (.*)")]
        public void ThenTheHelloPageShouldWelcomeTheName(string name)
        {
            HelloPageObject helloPageObject = new HelloPageObject(_driver);
            Assert.That(helloPageObject.IsPageOpened(), "Hello page is not opened");
            string expectedHelloMessage = helloPageObject.ParseHelloMessage();
            Assert.AreEqual("Hello " + name + "!", expectedHelloMessage, "Hello text does not cointan the expected value");
        }

        [Then(@"the title should be UI Testing Site")]
        public void ThenTheTitleShouldBeUITestingSite()
        {
            Assert.AreEqual("UI Testing Site", _driver.Title, "The title is correct");
        }

        [Then(@"the company logo should be displayed")]
        public void ThenTheCompanyLogoShouldBeDisplayed()
        {
            Assert.That(new BasePageObject(_driver).IsDhLogoDisplayed(), "DH logo is not displayed");
        }

        [Then(@"I should get navigated to the Home Page")]
        public void ThenIShouldGetNavigatedToTheHomePage()
        {
            Assert.That(new HomePageObject(_driver).IsPageOpened(), "Home page is not opened");
        }

        [Then(@"I should get navigated to the Form Page")]
        public void ThenIShouldGetNavigatedToTheFormPage()
        {
            Assert.That(new FormPageObject(_driver).IsPageOpened(), "Form page is not opened");
        }

        [Then(@"The status of Home button should be active")]
        public void ThenTheStatusOfHomeButtonShouldBeActive()
        {
            Assert.That(new BasePageObject(_driver).IsHomeButtonActive(), "The status of the Home button is inactive");
        }

        [Then(@"The status of Home button should be inactive")]
        public void ThenTheStatusOfHomeButtonShouldBeInactive()
        {
            Assert.False(new BasePageObject(_driver).IsHomeButtonActive(), "The status of the Home button is active");
        }

        [Then(@"The status of Form button should be active")]
        public void ThenTheStatusOfFormButtonShouldBeActive()
        {
            Assert.That(new BasePageObject(_driver).IsFormButtonActive(), "The status of the Form button is inactive");
        }

        [Then(@"The status of Form button should be inactive")]
        public void ThenTheStatusOfFormButtonShouldBeInactive()
        {
            Assert.False(new BasePageObject(_driver).IsFormButtonActive(), "The status of the Form button is active");
        }

        [Then(@"Error 404 status should return")]
        public void ThenErrorStatusShouldReturn()
        {
            Assert.That(_driver.Title.Contains("404 Error"), "Error 404 did not occur");
        }

        [Then(@"Header should be visible with ""(.*)""")]
        public void ThenHeaderShouldBeVisibleWith(string expectedHeaderValue)
        {
            Assert.That(new HomePageObject(_driver).IsHeaderVisibleWithValue(expectedHeaderValue), "The header is not visible with the expected value");
        }

        [Then(@"Text should be visible with the purpose of the site")]
        public void ThenTextShouldBeVisibleWithThePurposeOfTheSite()
        {
            Assert.That(new HomePageObject(_driver).IsTextVisibleWithThePurposeOfTheSite(), "The paragraph is not visible with the expected value");
        }

        [Then(@"I should see one input box")]
        public void ThenIShouldSeeOneInputBox()
        {
            Assert.That(new FormPageObject(_driver).IsOnlyOneInputBoxExistOnTheScreen(), "There is no, or not only one input box in the screen");
        }

        [Then(@"I should see one submit button")]
        public void ThenIShouldSeeOneSubmitButton()
        {
            Assert.That(new FormPageObject(_driver).IsOnlyOneSubmitButtonExistOnTheScreen(), "There is no, or not only one submit button in the screen");
        }
    }
}
