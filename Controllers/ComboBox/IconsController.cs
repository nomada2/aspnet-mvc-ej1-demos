﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class ComboBoxController : Controller
    {
        //
        // GET: /Icons/

        public ActionResult Icons()
        {
            ViewBag.datasource = IconCss.GetIconList();
            return View();
        }


    }
   
}
