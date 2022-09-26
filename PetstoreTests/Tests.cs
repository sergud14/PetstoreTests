namespace PetstoreTests
{
    internal class Tests:BaseTest
    {
        [Test, Order(1)]
        public void OpenCatalogPageAssert()
        {
            var startPage = new StartPage(webDriver);
            Assert.NotNull(startPage.OpenCatalog());
        }

        [Test, Order(2)]
        public void OpenFishPageAssert()
        {
            var catalogPage = new CatalogPage(webDriver);
            Assert.NotNull(catalogPage.OpenFishPage());
        }

        [Test, Order(3)]
        public void OpenAngelFishPageAssert()
        {
            var fishPage = new FishPage(webDriver);
            Assert.NotNull(fishPage.OpenAngelFishPage());
        }

        [Test, Order(4)]
        public void OpenLargeAngelFishPageAssert()
        {
            var angelFishPage = new AngelFishPage(webDriver);
            Assert.NotNull(angelFishPage.OpenLargeAngelFishPage());
        }

        [Test, Order(5)]
        public void ReturnToAngelFishPageAssert()
        {
            var largeAngelFishPage = new LargeAngelFishPage(webDriver);
            Assert.NotNull(largeAngelFishPage.ReturnToAngelFishPage());
        }

        [Test, Order(6)]
        public void AddToShoppingCartAssert()
        {
            var angelFishPage = new AngelFishPage(webDriver);
            Assert.NotNull(angelFishPage.AddToShoppingCart(angelFishPage.item1));
        }
    }
}
