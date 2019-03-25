using System.Linq;
using System.Web.Mvc;

using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.MEDIO;

using MEDIOClinic.Models;

namespace MEDIOClinic.Controllers
{
    public class MenuController : Controller
    {
        // GET: Loads and displays the site's navigation menu
        public ActionResult GetMenu()
        {
            // Loads all menu items using the page type's generated provider
            // Uses the menu item order from the content tree in the Kentico 'Pages' application
            var menuItems = MenuItemProvider.GetMenuItems()
                .Columns("MenuItemText", "MenuItemPage")
                .OrderBy("NodeOrder");

            // Loads the pages selected within the menu items
            // The data only contains values of the NodeGUID identifier column
            var pages = DocumentHelper.GetDocuments()
                .WhereIn("NodeGUID", menuItems.Select(item => item.MenuItemPage).ToList())
                .Columns("NodeGUID");

            // Creates a collection of view models based on the menu item and page data
            var model = menuItems.Select(item => new MenuItemViewModel()
            {
                MenuItemText = item.MenuItemText,
                // Gets the URL for the page whose GUID matches the given menu item's selected page
                MenuItemRelativeUrl = pages.FirstOrDefault(page => page.NodeGUID == item.MenuItemPage).RelativeURL
            });

            return PartialView("_SiteMenu", model);
        }
    }
}