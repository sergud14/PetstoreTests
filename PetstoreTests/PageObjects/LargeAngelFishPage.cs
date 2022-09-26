namespace PetstoreTests
{
    public class LargeAngelFishPage : BasePage
    {
        private readonly By header = By.XPath("//font[contains(text(),'Large') and contains(text(),'Angelfish')]");
        private readonly By backLink = By.XPath("//div[@id='BackLink']");
        public LargeAngelFishPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public AngelFishPage ReturnToAngelFishPage()
        {
            var webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            webDriverWait.Until(ExpectedConditions.ElementIsVisible(backLink)).Click();
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
