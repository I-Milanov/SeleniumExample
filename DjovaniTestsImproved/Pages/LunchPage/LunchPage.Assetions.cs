using DjovaniTestsImproved.Extensions;

namespace DjovaniTestsImproved.Pages.LunchPage
{
    public partial class LunchPage : BasePage
    {
        public void AssertCurrentDayIsToday()
        {
            CurrentDay.ScrollTo(Driver);
            var actualCurrentDay = CurrentDay.Text;
            var expectedDay = DateTime.Today.ToString("dd.MM.yyyy");

            Assert.AreEqual(expectedDay, actualCurrentDay, "Current day is not correct");
        }
    }
}
