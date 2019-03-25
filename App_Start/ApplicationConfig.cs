using Kentico.Web.Mvc;
using Kentico.Content.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace MEDIOClinic
{
    public class ApplicationConfig
    {
        public static void RegisterFeatures(IApplicationBuilder builder)
        {


            // Enables the Preview mode functionality, which allows your website editors to preview
            // the content of the MVC site's pages from the Kentico user interface.
            builder.UsePreview();

            // Enables the page builder feature, which allows editors to compose page content via
            // page builder widgets on preconfigured pages.
            builder.UsePageBuilder();
        }
    }
}