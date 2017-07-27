using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EventsEntityFrmVs.Models;
using Microsoft.AspNet.Identity;

namespace EventsEntityFrmVs.Controllers
{
    [Authorize]
    public class EventController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Event
        [AllowAnonymous]
        public ActionResult Index()
        {
            string userID = User.Identity.GetUserId();
            var events = db.EventModels.Include(e => e.ApplicationUser).Where(e=>e.ApplicationUserId.Equals(userID));
            return View(events.ToList());
        }

        // GET: Event/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventModel eventModel = db.EventModels.Find(id);
            if (eventModel == null)
            {
                return HttpNotFound();
            }
            return View(eventModel);
        }

        // GET: Event/Create
        
        public ActionResult Create()
        {

            return View();
        }

        public ActionResult Show(int id)
        {

            var model = db.EventModels.Include(e => e.Title).Where(d => d.Equals(id));
            db.SaveChanges();
            return View();

        }

        // POST: Event/Create


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Details,Location,DateAndTime")] EventModel eventModel)
        {
            if (ModelState.IsValid)
            {
                eventModel.ApplicationUserId = User.Identity.GetUserId();
                db.EventModels.Add(eventModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eventModel);
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            string userID = User.Identity.GetUserId();
            EventModel eventModel = db.EventModels.Where(e => e.ApplicationUserId.Equals(userID)).First(e=>e.Id==id);
            if (eventModel == null)
            {
                return HttpNotFound();
            }
            return View(eventModel);
        }

        // POST: Event/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Details,Location,DateAndTime")] EventModel eventModel)
        {
            if (ModelState.IsValid)
            {
                eventModel.ApplicationUserId = User.Identity.GetUserId();
                db.Entry(eventModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eventModel);
        }

        // GET: Event/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventModel eventModel = db.EventModels.Find(id);
            if (eventModel == null)
            {
                return HttpNotFound();
            }
            return View(eventModel);
        }

        // POST: Event/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EventModel eventModel = db.EventModels.Find(id);
            db.EventModels.Remove(eventModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

       
       
    }
}
