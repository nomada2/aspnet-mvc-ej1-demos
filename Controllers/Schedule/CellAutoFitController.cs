﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class ScheduleController : Controller
    {
        //
        // GET: /CellAutoFit/
        List<Rooms> Cellowners = new List<Rooms>();

        public ActionResult CellAutoFit()
        {
            var DataSource = new ScheduleDataDataContext().MultipleResources.ToList();
            ViewBag.datasource = DataSource;

            Cellowners.Add(new Rooms { text = "Nancy", id = "1", color = "#f8a398" });
            Cellowners.Add(new Rooms { text = "Steven", id = "3", color = "#56ca85" });
            Cellowners.Add(new Rooms { text = "Michael", id = "5", color = "#51a0ed" });
            ViewBag.Owners = Cellowners;

            List<String> resources = new List<String>();
            resources.Add("Owners");
            ViewBag.Resources = resources;
            return View();
        }

    }
}
