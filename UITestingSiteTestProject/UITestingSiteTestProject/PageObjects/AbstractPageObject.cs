using OpenQA.Selenium;

namespace UITestingSiteTestProject.PageObjects
{
    public abstract class AbstractPageObject
    {

        protected OpenQA.Selenium.IWebDriver _driver;
        protected string pageUrl;

        public AbstractPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public virtual bool IsPageOpened()
        {
            return pageUrl == _driver.Url;
        }

        public void openPageByUrl()
        {
            _driver.Navigate().GoToUrl(pageUrl);
        }
    }
}
