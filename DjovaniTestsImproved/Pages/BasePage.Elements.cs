using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace DjovaniTestsImproved.Pages
{
    public partial class BasePage
    {
        //IWebElement LunchNavMenuButon
        //{
        //    get
        //    {
        //        return Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//ul[contains(concat(' ',normalize-space(@class),' '),' navbar-nav ')]//a[text()='Обедно меню']")));
        //    }
        //}

        protected IWebElement NavMenuButon(string navigationText) => Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//ul[contains(concat(' ',normalize-space(@class),' '),' navbar-nav ')]//a[text()='{navigationText}']")));

        public IWebElement LunchNavMenuButon => NavMenuButon("Обедно Mеню");

        public IWebElement ForUsNavMenu => NavMenuButon("За Нас");
    }
}
