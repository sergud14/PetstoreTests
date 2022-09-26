namespace PetstoreTests
{
    public class FishPage:BasePage
    {
        private readonly By header = By.XPath("//h2[text()='Fish']");
        private readonly By angelFishLine = By.XPath("//a[text()='FI-SW-01']");

        public FishPage(IWebDriver webDriver) : base(webDriver)
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
    }
}
