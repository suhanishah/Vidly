﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes(); // to enable attribute routing
                                            // attributes on controller

            //old way of maping routes
            //routes.MapRoute("MoviesReleaseDate", 
            //    "movies/released/{year}/{month}",
            //    new {controller="Movies", action ="ByReleaseDate"},
            //    new{year = @"\d{4}", month = @"\d{2}"});

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
