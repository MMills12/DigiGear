using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainingWebsite.Models;

namespace TrainingWebsite.Controllers
{
    public class SchedulesViewController : Controller
    {
        private TrainingWebsiteContext db = new TrainingWebsiteContext();
        // GET: SchedulesView
        public ActionResult Index()
        {
            return View(db.Schedules.ToList());
        }

        // GET: SchedulesView/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SchedulesView/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SchedulesView/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SchedulesView/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SchedulesView/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SchedulesView/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SchedulesView/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
