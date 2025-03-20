// 1. Create Nunit Project
// 2. Add Selenium nuget Packages (Web Driveer + Chrome driver)
// 3. Chreate _driver field and inialize Chrome driver
// 4. Configure OneTimeSetup, Setup and TearDown
// 5. Create tests

using DjovaniTestsImproved;
using DjovaniTestsImproved.Pages.HomePage;
using DjovaniTestsImproved.Pages.LunchPage;
using OpenQA.Selenium.Chrome;

namespace DjovaniTests
{
    public class DjovaniTests : BaseTests
    {
        public override ChromeOptions GetChromeOptions()
        {
            var chromeOptions = base.GetChromeOptions();
            // Download chrome version from here https://googlechromelabs.github.io/chrome-for-testing/#stable and unzip it
            // Binary: Chrome; Platform: win32/64
            chromeOptions.BinaryLocation = @"C:\Users\itmil\Downloads\chrome-win64\chrome.exe";

            return chromeOptions;
        }

        [Test]
        public void CurrentDateWasVisibleOnPage_When_NavigateOnLunchPage()
        {
            HomePage.LunchNavMenuButon.Click();

            LunchPage.AssertCurrentDayIsToday();
        }
    }
}
