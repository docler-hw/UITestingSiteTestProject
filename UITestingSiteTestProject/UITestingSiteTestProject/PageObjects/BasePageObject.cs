using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UITestingSiteTestProject.PageObjects
{
    class BasePageObject : AbstractPageObject
    {

        public BasePageObject(IWebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "dh_logo")]
        public IWebElement imgDhLogo { get; set; }
        [FindsBy(How = How.Id, Using = "home")]
        public IWebElement btnHome { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='navbar']//li[@class='active']/a[@id='home']")]
        public IWebElement btnActiveHome { get; set; }
        [FindsBy(How = How.Id, Using = "form")]
        public IWebElement btnForm { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='navbar']//li[@class='active']/a[@id='form']")]
        public IWebElement btnActiveForm { get; set; }
        [FindsBy(How = How.Id, Using = "error")]
        public IWebElement btnError { get; set; }
        [FindsBy(How = How.Id, Using = "site")]
        public IWebElement btnUITesting { get; set; }

        public bool IsDhLogoDisplayed()
        {
            return imgDhLogo.Displayed;
        }

        public void ClickOnHomeButton()
        {
            btnHome.Click();
        }

        public void ClickOnFormButton()
        {
            btnForm.Click();
        }

        public void ClickOnErrorButton()
        {
            btnError.Click();
        }

        public void ClickUITestingButton()
        {
            btnUITesting.Click();
        }

        public bool IsHomeButtonActive()
        {
            try
            {
                return btnActiveHome.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            };
        }

        public bool IsFormButtonActive()
        {
            try
            {
                return btnActiveForm.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            };
        }
    }
}
