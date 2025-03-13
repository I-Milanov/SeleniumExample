using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WikiTestsSample
{
    public partial class WikiHomePage
    {
        public IWebElement SearchInput => _driver.FindElement(By.Id("searchInput"));

        public IWebElement SubmitButton => _driver.FindElement(By.XPath("//button[@type='submit']"));
    }
}
