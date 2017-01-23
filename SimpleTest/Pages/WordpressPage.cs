using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;

namespace SimpleTest.Pages
{
    class WordpressPage : BasePage
    {
        public WordpressPage(IWebDriver driver) : base(driver)
        {
        }

        public void dropDownManMenu(IWebElement element)
        {
            Actions builder = new Actions(GetWebDriver());
            builder.MoveToElement(element).Perform();
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/section/h1")]
        public IWebElement headerNewsPage;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/h1")]
        public IWebElement headerWordoressPage;

//=====================================================================================

        [FindsBy(How = How.Id, Using = "menu-item-886")]
        public IWebElement menuInformBlock;

        [FindsBy(How = How.Id, Using = "menu-item-1009")]
        public IWebElement submenuNovynyARS;

        [FindsBy(How = How.Id, Using = "menu-item-1010")]
        public IWebElement submenuNovynyAtomEnergetiki;

        [FindsBy(How = How.Id, Using = "menu-item-967")]
        public IWebElement submenuPhotoVideo;

        [FindsBy(How = How.Id, Using = "menu-item-127")]
        public IWebElement submenuIV;

        [FindsBy(How = How.Id, Using = "menu-item-968")]
        public IWebElement submenuPresentations;

//=====================================================================================



//=====================================================================================

        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement searchText;
    }
}
