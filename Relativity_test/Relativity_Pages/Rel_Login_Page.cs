using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.IE;
using Selenium_Framework_POC.Base;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace Relativity_test.Relativity_Pages
{
    public class Rel_Login_Page : BasePage
    {
        //Objects for Login Page 
        //Username
        [FindsBy(How = How.CssSelector, Using = "input#_email")]
        public IWebElement txtUserName;
        //Continue button
        [FindsBy(How = How.LinkText, Using = "Continue")]
        public IWebElement ContinueBtn;
        //Password field
        [FindsBy(How = How.Id, Using = "_password__password_TextBox")]
        public IWebElement txtPassword;
        //Login button
        [FindsBy(How = How.Id, Using = "_login")]
        public IWebElement btnLogin;

        [FindsBy(How = How.LinkText, Using = "Workspaces")]
        public IWebElement Workspaces;

        //Workspace Name
        [FindsBy(How = How.LinkText, Using ="FOIA Client Demo")]
        //[FindsBy(How = How.XPath, Using = "//*[@id='1'][[@class='fluid-item-list-cell-link']/td[4]/div/a")]
        //[FindsBy(How = How.XPath, Using = "//*[@href='/Relativity/RedirectHandler.aspx? defaultCasePage = 1 & amp;AppID = 1017139']")]
        //[FindsBy(How = How.XPath, Using = "//*[@id='1']/td[4]/div/a")]
        public IWebElement FOIA_Workspace;


        [FindsBy(How = How.LinkText, Using = "FOIA Configuration")]
        public IWebElement FOIA_Config;

       [FindsBy(How = How.XPath, Using = "//*[@id='dashboardPanel']/div/div[4]/div/button-wgt/div/button")]
       // [FindsBy(How = How.PartialLinkText, Using = "New FOIA Configuration")]
        public IWebElement New_FOIA_Config;

        [FindsBy(How = How.LinkText, Using = "User Status")]
        public IWebElement User_Status;
        //ReldevWorkspace


        [FindsBy(How = How.XPath, Using = "//*[@id='jqg_fil_itemListFUI_1' AND @class='cbox']")]
        public IWebElement RelativityMain_checkbox1;

        [FindsBy(How = How.LinkText, Using = "New Workspace")]
        public IWebElement NewWorkspace_button;

        [FindsBy(How = How.ClassName, Using = "icn-toggle-filters show-filters")]
        public IWebElement showfilter_icon;

        //[FindsBy(How = How.XPath, Using = "//*[@id='jqgh_fil_itemListFUI_46']")]
        [FindsBy(How = How.XPath, Using = "//button[@class='btn-menu']")]
        public IWebElement Menu_icon;
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div[1]/div/div[2]/div[1]/h2")]
        public IWebElement dash_FOIAReq;
        //FOIA Dashboard Page
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div[1]/div/div[3]/div[2]/a")]
        public IWebElement FOIAReq_NewButton;

        //FOIA Application Settings
        [FindsBy(How = How.Id, Using = "_dynamicTemplate__dynamicViewFieldRenderer_ctl01_textBox_textBox")]
        public IWebElement AppSettings_Name;

        [FindsBy(How = How.Id, Using = "_dynamicTemplate__dynamicViewFieldRenderer_ctl02_textBox_textBox")]
        public IWebElement AppSettings_Value;

        [FindsBy(How = How.Id, Using = "_dynamicTemplate__dynamicViewFieldRenderer_ctl03_textBox_textBox")]
        public IWebElement AppSettings_Description;

        [FindsBy(How = How.Id, Using = "_dynamicTemplate_ctl04_button")]
        public IWebElement AppSettings_Save;

        [FindsBy(How = How.Id, Using = "_dynamicTemplate_ctl07_button")]
        public IWebElement AppSettings_SaveandBack;

        [FindsBy(How = How.Id, Using = "_dynamicTemplate__dynamicViewFieldRenderer_ctl21_textBox_textBox")]
        public IWebElement FOIA_REQ_DESC;
        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            Thread.Sleep(5000);
            //Actions_Sel.sendKeys(txtUserName,userName);
            Actions action = new Actions(DriverContext.Driver);
            action.SendKeys(Keys.Enter).Build().Perform();
            //ContinueBtn.Submit();
            Thread.Sleep(5000);
             txtPassword.SendKeys(password);
            // Actions_Sel.sendKeys(txtPassword, password);
            
            action.SendKeys(Keys.Enter).Build().Perform();
            // btnLogin.Submit();
            //Mouseclick(btnLogin);  
        }
    }
}
