using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetstoreTests
{
    public class StartPage:BasePage
    {
    public By buttonEnterStore = By.XPath("//a[text()='Enter the Store']");

        public StartPage(IWebDriver webDriver) : base(webDriver)
        {
            webDriver.Navigate().GoToUrl(TestSettings.startUrl);
        }

        public CatalogPage OpenCatalog()
        { 
            var webDriverWait= new WebDriverWait(webDriver,TimeSpan.FromSeconds(10));
            webDriverWait.Until(ExpectedConditions.ElementIsVisible(buttonEnterStore)).Click();
            CatalogPage page = new CatalogPage(webDriver);
            if (page.PageLoaded())
            {
                return page;
            }
            else
            {
                return null;
            }
        }
    }
}
