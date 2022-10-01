namespace PetstoreTests
{
    public class ShoppingCartPage : BasePage
    {
        private readonly By header = By.XPath("//h2[text()='Shopping Cart']");
        private readonly By angelFishLine = By.XPath("//a[text()='FI-SW-01']");
        private readonly By inputQuantity = By.XPath("//input[@value='1']");
        private readonly By cellDescription = By.XPath("//td[3][contains(text(),'Large')][contains(text(),'Angelfish')]");
        private readonly By cellListPrice = By.XPath("//td[6][contains(text(),'" + TestSettings.listPrice + "')]");
        private readonly By cellTotalCost = By.XPath("//td[7][contains(text(),'" + TestSettings.totalCost + "')]");

        public ShoppingCartPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public AngelFishPage OpenAngelFishPage()
        {
            var webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            webDriverWait.Until(ExpectedConditions.ElementIsVisible(angelFishLine)).Click();
            AngelFishPage page = new AngelFishPage(webDriver);
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
                webDriverWait.Until(ExpectedConditions.ElementIsVisible(header));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CheckElements()
        {
            List<By> elements= new List<By>() {this.inputQuantity,this.cellDescription,this.cellListPrice,this.cellTotalCost};
            WebDriverWait webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(15));
            bool result = false;
            int i = 0;

            foreach (var element in elements)
            {
                if (webDriverWait.Until(ExpectedConditions.ElementIsVisible(element)) == null)
                {
                    i++;
                }
            }

            if (i == 0) result = true;
            return result;
        }
    }
}
