using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDay3.Filters
{
    public class TimeElapsedFilter: FilterAttribute, IActionFilter
    {
        Stopwatch watch;

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            watch.Stop();
            var totaltime = watch.ElapsedMilliseconds;
            filterContext.HttpContext.Response.Write("Total time is " + totaltime);
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            watch = Stopwatch.StartNew();
        }
    }
}