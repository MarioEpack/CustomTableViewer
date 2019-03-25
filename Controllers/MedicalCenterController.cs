using System.Web.Mvc;

using CMS.DocumentEngine.Types.MEDIO;
using CMS.SiteProvider;

using MEDIOClinic.Models;

namespace MEDIOClinic.Controllers
{
    public class MedicalCenterController : Controller
    {
        // GET: Loads and displays the site's Medical center page
        public ActionResult Index()
        {
            // Retrieves the Medical center page using the 'GetMedicalCenter' method from the page type's generated provider
            MedicalCenter medicalCenterNode =
                MedicalCenterProvider.GetMedicalCenter("/Medical-Center", "en-us", SiteContext.CurrentSiteName)
                                     .Columns("DocumentName", "MedicalCenterHeader", "MedicalCenterText");

            // Creates a new MedicalCenterViewModel instance based on the page data
            var medicalCenterModel = new MedicalCenterViewModel(medicalCenterNode);

            return View(medicalCenterModel);
        }
    }
}