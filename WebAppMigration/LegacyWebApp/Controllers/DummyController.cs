using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LegacyWebApp.Controllers
{
    public class DummyController : Controller
    {
        // GET: Dummy
        public ActionResult Index()
        {
            return View();
        }
    }
}