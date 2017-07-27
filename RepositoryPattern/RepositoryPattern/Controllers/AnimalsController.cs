using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Repository;
using RepositoryPattern.Models;
using RepositoryPattern.Mapper;

namespace RepositoryPattern.Controllers
{
    public class AnimalsController : Controller
    {
        private AnimalContext db = new AnimalContext();

        // GET: Animals
        public ActionResult Index()
        {
            var uiModels = db.Animals
                    .ToList()
                    .Select(a => a.ToModelUi());
                 
            return View(uiModels);
        }

        // GET: Animals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Animal animal = db.Animals.Find(id).ToModelUi();
            if (animal == null)
            {
                return HttpNotFound();
            }
            return View(animal);
        }

        // GET: Animals/Create
        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Animal animal)
        {
            if (ModelState.IsValid)
            {
                db.Animals.Add(animal.ToModelDb());
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(animal);
        }

       
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Animal animal = db.Animals.Find(id).ToModelUi();
            if (animal == null)
            {
                return HttpNotFound();
            }
            return View(animal);
        }

     

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Animal animal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(animal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(animal);
        }

       

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Animal animal = db.Animals.Find(id).ToModelUi();
            if (animal == null)
            {
                return HttpNotFound();
            }
            return View(animal);
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Animal animal = db.Animals.Find(id).ToModelUi();
            db.Animals.Remove(animal.ToModelDb());
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
