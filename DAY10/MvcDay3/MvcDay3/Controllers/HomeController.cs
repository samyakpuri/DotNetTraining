using MvcDay3.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDay3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [TimeElapsedFilter]
        public ActionResult Index()
        {
            return View();
        }
    }
}