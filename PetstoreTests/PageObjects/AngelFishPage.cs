namespace PetstoreTests
{
    public class AngelFishPage : BasePage
    {
        private readonly By header = By.XPath("//h2[text()='Angelfish']");
        private readonly By largeAngelfishLine = By.XPath("//td/a[text()='EST-1']");
        public readonly By item = By.XPath("(//a[contains(text(),'Add to Cart')])["+TestSettings.itemNumber+"]");

        public AngelFishPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public ShoppingCartPage AddToShoppingCart()
        {
            var webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            webDriverWait.Until(ExpectedConditions.ElementIsVisible(item)).Click();
            ShoppingCartPage page = new ShoppingCartPage(webDriver);
            if (page.PageLoaded())
            {
                return page;
            }
            else
            {
                return null;
            }
        }

        public LargeAngelFishPage OpenLargeAngelFishPage()
        {
            var webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            webDriverWait.Until(ExpectedConditions.ElementIsVisible(largeAngelfishLine)).Click();
            LargeAngelFishPage page = new LargeAngelFishPage(webDriver);
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
    }
}
