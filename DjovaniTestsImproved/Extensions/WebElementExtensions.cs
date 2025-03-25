using System.Reflection;
using OpenQA.Selenium;

namespace DjovaniTestsImproved.Extensions
{
    public static class WebElementExtensions
    {
        public static IWebElement ScrollTo(this IWebElement element)
        {
            var jsExecutor = (IJavaScriptExecutor)((IWrapsDriver)element).WrappedDriver;

            jsExecutor.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'});", element);

            return element;
        }

        public static void AssertCssStyles<TStyle>(this IWebElement element, TStyle expectedStyles) where TStyle : WebElementStyle
        {
            Type type = typeof(TStyle);
            PropertyInfo[] properties = type.GetProperties();
            var jsExecutor = (IJavaScriptExecutor)((IWrapsDriver)element).WrappedDriver;

            foreach (var property in properties)
            {
                var expectedStyle = property.GetValue(expectedStyles);

                if (expectedStyle == null)
                {
                    continue;
                }

                var propertyCss = ConvertToCssProperty(property.Name);

                string script = $"return window.getComputedStyle(arguments[0]).getPropertyValue('{propertyCss}');";
                string actualStyle = (string)jsExecutor.ExecuteScript(script, element);

                Assert.AreEqual(expectedStyle, actualStyle, $"Css style '{property.Name}' is not as expected");
            }
        }

        private static string ConvertToCssProperty(string propertyName)
        {
            return string.Concat(propertyName.Select((x, i) => i > 0 && char.IsUpper(x) ? "-" + x.ToString().ToLower() : x.ToString().ToLower()));
        }
    }
}
