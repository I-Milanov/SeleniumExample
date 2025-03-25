using DjovaniTestsImproved;
using DjovaniTestsImproved.Extensions;
using DjovaniTestsImproved.Pages.HomePage;
using DjovaniTestsImproved.Pages.LunchPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// What was done:
// 1. Create Pages with base page
// 2. Move the code in the page
// 3. Add wait strategies for the elements
// 4. Create a BaseTestClass
// 5. Move genereric logic in the BaseTestClass
// 6. Add IJavaScriptExecutor

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

        [Test]
        public void АssertElementStyleIsCorrect()
        {
            Driver.Navigate().GoToUrl("https://www.selenium.dev/documentation/webdriver/elements/");
            IWebElement element = Driver.FindElement(By.XPath("//a[@Id='m-documentationoverview']"));

            element.AssertCssStyles(new ButtonStyle());          
        }

    }
}
