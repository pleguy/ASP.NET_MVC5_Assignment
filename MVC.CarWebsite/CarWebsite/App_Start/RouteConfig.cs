using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Rento
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
            name: "Car_List",
            url: "Home/Car_List",
            defaults: new { controller = "Home", action = "Car_List" }
            );

            routes.MapRoute(
                name: "Car_Info",
                url: "Home/Car_Info/{id}",
                defaults: new { controller = "Home", action = "Car_Info" }
            );
        }     
    }
}
