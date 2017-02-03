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
    public class ArsOffSiteUITests
    {

        static IWebDriver driver = new FirefoxDriver();
        WordpressPage page = new WordpressPage(driver);

        [Test]
        public void Test1MainPage()
        {
            page.GetMainPage();
            Assert.IsTrue(driver.PageSource.Contains("Інформація про хід виконання робіт ВП АРС"));
        }

        [Test]
        public void Test2MenuInformBlock()
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

        [Test]
        public void Test3MainMenuDiyalnist()
        {
            page.GetMainPage();

            page.menuDiyalnist.Click();
            Assert.IsTrue(page.headerWordoressPage.Text == "Діяльність");

            page.dropDownManMenu(page.menuDiyalnist);
            page.submenuStructure.Click();
            Assert.IsTrue(page.headerWordoressPage.Text == "Структура");

            page.dropDownManMenu(page.menuDiyalnist);
            page.submenuCertification.Click();
            Assert.IsTrue(page.headerWordoressPage2.Text == "Сертифікати, ліцензії, дозволи");

            page.dropDownManMenu(page.menuDiyalnist);
            page.submenuKerivnyctvo.Click();
            Assert.IsTrue(page.headerWordoressPage.Text == "Керівництво");

            page.dropDownManMenu(page.menuDiyalnist);
            page.submenuZayavyKerivnytstva.Click();
            Assert.IsTrue(page.headerWordoressPage.Text == "Заяви керівництва ДП «НАЕК «Енергоатом»");

            page.dropDownManMenu(page.menuDiyalnist);
            page.submenuZvernennyaDyrectora.Click();
            Assert.IsTrue(page.headerWordoressPage.Text == "Звернення директора ВП АРС");

        }

        [Test]
        public void Test4MainMenuKulturaBezpeky()
        {
            page.GetMainPage();

            page.menuKulturaBezpeky.Click();
            Assert.IsTrue(page.headerWordoressPage.Text == "Культура безпеки");

            page.dropDownManMenu(page.menuKulturaBezpeky);
            page.submenuPlakaty.Click();
            Assert.IsTrue(page.headerWordoressPage.Text == "Плакаты");
        }

        [Test]
        public void Test5MainMenuProtydiyaKorruptsii()
        {
            page.GetMainPage();

            page.menuProtydiyaKorruptsii.Click();
            Assert.IsTrue(page.headerWordoressPage.Text == "Протидія корупції");

            page.dropDownManMenu(page.menuProtydiyaKorruptsii);
            page.submenuAntikorrupZakon.Click();
            Assert.IsTrue(page.headerWordoressPage.Text == "Антикорупційне законодавство");

            page.dropDownManMenu(page.menuProtydiyaKorruptsii);
            page.submenuMetodychniRekomendatsii.Click();
            Assert.IsTrue(page.headerWordoressPage.Text == "Методичні рекомендації та роз’яснення");

            page.dropDownManMenu(page.menuProtydiyaKorruptsii);
            page.submenuVidpovidalnist.Click();
            Assert.IsTrue(page.headerWordoressPage.Text == "Відповідальність");
        }

        [Test]
        public void Test6MainMenuNTC()
        {
            page.GetMainPage();
            page.menuNTC.Click();
            Assert.IsTrue(page.headerWordoressPage.Text.Contains("Навчально-тренувальний"));

            //page.dropDownManMenu(page.jsmenuZagalniVidomosti);
            //page.jssubmenuUCNK.Click();
            //Assert.IsTrue(page.headerWordoressPage.Text.Contains("УЦНК"));

            page.dropDownManMenu(page.jsmenuProgramyPidgotovky);
            page.jssubmenuObschayaPidgotovka.Click();
            Assert.IsTrue(page.headerWordoressPage.Text.Contains("Общая"));
        }


        [OneTimeTearDown]
        public void teardown()
        {
          driver.Quit();
        }


    }
}
