using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Contact()
        {
            return View();
        }

        public ViewResult About()
        {
            return View();
        }

        public ViewResult Mission()
        {
            return View();
        }
    }
}