using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DiToMi.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("forside", "", new {controller = "Home", action = "Index"});
            routes.MapRoute("omos", "about", new {controller = "Home", action = "About"});
            routes.MapRoute("kontakt", "contact", new {controller = "Home", action = "Contact"});
            routes.MapRoute("produkter", "products", new {controller = "Home", action = "Products"});
            routes.MapRoute("kurser", "training", new {controller = "Home", action = "Training"});
            routes.MapRoute("unittest", "training/unittesting", new {controller = "Home", action = "UnitTesting"});
            routes.MapRoute("trainingelasticsearch", "training/elasticsearch", new {controller = "Home", action = "Elasticsearch"});
            routes.MapRoute("elasticsearch", "elasticsearch", new {controller = "Home", action = "ElasticsearchAbout"});
            routes.MapRoute("dotnetandcsharp", "dotnetandcsharp", new { controller = "Home", action = "DotNetAndCSharp" });
            routes.MapRoute("logging", "training/logging", new {controller = "Home", action = "Logging"});
            routes.MapRoute("konsulent", "consultants", new {controller = "Home", action = "Consultant"});
            routes.MapRoute("webdevelopment", "webdevelopment", new {controller = "Home", action = "WebDevelopment"});
            routes.MapRoute("architecture", "architecture", new {controller = "Home", action = "Architecture"});
            routes.MapRoute("agile", "agile", new {controller = "Home", action = "Agile"});

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}