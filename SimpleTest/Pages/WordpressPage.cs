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

        [FindsBy(How = How.Id, Using = "menu-item-885")]
        public IWebElement menuContacty;

        [FindsBy(How = How.Id, Using = "menu-item-97")]
        public IWebElement submenuNashiContacty;

        [FindsBy(How = How.Name, Using = "your-name")]
        public IWebElement inputYourName;

        [FindsBy(How = How.Name, Using = "your-email")]
        public IWebElement inputYourEmail;

        [FindsBy(How = How.Name, Using = "your-message")]
        public IWebElement textareaYourMessage;

        [FindsBy(How = How.CssSelector, Using = "#wpcf7-f1564-p88-o1 > form > p:nth-child(5) > input")]
        public IWebElement bntSendMessage;

        [FindsBy(How = How.CssSelector, Using = "#wpcf7-f1564-p88-o1 > form > div.wpcf7-response-output.wpcf7-display-none.wpcf7-mail-sent-ok")]
        public IWebElement messageSendStatus;


        //=====================================================================================

        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement searchText;
    }
}
