using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Framework_POC.Base
{
    public static class DriverContext
    {
        //Calling this driver across
        public static IWebDriver Driver { get; set; }


        public static Browser Browser { get; set; }
    }
}
