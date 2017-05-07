using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
