﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers.TreeGrid
{
    public partial class TreeGridController : Controller
    {
        //
        // GET: /Default/

        public ActionResult TreeGridSelection()
        {
            ViewBag.dataSource = this.GetDefaultData();
            return View();
        }
     

    }
}
