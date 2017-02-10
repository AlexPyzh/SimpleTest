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

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/h1")]
        public IWebElement headerWordoressPage2;

        //Footer======================================================================================

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/p[4]")]
        public IWebElement Footer;

        //InformBlock=====================================================================================

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

        //Diyalnist=====================================================================================

        [FindsBy(How = How.Id, Using = "menu-item-416")]
        public IWebElement menuDiyalnist;

        [FindsBy(How = How.Id, Using = "menu-item-937")]
        public IWebElement submenuStructure;

        [FindsBy(How = How.Id, Using = "menu-item-945")]
        public IWebElement submenuCertification;

        [FindsBy(How = How.Id, Using = "menu-item-110")]
        public IWebElement submenuKerivnyctvo;

        [FindsBy(How = How.Id, Using = "menu-item-946")]
        public IWebElement submenuZayavyKerivnytstva;

        [FindsBy(How = How.Id, Using = "menu-item-2039")]
        public IWebElement submenuZvernennyaDyrectora;

        //KulturaBezpeky=====================================================================================

        [FindsBy(How = How.Id, Using = "menu-item-947")]
        public IWebElement menuKulturaBezpeky;

        [FindsBy(How = How.Id, Using = "menu-item-2808")]
        public IWebElement submenuPlakaty;

        //ProtydiyaKorruptsii=====================================================================================

        [FindsBy(How = How.Id, Using = "menu-item-2566")]
        public IWebElement menuProtydiyaKorruptsii;

        [FindsBy(How = How.Id, Using = "menu-item-2588")]
        public IWebElement submenuAntikorrupZakon;

        [FindsBy(How = How.Id, Using = "menu-item-2661")]
        public IWebElement submenuMetodychniRekomendatsii;

        [FindsBy(How = How.Id, Using = "menu-item-2589")]
        public IWebElement submenuVidpovidalnist;

        [FindsBy(How = How.Id, Using = "menu-item-2590")]
        public IWebElement submenuNovynytaPublikatsii;

        [FindsBy(How = How.Id, Using = "menu-item-2591")]
        public IWebElement submenuSkrynkaDoviry;

        //ProtydiyaKorruptsii=====================================================================================

        [FindsBy(How = How.Id, Using = "menu-item-1556")]
        public IWebElement menuNTC;

        [FindsBy(How = How.Id, Using = "menu-item-1340")]
        public IWebElement jsmenuZagalniVidomosti;

        [FindsBy(How = How.Id, Using = "menu-item-2759")]
        public IWebElement jssubmenuUCNK;

        [FindsBy(How = How.Id, Using = "menu-item-212")]
        public IWebElement jsmenuProgramyPidgotovky;

        [FindsBy(How = How.Id, Using = "menu-item-309")]
        public IWebElement jssubmenuObschayaPidgotovka;

        //Incorrect filling=====================================================================================

        [FindsBy(How = How.CssSelector, Using = "#wpcf7-f1564-p88-o1 > form > p:nth-child(2) > span > span")]
        public IWebElement AlertName;

        [FindsBy(How = How.CssSelector, Using = "#wpcf7-f1564-p88-o1 > form > p:nth-child(3) > span > span")]
        public IWebElement AlertEmail;


        //SendMail=====================================================================================


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


        //UploadFile=====================================================================================

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/span/img")]
        public IWebElement iconDownloadPage;


        [FindsBy(How = How.Name, Using = "file_upload")]
        public IWebElement btnUploadFile;

        [FindsBy(How = How.Name, Using = "submit-btn")]
        public IWebElement btnSubmit;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div")]
        public IWebElement tableFiles;

        //=====================================================================================


        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement searchText;
    }
}
