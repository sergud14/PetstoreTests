using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetstoreTests
{
    public class CatalogPage:BasePage
    {
        private readonly By topbar = By.XPath("//a/img[contains(@src,'topbar')]");
        private readonly By fishIcon = By.XPath("//a/img[contains(@src,'fish_icon')]");

        public CatalogPage(IWebDriver webDriver) : base(webDriver)
        {

        }


        public FishPage OpenFishPage()
        {
            var webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            webDriverWait.Until(ExpectedConditions.ElementIsVisible(fishIcon)).Click();
            FishPage page = new FishPage(webDriver);
            if (page.PageLoaded())
            {
                return page;
            }
            else
            {
                return null;
            }
        }


        public bool PageLoaded()
        {
            try
            {
                var webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
                webDriverWait.Until(ExpectedConditions.ElementIsVisible(topbar));
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
