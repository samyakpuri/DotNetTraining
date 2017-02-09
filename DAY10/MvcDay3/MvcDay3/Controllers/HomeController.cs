using MvcDay3.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDay3.Controllers
{
    [CustomExceptionFilter]
    public class HomeController : Controller
    {
        // GET: Home
        [TimeElapsedFilter]
        public ActionResult Index(int a,int b)
        {
           // int a = 1, b = 0;
            int c = a / b;
            return View();
        }
    }
}