using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Framework_POC.Base
{
    public class Browser
    {
        private readonly IWebDriver _driver;
        public static IJavaScriptExecutor js;

        public Browser(IWebDriver driver)
        {
            _driver = driver;
        }

        public BrowserType Type { get; set;}

        public void GoToUrl(string url)
        {
            DriverContext.Driver.Url = url;
        }
        public void OpenBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    InternetExplorerOptions opt = new InternetExplorerOptions();
                    opt.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    opt.IgnoreZoomLevel = true;
                    DriverContext.Driver = new OpenQA.Selenium.IE.InternetExplorerDriver("C:\\Program Files (x86)\\", opt);
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    js = (IJavaScriptExecutor)this._driver;
                    break;
                case BrowserType.FireFox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new OpenQA.Selenium.Chrome.ChromeDriver("C:\\Program Files (x86)\\");
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                   // js = (IJavaScriptExecutor)this._driver;
                    break;
                default:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;


            }
        }
    }

   public enum BrowserType
    {
        InternetExplorer,
        FireFox,
        Chrome
    }
    
}
