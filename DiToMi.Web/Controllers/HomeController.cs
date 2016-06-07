using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiToMi.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Consultant()
        {
            return View();
        }

        public ActionResult Products()
        {
            return Redirect("/");
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Training()
        {
            return View();
        }

        public ActionResult UnitTesting()
        {
            return View();
        }

        public ActionResult Logging()
        {
            return View();
        }

        public ActionResult Elasticsearch()
        {
            return View();
        }

        public ActionResult ElasticsearchAbout()
        {
            return View();
        }

        public ActionResult DotNetAndCSharp()
        {
            return View();
        }

        public ActionResult Architecture()
        {
            return View();
        }

        public ActionResult Agile()
        {
            return View();
        }

        public ActionResult WebDevelopment()
        {
            return View();
        }
    }
}
