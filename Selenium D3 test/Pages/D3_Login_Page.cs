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

namespace Selenium_D3_test.Pages
{
   public class D3_Login_Page : BasePage
    {


        //Objects for Login Page 
        [FindsBy(How = How.Id, Using = "textfield-1021-inputEl")]
        public IWebElement txtUserName;
        [FindsBy(How = How.Id, Using = "textfield-1022-inputEl")]
        public IWebElement txtPassword;
        [FindsBy(How = How.LinkText, Using = "Log On")]
        public IWebElement btnLogin;

       
       
        public void Login(string userName, string password)
        {
           
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.SendKeys(Keys.Enter);
            //Mouseclick(btnLogin);  
        }

        

    }
}