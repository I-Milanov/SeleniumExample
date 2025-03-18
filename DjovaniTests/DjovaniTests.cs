// 1. Create Nunit Project
// 2. Add Selenium nuget Packages (Web Driveer + Chrome driver)
// 3. Chreate _driver field and inialize Chrome driver
// 4. Configure OneTimeSetup, Setup and TearDown
// 5. Create tests

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DjovaniTests
{
    public class DjovaniTests
    {
        private IWebDriver _driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver = new ChromeDriver();
        }

        [SetUp]
        public void SetUp()
        {
            _driver.Url = "https://www.djovani.com/%D0%BD%D0%B0%D1%87%D0%B0%D0%BB%D0%BE";
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
            _driver.Dispose();
        }

        [Test]
        public void CurrentDateWasVisibleOnPage_When_NavigateOnLunchPage()
        {
            //1. Press menu button to redirect on lunch page
            var lunchNavMenuButon = _driver.FindElement(By.XPath("//ul[contains(concat(' ',normalize-space(@class),' '),' navbar-nav ')]//a[text()='Обедно Меню']"));
            lunchNavMenuButon.Click();

            //2. Get Text of the lunch menu date
            var currentDayElement = _driver.FindElement(By.XPath("//h1/sup"));
            var actualCurrentDay = currentDayElement.Text;
            var expectedDay = DateTime.Today.ToString("dd.MM.yyyy");

            //3. Assert that date is today
            Assert.That(expectedDay.Equals(actualCurrentDay), "test");
        }
    }
}
