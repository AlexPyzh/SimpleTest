using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SimpleTest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace SimpleTest
{
    [TestFixture]
    public class ArsOffSiteFuncTests
    {

        static IWebDriver driver = new FirefoxDriver();
        WordpressPage page = new WordpressPage(driver);

        [Test]
        public void TestSendContactForm()
        {
            page.GetMainPage();
            page.dropDownManMenu(page.menuContacty);
            page.submenuNashiContacty.Click();
            page.inputYourEmail.SendKeys("pyzh@ars.atom.gov.ua");
            page.inputYourName.SendKeys("Alex");
            page.textareaYourMessage.SendKeys("Test message from site.");
            page.bntSendMessage.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.TextToBePresentInElement(page.messageSendStatus, "Thank you for your message. It has been sent"));

            Assert.IsTrue(page.messageSendStatus.Text.Contains("Thank you for your message. It has been sent"));


        }

        [OneTimeTearDown]
        public void TearDown()
        {
           driver.Quit();
        }
    }
}
