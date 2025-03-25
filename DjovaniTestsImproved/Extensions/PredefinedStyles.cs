using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjovaniTestsImproved.Extensions
{
    public static class PredefinedStyles
    {
        public static WebElementStyle ButtonStyle()
        {
            return new WebElementStyle
            {
                Color = "rgba(111, 117, 122, 0.75)",
                FontSize = "16px",
                Display = "block"
            };
        }
    }
}
