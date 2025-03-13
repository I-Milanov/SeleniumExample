namespace WikiTestsSample
{
    public partial class WikiHomePage
    {
       public void AssertTitle(string expectedTitle)
        {
            Assert.AreEqual(expectedTitle, _driver.Title, "Title is not as expected");
        }
    }
}
