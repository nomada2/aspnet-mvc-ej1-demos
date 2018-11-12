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
        // GET: /Methods/
        List<FontFamily> fontFamily2 = new List<FontFamily>();
        List<FontPoint> fontPoint2 = new List<FontPoint>();
        public ActionResult Methods()
        {
            fontFamily2.Add(new FontFamily { text = "Segoe UI" });
            fontFamily2.Add(new FontFamily { text = "Arial" });
            fontFamily2.Add(new FontFamily { text = "Times New Roman" });
            fontFamily2.Add(new FontFamily { text = "Tahoma" });
            fontFamily2.Add(new FontFamily { text = "Helvetica" });
            ViewBag.datasource = fontFamily2;
            fontPoint2.Add(new FontPoint { text = "1pt" });
            fontPoint2.Add(new FontPoint { text = "2pt" });
            fontPoint2.Add(new FontPoint { text = "3pt" });
            fontPoint2.Add(new FontPoint { text = "4pt" });
            fontPoint2.Add(new FontPoint { text = "5pt" });
            ViewBag.datasource1 = fontPoint2;
            return View();
        }

    }
}
