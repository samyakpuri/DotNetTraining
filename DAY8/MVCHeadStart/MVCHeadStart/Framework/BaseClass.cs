using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHeadStart.Framework
{
    public class BaseClass : Controller
    {
        protected new EmptyResult Content(String st)
        {
            return new EmptyResult();
        }

        protected new EmptyResult Empty()
        {
            return new EmptyResult();
        }
    }
}