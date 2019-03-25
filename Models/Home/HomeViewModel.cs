using CMS.DocumentEngine.Types.MEDIO;

namespace MEDIOClinic.Models
{
    public class HomeViewModel
    {
        // Defines the properties of the Home view model
        public string DocumentName { get; }
        public string HomeHeader { get; }
        public string HomeTextHeading { get; }
        public string HomeText { get; }


        // Maps the data from the Home page type's fields to the view model properties
        public HomeViewModel(Home homePage)
        {
            DocumentName = homePage.DocumentName;
            HomeHeader = homePage.Fields.Header;
            HomeTextHeading = homePage.Fields.TextHeading;
            HomeText = homePage.Fields.Text;
        }
    }
}