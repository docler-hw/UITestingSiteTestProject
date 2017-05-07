using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestingSiteTestProject.PageObjects
{
    class HelloPageObject : AbstractPageObject
    {

        public HelloPageObject(IWebDriver driver)
            : base(driver)
        {
            pageUrl = "http://uitest.duodecadits.com/hello.html";
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "hello-text")]
        public IWebElement txtHello { get; set; }

        public override bool IsPageOpened()
        {
            return _driver.Url.StartsWith(pageUrl);
        }

        public string ParseHelloMessage()
        {
            return txtHello.Text;
        }

    }
}
