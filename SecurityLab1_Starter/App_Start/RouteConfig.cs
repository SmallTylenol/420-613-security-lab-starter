using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SecurityLab1_Starter {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Original",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "BlankURL",
                url: "",
                defaults: new { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
                name: "HomeRoute",
                url: "Home/{action}",
                new { controller = "Home", action = "Index" },
                new { action = @"^Index$|^About$|^Contact$" }
            );

            routes.MapRoute(
                name: "InventoryRoute",
                url: "Inventory/{action}",
                new { controller = "Inventory", action = "Index" },
                new { action = @"^Index$" }
            );


            routes.MapRoute(
                name: "CatchAll",
                url: "{*url}",
                defaults: new { controller = "Error", action = "NotFound" }
            );

            routes.MapRoute(
                name: "ErrorRoute",
                url: "Error/{action}",
                new { controller = "Error", action = "NotFound" },
                new { action = @"^NotFound$" }
            );
        }
    }
}
