using MVCHeadStart.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHeadStart.Controllers
{
    public class HomeController : BaseClass
    {
        // GET: Home
        public ActionResult Index(string id,int? id2)
        {
            switch(id)
            {
                case "ContentResult":
                    return Content("This is Content");
                case "Empty":
                    return Empty();
                case "Json":
                    Person person = new Person()
                    {
                        Id = 1,
                        Name = "Json Person",
                        Age = 23
                    };
                    return Json(person,JsonRequestBehavior.AllowGet);
                case "Javascript":
                    return JavaScript("This is a script");
                case "RedirectToAction":
                    return RedirectToAction("Test");
                case "RedirectToActionPermanent":
                    return RedirectToActionPermanent("Test");
                case "RedirectToRoute":
                    return RedirectToRoute("MyRoute");
                case "RedirectToRoutePermanent":
                    return RedirectToRoutePermanent("MyRoute");
                case "Redirect":
                    return Redirect("https:\\www.google.com");
                case "RedirectPermanent":
                    return RedirectPermanent("https:\\www.yahoo.com");
                case "FilePathResult":
                    return new FilePathResult(Server.MapPath("~/Files/Beginning Visual C#.pdf"), "application/pdf");
                case "HttpUnauthorizedResult":
                    return new HttpUnauthorizedResult();
                case "HttpNotFoundResult":
                    return new HttpNotFoundResult();
                case "HttpStatusCodeResult":
                    return new HttpStatusCodeResult(402,"Custom Error");
                default:
                    break;
            }
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}