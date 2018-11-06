using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Selenium_Framework_POC.Base;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace Selenium_D3_test.Pages
{
    class D3_Welcome_Page : BasePage
    {
        //Page Initialisation
        //Deloitte Logo
        [FindsBy(How = How.XPath, Using = ("//img[contains(@src,'Images/logo.deloitte.png')]"))]
        public IWebElement NameCredentials;

        //Project Administration section (left side)
        //[FindsBy(How = How.XPath, Using =(".//div[@id='mainMenu']//a[contains(@onclick, '__doPostBack('ctl00$mainMenu','ProjAdmin')')]"))]
        [FindsBy(How = How.LinkText, Using = "Project Administration")]
        public IWebElement ProjectAdmin_Link;

        //Projects sub menu 
        //[FindsBy(How = How.XPath, Using = ("//a[@href='Admin/ProjectDetail.aspx']"))]
        //[FindsBy(How = How.CssSelector, Using = "a:contains('Projects')")]
        [FindsBy(How = How.LinkText, Using = "Projects")]
        public IWebElement Projects_Link;

       
    }

}
