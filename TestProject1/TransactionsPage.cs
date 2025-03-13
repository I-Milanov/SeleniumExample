namespace WikiTestsSample
{
    public static class TransactionsPage
    {
        public static string SubMenuButtonXpath(string buttonName)
        {
            string xpath = $"//*[contains(concat(' ',normalize-space(@class),' '),' submenu ')]//a[text()='{buttonName}']";

            return xpath;
        }

        public static string TransactionButtonXpath()
        {
            string xpath = SubMenuButtonXpath("Transaction");

            return xpath;
        }

        public static string SubMenuButtonXpathShort(string buttonName) => $"//*[contains(concat(' ',normalize-space(@class),' '),' submenu ')]//a[text()='{buttonName}']";

        public static string TransactionButtonXpathShort() => SubMenuButtonXpathShort("Transaction");

    }
}
