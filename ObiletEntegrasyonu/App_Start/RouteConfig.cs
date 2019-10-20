using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ObiletEntegrasyonu
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
 

            routes.MapRoute(
            name: "SpecificRouteSefer",

            url: "{controller}/{action}/{originDestination}/{depactureTime}",

            defaults: new { controller = "Home", action = "Seferler", originDestination = UrlParameter.Optional, depactureTime = UrlParameter.Optional}
        );
        }
    }
}
