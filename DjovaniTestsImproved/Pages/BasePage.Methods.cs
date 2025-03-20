using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DjovaniTestsImproved.Pages
{
    public abstract partial class BasePage
    {
        public IWebDriver Driver { get; set; }

        public WebDriverWait Wait { get; set; }

        public IJavaScriptExecutor JsExecutor { get; set; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            JsExecutor = (IJavaScriptExecutor)Driver;
        }
    }
}
