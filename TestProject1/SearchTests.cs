using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WikiTestsSample
{
    public class SearchTests
    {
        private IWebDriver _driver;

        public WikiHomePage WikiHomePage { get; set; }

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();

            WikiHomePage = new WikiHomePage(_driver);

        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
            _driver.Dispose();
        }

        [Test]
        public void TitleWasCorrect_When_OpenWikipediaPage()
        {
            _driver.Url = "https://www.wikipedia.org/";

            Assert.AreEqual("Wikipedia", _driver.Title, "Title is not as expected");
        }

        [Test]
        public void TitleWasCorrect_When_OpenWikipediaPageTest()
        {
            _driver.Url = "https://www.wikipedia.org/";

            WikiHomePage.SubmitForm("Test");

            WikiHomePage.AssertTitle("Test - Wikipedia");
        }
    }
}