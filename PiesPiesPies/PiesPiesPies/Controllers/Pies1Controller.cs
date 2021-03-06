﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PiesPiesPies.Models;

namespace PiesPiesPies.Controllers
{
    public class Pies1Controller : Controller
    {
        private PieShopEntities db = new PieShopEntities();

        // GET: Pies1
        public ActionResult Index()
        {
            return View(db.Pies.ToList());
        }

        // GET: Pies1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pie pie = db.Pies.Find(id);
            if (pie == null)
            {
                return HttpNotFound();
            }
            return View(pie);
        }

        // GET: Pies1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pies1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PieID,Flavor,Size,Price")] Pie pie)
        {
            if (ModelState.IsValid)
            {
                db.Pies.Add(pie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pie);
        }

        // GET: Pies1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pie pie = db.Pies.Find(id);
            if (pie == null)
            {
                return HttpNotFound();
            }
            return View(pie);
        }

        // POST: Pies1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PieID,Flavor,Size,Price")] Pie pie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pie);
        }

        // GET: Pies1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pie pie = db.Pies.Find(id);
            if (pie == null)
            {
                return HttpNotFound();
            }
            return View(pie);
        }

        // POST: Pies1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pie pie = db.Pies.Find(id);
            db.Pies.Remove(pie);
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
