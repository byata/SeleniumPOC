using Relativity_test.Relativity_Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Relativity_test.Common
{
    public class FOIA_AppSetting
    {

        public void NewAppSetting(string AppName, string AppValue, string AppDesc)
        {
            Rel_Login_Page App_Page = new Rel_Login_Page();
            Thread.Sleep(4000);
            App_Page.AppSettings_Name.SendKeys(AppName);
            App_Page.AppSettings_Value.SendKeys(AppValue);
            App_Page.AppSettings_Description.SendKeys(AppDesc);
            Thread.Sleep(2000);
            App_Page.AppSettings_SaveandBack.Click();

        }
    }
}
