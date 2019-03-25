using System.Web.Mvc;

using CMS.DocumentEngine.Types.MEDIO;
using CMS.SiteProvider;

using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;

using MEDIOClinic.Models;

namespace MEDIOClinic.Controllers
{
    public class HomeController : Controller
    {
        // GET: Loads and displays the site's Home page
        public ActionResult Index()
        {
            // Retrieves the Home page using the 'GetHome' method from the page type's generated provider
            Home homeNode = HomeProvider.GetHome("/Home", "en-us", SiteContext.CurrentSiteName)
                                        .Columns("DocumentName", "DocumentID", "HomeHeader", "HomeTextHeading", "HomeText");

            // Returns a 404 error if retrieval is unsuccessful
            if (homeNode == null)
            {
                return HttpNotFound();
            }

            // Creates a new HomeViewModel instance based on the page data
            var homeModel = new HomeViewModel(homeNode);

            // Initializes the page builder with the DocumentID of the page
            HttpContext.Kentico().PageBuilder().Initialize(homeNode.DocumentID);

            


            return View(homeModel);
        }
    }
}