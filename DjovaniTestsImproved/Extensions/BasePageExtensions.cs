using DjovaniTestsImproved.Pages;
using OpenQA.Selenium;

namespace DjovaniTestsImproved.Extensions
{
    public static class BasePageExtensions
    {
        public static void ScrollToElement(this BasePage page, IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor JsExecutor = (IJavaScriptExecutor)driver;

            JsExecutor.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'});", element);
        }
    }
}
