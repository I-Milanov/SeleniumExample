using System.Text.Json.Nodes;
using OpenQA.Selenium;

namespace WikiTestsSample
{
    public partial class WikiHomePage
    {
        public IWebElement SearchInput => _driver.FindElement(By.Id("searchInput"));

        public IWebElement SubmitButton => _driver.FindElement(By.XPath("//button[@type='submit']"));
    }
}
