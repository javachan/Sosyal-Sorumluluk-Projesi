﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sosyal_Sorumluluk_Projesi.Models;

namespace Sosyal_Sorumluluk_Projesi.Controllers
{
    public class HomeController : Controller
    {
        siteDb db = new siteDb();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        } 

        public ActionResult Hakkimizda()
        {
            return View();
        } 

        public ActionResult Iletisim()
        {
            return View();
        }
        public ActionResult ProjePartial()
        {

            return View(db.projes.ToList());
        } 

      

    }
}