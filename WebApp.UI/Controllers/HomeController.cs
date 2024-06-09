﻿using System.Web.Mvc;

namespace WebApp.UI.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //Home/Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}