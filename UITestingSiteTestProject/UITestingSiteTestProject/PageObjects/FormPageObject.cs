using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UITestingSiteTestProject.PageObjects
{
    class FormPageObject : AbstractPageObject
    {

        public FormPageObject(IWebDriver driver)
            : base(driver)
        {
            pageUrl = "http://uitest.duodecadits.com/form.html";
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

        public bool IsOnlyOneInputBoxExistOnTheScreen()
        {
            return 1 == _driver.FindElements(By.XPath("//input")).Count;
        }

        public bool IsOnlyOneSubmitButtonExistOnTheScreen()
        {
            return 1 == _driver.FindElements(By.XPath("//button[@type='submit']")).Count;
        }
    }
}
