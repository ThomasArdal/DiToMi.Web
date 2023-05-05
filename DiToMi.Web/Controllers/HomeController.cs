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
            return RedirectPermanent("https://triforkacademy.dk/?ref=ditomi.dk");
        }

        public ActionResult UnitTesting()
        {
            return RedirectPermanent("https://triforkacademy.dk/?ref=ditomi.dk");
        }

        public ActionResult Logging()
        {
            return RedirectPermanent("https://triforkacademy.dk/?ref=ditomi.dk");
        }

        public ActionResult Elasticsearch()
        {
            return RedirectPermanent("https://triforkacademy.dk/?ref=ditomi.dk");
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

        public ActionResult Azure()
        {
            return View();
        }
    }
}
