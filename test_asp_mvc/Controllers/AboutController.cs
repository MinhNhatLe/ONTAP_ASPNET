using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_asp_mvc.Models;

namespace test_asp_mvc.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult About()
        {
            var ds5May = new MayTinh().KhoiTao5May();
            return View(ds5May);
        }
    }
}