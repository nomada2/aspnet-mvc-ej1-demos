﻿using MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class RibbonController : Controller
    {
        //
        // GET: /Adaptive/
        List<FontFamily> fontFamilyadapt = new List<FontFamily>();
        List<FontPoint> fontPointadapt = new List<FontPoint>();

        public ActionResult Adaptive()
        {
            return View();
        }
     
        public ActionResult AdaptiveRibbon()
        {
            fontFamilyadapt.Add(new FontFamily { text = "Segoe UI" });
            fontFamilyadapt.Add(new FontFamily { text = "Arial" });
            fontFamilyadapt.Add(new FontFamily { text = "Times New Roman" });
            fontFamilyadapt.Add(new FontFamily { text = "Tahoma" });
            fontFamilyadapt.Add(new FontFamily { text = "Helvetica" });
            ViewBag.datasource = fontFamilyadapt;
            fontPointadapt.Add(new FontPoint { text = "1pt" });
            fontPointadapt.Add(new FontPoint { text = "2pt" });
            fontPointadapt.Add(new FontPoint { text = "3pt" });
            fontPointadapt.Add(new FontPoint { text = "4pt" });
            fontPointadapt.Add(new FontPoint { text = "5pt" });
            ViewBag.datasource1 = fontPointadapt;
            return PartialView();
        }
    }
}
