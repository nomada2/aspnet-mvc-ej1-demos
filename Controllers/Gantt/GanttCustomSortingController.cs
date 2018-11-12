﻿using System;
using System.Collections.Generic;
using System.Linq;
using MVCSampleBrowser.Models;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript;

namespace MVCSampleBrowser.Controllers
{
    public partial class GanttController : Controller
    {
        //
        // GET: /GanttCustomSorting/

        public ActionResult GanttCustomSorting()
        {
            var DataSource = GanttDefaultData.GetData();
            ViewBag.datasource = DataSource;
            return View();
        }

    }
}
