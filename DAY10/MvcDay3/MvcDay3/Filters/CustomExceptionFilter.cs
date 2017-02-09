using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDay3.Filters
{
    public class CustomExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            String message = "Custom Exception";
            filterContext.ExceptionHandled = true;
            filterContext.Controller.ViewBag.OnException = message;
            filterContext.HttpContext.Response.Write(" "+message);
            filterContext.Result = new ViewResult() { ViewName = "~/Views/Home/Index.cshtml" };
        }
    }
}