using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Kentico.Content.Web.Mvc;
using Kentico.Web.Mvc;
using MEDIOClinic;

namespace MedioClinic
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            // Gets the ApplicationBuilder instance
            // Allows you to enable and configure Kentico MVC features
            ApplicationBuilder builder = ApplicationBuilder.Current;
            builder.UsePreview();

            // Enables and configures selected Kentico ASP.NET MVC integration features
            ApplicationConfig.RegisterFeatures(ApplicationBuilder.Current);

            // Registers routes including system routes for enabled features
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
