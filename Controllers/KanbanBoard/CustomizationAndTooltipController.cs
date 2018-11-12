using MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class KanbanBoardController : Controller
    {
        //
        // GET: /CustomizationAndTooltip/

        public ActionResult CustomizationAndTooltip()
        {
            var data = new NorthwindDataContext().Tasks.Take(30).ToList();
            ViewBag.datasource = data;
            return View();
        }

    }
}
