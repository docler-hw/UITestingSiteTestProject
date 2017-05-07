using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
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

    }
}
