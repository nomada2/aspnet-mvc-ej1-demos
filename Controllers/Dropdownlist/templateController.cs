﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;



namespace MVCSampleBrowser.Controllers
{
    public partial class DropdownlistController : Controller
    {
        //
        // GET: /Dropdowntemplate/
        List<EmployeeSpecialists> emp = new List<EmployeeSpecialists>();
        public ActionResult template()
        {
            emp.Add(new EmployeeSpecialists { text = "Erik Linden", eimg = "3", desig = "Representative", country = "England" });
            emp.Add(new EmployeeSpecialists { text = "John Linden", eimg = "6", desig = "Representative", country = "Norway" });
            emp.Add(new EmployeeSpecialists { text = "Louis", eimg = "7", desig = "Representative", country = "Australia" });
            emp.Add(new EmployeeSpecialists { text = "Lawrence", eimg = "8", desig = "Representative", country = "India" });
            ViewBag.datasource = emp;
            return View();
        }

    }
}
