using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium_Framework_POC.Base;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_D3_test.Pages
{
    public class D3_ProjectDetails_Page : BasePage
    {
        //Element for Project Details Input Text box
        [FindsBy(How = How.Name, Using = "ctl00$cntPage$txtProjectNameSearch")]
        public IWebElement txt_ProjectName;

        //company Dropdown
        [FindsBy(How = How.Name, Using = "ctl00$cntPage$ddlCompany")]
        public IWebElement Company_Dropdown;

        //Project status Dropdown
        [FindsBy(How = How.Name, Using = "ctl00$cntPage$ucProjectStatus$ddlStatusDropdown")]
        public IWebElement ProjectStatus_Dropdown;

        //Project Restriction Dropdown
        [FindsBy(How = How.Name, Using = "ctl00$cntPage$ddlProjectRestriction")]
        public IWebElement ProjectRestriction_Dropdown;

        //Project Save button
        [FindsBy(How = How.Name, Using = "ctl00$cntPage$btnSave")]
        public IWebElement Project_Save;
    }
}
