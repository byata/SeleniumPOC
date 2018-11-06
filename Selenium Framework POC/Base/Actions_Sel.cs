using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Selenium_Framework_POC.Base
{
  public class Actions_Sel
    {
        public void MouseHover(IWebElement element)
        {
            Actions builder = new Actions(DriverContext.Driver);
            builder.MoveToElement(element).Build();
            builder.Perform();
        }
        public static void sendKeys(IWebElement element, string text)
        {
            element.Click();
            Actions actions = new Actions(DriverContext.Driver);
            //text.Split().forEach((c) => text.actions.SendKeys(c)); 
        }
        public static void clicklinkbytext(String text)
        {
            IList<IWebElement> links = DriverContext.Driver.FindElements(By.TagName("a"));
            links.First(element => element.Text == text).Click();

            // your logic with traditional foreach loop
            foreach (var link in links)
            {
                if (link.Text == text)
                {
                    link.Click();
                    break;
                }
            }

        }

    }
}
