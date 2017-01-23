using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTest
{
    class BasePage
    {
        private IWebDriver driver;

        public IWebDriver GetWebDriver()
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            return driver;
        }

        public void GetMainPage()
        {
            GetWebDriver().Navigate().GoToUrl("http://ars.atom.gov.ua");
        }                   

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}
