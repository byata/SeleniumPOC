using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Html5;
using OpenQA.Selenium.Remote;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.IO;
using Selenium_D3_test.Pages;
using Selenium_Framework_POC.Base;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using EAAutoFramework.Helpers;

namespace Selenium_D3_test
{
    [TestClass]
    public class UnitTest1 : Base
    {
       
        [TestMethod]
        public void TestMethod1()
        {

            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";
            ExcelHelpers.PopulateInCollection(fileName,"LoginCredentials");
            //Calling IE browser type
            Browser browser_method = new Browser(DriverContext.Driver);
            browser_method.OpenBrowser(BrowserType.InternetExplorer);
            //launch the D3 QA URL
            DriverContext.Browser.GoToUrl(ExcelHelpers.ReadData(1, "URL"));
            DriverContext.Driver.Manage().Window.Maximize();
            Thread.Sleep(6000);

            //Login page
            D3_Login_Page test_d3_Login_Page = new D3_Login_Page();
            //test_d3_Login_Page.Login(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1, "Password"));

            //Calling WelcomePAge Method
            Thread.Sleep(2000);
            WelcomePage();
            ProjectDetailsPage();
            //DriverContext.Driver.Close();
        }

        public void WelcomePage()
        {
            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";
            ExcelHelpers.PopulateInCollection(fileName, "ProjectDetails");
            D3_Welcome_Page Welcome_Page = new D3_Welcome_Page();
            //verify welcome page diosplayed )checking Deloitte Icon
            Thread.Sleep(6000);
            if (!(Welcome_Page.NameCredentials.Displayed))
            {
                Assert.IsTrue(false, "Welcome page NOT Displayed");
            }
            Actions_Sel actions_Sel = new Selenium_Framework_POC.Base.Actions_Sel(); 
            actions_Sel.MouseHover(Welcome_Page.ProjectAdmin_Link);
             
            Thread.Sleep(2000);
            if (!(Welcome_Page.Projects_Link.Displayed))
            {
                Assert.IsTrue(false, "Projects sub menu not displayed");
            }
            Welcome_Page.Projects_Link.Click();

        }
         
        public void ProjectDetailsPage()
        {
            D3_ProjectDetails_Page Project_Page = new D3_ProjectDetails_Page();
            Project_Page.txt_ProjectName.SendKeys(ExcelHelpers.ReadData(1, "ProjectName"));
            SelectElement Select_Company = new SelectElement(Project_Page.Company_Dropdown);
            Select_Company.SelectByText("Deloitte - EDSC - 4022 Sells Drive - Hermitage - TN");
            Thread.Sleep(2000);
            SelectElement select_Status = new SelectElement(Project_Page.ProjectStatus_Dropdown);
            select_Status.SelectByText("Active");
            Thread.Sleep(3000);



        }

        

        

    }

    }

