﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PIN_Projekt
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ProductsCreate",
                url: "Products/Create",
                defaults: new { controller = "Proizvods", action = "Create" }
            );

            routes.MapRoute(
                name: "ProductsbyCategorybyPage",
                url: "Products/{category}/Page{page}",
                defaults: new { controller = "Proizvods", action = "Index" }
            );

            routes.MapRoute(
                name: "ProductsbyPage",
                url: "Products/Page{page}",
                defaults: new { controller = "Proizvods", action = "Index" }
            );

            routes.MapRoute(
                name: "ProductsbyCategory",
                url: "Products/{category}",
                defaults: new { controller = "Proizvods", action = "Index" }
            );

            routes.MapRoute(
                name: "ProductsIndex",
                url: "Products",
                defaults: new { controller = "Proizvods", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Categories", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}