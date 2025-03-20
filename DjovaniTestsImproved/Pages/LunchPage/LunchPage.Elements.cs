using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace DjovaniTestsImproved.Pages.LunchPage
{
    public partial class LunchPage : BasePage
    {
        public IWebElement CurrentDay => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h1/sup")));
    }
}
