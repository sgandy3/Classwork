using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{
    public class MoviesDbsController : Controller
    {
        private MovieDbContext db = new MovieDbContext();

        // GET: MoviesDbs
        public ActionResult Index()
        {
            return View(db.Movies.ToList());
        }

        // GET: MoviesDbs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieDb movieDb = db.Movies.Find(id);
            if (movieDb == null)
            {
                return HttpNotFound();
            }
            return View(movieDb);
        }

        // GET: MoviesDbs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MoviesDbs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Director,Date")] MovieDb movieDb)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movieDb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movieDb);
        }

        // GET: MoviesDbs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieDb movieDb = db.Movies.Find(id);
            if (movieDb == null)
            {
                return HttpNotFound();
            }
            return View(movieDb);
        }

        // POST: MoviesDbs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Director,Date")] MovieDb movieDb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movieDb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movieDb);
        }

        // GET: MoviesDbs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieDb movieDb = db.Movies.Find(id);
            if (movieDb == null)
            {
                return HttpNotFound();
            }
            return View(movieDb);
        }

        // POST: MoviesDbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MovieDb movieDb = db.Movies.Find(id);
            db.Movies.Remove(movieDb);
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
