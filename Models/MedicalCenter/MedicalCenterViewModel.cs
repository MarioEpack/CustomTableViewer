using CMS.DocumentEngine.Types.MEDIO;

namespace MEDIOClinic.Models
{
    public class MedicalCenterViewModel
    {
        // Defines the properties of the MedicalCenter view model
        public string DocumentName { get; }
        public string MedicalCenterHeader { get; }
        public string MedicalCenterText { get; }

        // Maps the data from the MedicalCenter page type's fields to the view model properties
        public MedicalCenterViewModel(MedicalCenter medicalCenterPage)
        {
            DocumentName = medicalCenterPage.DocumentName;
            MedicalCenterHeader = medicalCenterPage.Fields.Header;
            MedicalCenterText = medicalCenterPage.Fields.Text;
        }
    }
}