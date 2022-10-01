using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetstoreTests
{
    public class BasePage
    {
        public IWebDriver webDriver;


        public BasePage (IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public bool ClickElement(By element)
        {
            bool result=false;
            for (int i = 1; i < 4; i++)
            {
                try
                {
                    var webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(15));
                    webDriverWait.Until(ExpectedConditions.ElementIsVisible(element)).Click();
                    result = true;
                    break;
                }
                catch
                {
                    result= false;
                }
            }
            return result;
        }

        //public virtual bool CheckElements(List<By> elements)
        //{
        //    WebDriverWait webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(15));
        //    bool result = false;
        //    int i = 0;

        //    foreach (var element in elements)
        //    {
        //      if (webDriverWait.Until(ExpectedConditions.ElementIsVisible(element)) != null)
        //      {  
        //       i++;
        //      }
        //    }

        //    if (i == 0) result = true;
        //    return result;
        //}
    }
}
