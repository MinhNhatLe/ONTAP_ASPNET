using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test_asp_mvc.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult New()
        {
            return View();
        }
    }
}