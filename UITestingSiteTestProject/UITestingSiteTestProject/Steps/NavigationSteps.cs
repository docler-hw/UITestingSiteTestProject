using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UITestingSiteTestProject.PageObjects;

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

        [Given(@"I have opened the Home page")]
        public void GivenIHaveOpenedTheHomePage()
        {
            new HomePageObject(_driver).openPageByUrl();
        }

        [Given(@"I have opened the Form page")]
        public void GivenIHaveOpenedTheFormPage()
        {
            new FormPageObject(_driver).openPageByUrl();
        }

        [Given(@"I have opened the Hello page")]
        public void GivenIHaveOpenedTheHelloPage()
        {
            new HelloPageObject(_driver).openPageByUrl();
        }

        [Given(@"I clicked on the Home button")]
        [When(@"I clicked on the Home button")]
        public void GivenIClickedOnTheHomeButton()
        {
            new BasePageObject(_driver).ClickOnHomeButton();
        }

        [Given(@"I clicked on the Form button")]
        [When(@"I clicked on the Form button")]
        public void GivenIClickedOnTheFormButton()
        {
            new BasePageObject(_driver).ClickOnFormButton();
        }

        [Given(@"I clicked on the Error button")]
        public void GivenIClickedOnTheErrorButton()
        {
            new BasePageObject(_driver).ClickOnErrorButton();
        }

        [Given(@"I clicked on the UI Testing button")]
        [When(@"I clicked on the UI Testing button")]
        public void GivenIClickedOnTheUITestingsButton()
        {
            new BasePageObject(_driver).ClickUITestingButton();
        }

        [When(@"I clicked on the Error button")]
        public void WhenIClickedOnTheErrorButton()
        {
            new BasePageObject(_driver).ClickOnErrorButton();
        }

    }
}
