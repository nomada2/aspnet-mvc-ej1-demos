﻿using MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class ScheduleController : Controller
    {
        //
        // GET: /API/

        public ActionResult AppointmentSearch()
        {
            var DataSource = new ScheduleDataDataContext().DefaultSchedules.ToList();
            ViewBag.dataSource = DataSource;
            return View();
        }

    }
}
