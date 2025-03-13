using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace WikiTestsSample
{
    public partial class WikiHomePage
    {
        IWebDriver _driver;

        public WikiHomePage(IWebDriver driver)
        {
            _driver = driver;  
        }

        public void SubmitForm(string text)
        {
            SearchInput.SendKeys(text);
            SubmitButton.Click();
        }
    }
}
