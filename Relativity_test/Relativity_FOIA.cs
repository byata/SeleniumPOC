using EAAutoFramework.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Relativity_test.Common;
using Relativity_test.Relativity_Pages;
using Selenium_Framework_POC.Base;
using Selenium_Framework_POC.Helpers;
using System;
using System.Threading;


//tets
namespace Relativity_test
{
    [TestClass]
    public class Relativity_FOIA
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            string fileName = Environment.CurrentDirectory.ToString() + "\\Relativity_Data\\Login.xlsx";
            ExcelHelpers.PopulateInCollection(fileName, "RelativityCredentials");
            //create Log File
            LogHelpers.CreateLogfile();

            //Calling IE browser type
            //IJavaScriptExecutor App = DriverContext.Driver as IJavaScriptExecutor;
            Browser browser_method = new Browser(DriverContext.Driver);
            browser_method.OpenBrowser(BrowserType.Chrome);
            LogHelpers.Write("Opened browser");
            //launch the D3 QA URL
            IJavaScriptExecutor App = DriverContext.Driver as IJavaScriptExecutor;
            DriverContext.Browser.GoToUrl(ExcelHelpers.ReadData(1, "Relativity URL"));
            DriverContext.Driver.Manage().Window.Maximize();
            Thread.Sleep(6000);

            //Login page
            Rel_Login_Page test_Rel_Login_PAge = new Rel_Login_Page();
            test_Rel_Login_PAge.Login(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1,"Password"));
            Thread.Sleep(5000);
            DriverContext.Driver.SwitchTo().Frame("_externalPage");
            IJavaScriptExecutor js = (IJavaScriptExecutor)DriverContext.Driver;
            Thread.Sleep(5000);
            string title = (string)js.ExecuteScript("arguments[0].click();", test_Rel_Login_PAge.FOIA_Workspace);
            Thread.Sleep(5000);
            //test_Rel_Login_PAge.FOIA_Workspace.Click();
            Thread.Sleep(12000);
            test_Rel_Login_PAge.FOIA_Config.Click();
            Thread.Sleep(4000);
            DriverContext.Driver.SwitchTo().Frame("_externalPage");
            string title2 = (string)js.ExecuteScript("arguments[0].click();", test_Rel_Login_PAge.New_FOIA_Config);
            Thread.Sleep(5000);
            FOIA_AppSetting appSetting = new FOIA_AppSetting();

            appSetting.NewAppSetting(ExcelHelpers.ReadData(1, "AppName"), ExcelHelpers.ReadData(1, "AppValue"), ExcelHelpers.ReadData(1, "AppDesc"));

            DriverContext.Driver.Quit();


        }
    }
}
 