﻿using MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class GridController : Controller
    {
        //
        // GET: /CustomSummary/

        public ActionResult CustomSummary()
        {
            var DataSource = OrderRepository.GetAllRecords().ToList();
            ViewBag.dataSource = DataSource;
            return View();
        }

    }
}
