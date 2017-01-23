using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using SimpleTest.Pages;

namespace SimpleTest
{
    [TestFixture]
    public class ArsOffSiteTest
    {

        static IWebDriver driver = new FirefoxDriver();
        WordpressPage page = new WordpressPage(driver);

        [Test]
        public void TestMainPage()
        {
            //page.GetWebDriver().Navigate().GoToUrl("http://ars.atom.gov.ua");
            page.GetMainPage();
            Assert.IsTrue(driver.PageSource.Contains("Інформація про хід виконання робіт ВП АРС"));
        }

        [Test]
        public void TestMenuInformBlock()
        {
            page.GetMainPage();
            page.dropDownManMenu(page.menuInformBlock);
            page.submenuNovynyARS.Click();
            Assert.IsTrue(page.headerNewsPage.Text == "Новини ВП АРС");

            page.dropDownManMenu(page.menuInformBlock);
            page.submenuNovynyAtomEnergetiki.Click();
            Assert.IsTrue(page.headerNewsPage.Text == "Новини атомної енергетики");

            page.dropDownManMenu(page.menuInformBlock);
            page.submenuPhotoVideo.Click();
            Assert.IsTrue(page.headerWordoressPage.Text == "Фотографії, відео");

            page.dropDownManMenu(page.menuInformBlock);
            page.submenuIV.Click();
            Assert.IsTrue(page.headerWordoressPage.Text == "Інформаційний вісник ВП АРС");

            page.dropDownManMenu(page.menuInformBlock);
            page.submenuPresentations.Click();
            Assert.IsTrue(page.headerWordoressPage.Text == "Презентації");

        }

        [OneTimeTearDown]
        public void teardown()
        {
           // driver.Quit();
        }


    }
}
