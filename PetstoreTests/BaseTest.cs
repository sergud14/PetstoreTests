namespace PetstoreTests
{
    public class BaseTest
    {
        public IWebDriver webDriver;

        [OneTimeSetUp]
        public void Setup()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--headless");
            chromeOptions.AddArguments("--start-maximized");
            webDriver = new ChromeDriver(chromeOptions);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            webDriver.Quit();
        }
    }
}