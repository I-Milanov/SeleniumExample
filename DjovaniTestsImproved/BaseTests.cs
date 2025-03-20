using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using DjovaniTestsImproved.Pages.HomePage;
using DjovaniTestsImproved.Pages.LunchPage;

namespace DjovaniTestsImproved
{
    public class BaseTests
    {
        public IWebDriver Driver { get; set; }

        public HomePage HomePage => new HomePage(Driver);
        public LunchPage LunchPage => new LunchPage(Driver);

        /// <summary>
        /// Get chrome options you may override the method when need new options;
        /// </summary>
        /// <returns></returns>
        public virtual ChromeOptions GetChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            return options;
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ChromeOptions options = GetChromeOptions();

            Driver = new ChromeDriver(options);
        }

        [SetUp]
        public void SetUp()
        {
            //ToDo (Ivaylo) 2025.03.20 Remove the following line when the problem with database connection is resolved
            WaitForUserInteraction();
            Driver.Url = "https://www.djovani.com/%D0%BD%D0%B0%D1%87%D0%B0%D0%BB%D0%BE";
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Driver.Quit();
            Driver.Dispose();
        }

        public void WaitForUserInteraction(int time = 2000)
        {
            Thread.Sleep(time);
        }
    }
}
