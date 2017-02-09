using MVCDemo.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        CustomEntities db = new CustomEntities();
        public ActionResult Index()
        {
            return View(db.People.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                db.People.Add(person);
                db.SaveChanges();
                TempData["Saved"] = "Added Person Successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            Person person = db.People.Find(id);
            return View(person);
        }

        [HttpPost]
        public ActionResult Delete(Person person)
        {
            //Person person = db.People.Find(id);
            db.Entry(person).State = EntityState.Deleted;
            db.SaveChanges();
            TempData["Saved"] = "Person was deleted Successfully";
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Person person = db.People.Find(id);
            return View(person);
        }

        public ActionResult Edit(int id)
        {
            Person person = db.People.Find(id);
            return View(person);
        }

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                db.People.Attach(person);
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Saved"] = "Person Edited Successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}