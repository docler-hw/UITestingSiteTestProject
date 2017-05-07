using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UITestingSiteTestProject.PageObjects
{
    class HomePageObject : AbstractPageObject
    {

        public HomePageObject(IWebDriver driver)
            : base(driver)
        {
            pageUrl = "http://uitest.duodecadits.com/";
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "h1")]
        public IWebElement header { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[contains(text(), 'This site is dedicated to perform some exercises and demonstrate automated web testing.')]")]
        public IWebElement purposeParagraph { get; set; }        

        public bool IsHeaderVisibleWithValue(string expectedHeader)
        {
            try
            {
                bool isDisplayed = header.Displayed;
                bool isExpected = expectedHeader.Equals(header.Text);
                return isDisplayed && isExpected;
            }
            catch (NoSuchElementException)
            {
                return false;
            };
        }

        public bool IsTextVisibleWithThePurposeOfTheSite()
        {
            try
            {
                return purposeParagraph.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            };
        }
    }
}
