﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page 2";

            return View();
        }
        public ActionResult Inschrijf(int Id)
        {
            ViewBag.Title = "Home Page 2";
            ViewBag.Id = Id;
            return View();
        }
    }
}
