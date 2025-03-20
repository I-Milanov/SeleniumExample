using OpenQA.Selenium;

namespace DjovaniTestsImproved.Extensions
{
    public static class WebElementExtensions
    {
        public static IWebElement ScrollTo(this IWebElement element, IWebDriver driver)
        {
            IJavaScriptExecutor JsExecutor = (IJavaScriptExecutor)driver;

            JsExecutor.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'});", element);

            return element;
        }
    }
}
