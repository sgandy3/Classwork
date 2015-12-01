using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FlashDouble.Models;

namespace FlashDouble.Controllers
{
    public class ProfilesController : Controller
    {
        private UserProfileEntities db = new UserProfileEntities();

        // GET: Profiles
        public ActionResult Index()
        {
            var profiles = db.Profiles.Include(p => p.Ethnicity).Include(p => p.Experience).Include(p => p.Gender).Include(p => p.Genre);
            return View(profiles.ToList());
        }

        // GET: Profiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profile profile = db.Profiles.Find(id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            return View(profile);
        }

        // GET: Profiles/Create
        public ActionResult Create()
        {
            ViewBag.EthnicityID = new SelectList(db.Ethnicities, "EthnicityID", "EthnicityID");
            ViewBag.ExperienceID = new SelectList(db.Experiences, "ExperienceID", "ExperienceID");
            ViewBag.GenderID = new SelectList(db.Genders, "GenderID", "GenderID");
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreID");
            return View();
        }

        // POST: Profiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProfileID,FirstName,LastName,AgeRange,Height,Weight,Bust,Waist,Dress,Hips,Cup,Shoe,ProfilePictureURL,ProfileVideoURL,EthnicityID,GenreID,ExperienceID,GenderID")] Profile profile)
        {
            if (ModelState.IsValid)
            {
                db.Profiles.Add(profile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EthnicityID = new SelectList(db.Ethnicities, "EthnicityID", "EthnicityID", profile.EthnicityID);
            ViewBag.ExperienceID = new SelectList(db.Experiences, "ExperienceID", "ExperienceID", profile.ExperienceID);
            ViewBag.GenderID = new SelectList(db.Genders, "GenderID", "GenderID", profile.GenderID);
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreID", profile.GenreID);
            return View(profile);
        }

        // GET: Profiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profile profile = db.Profiles.Find(id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            ViewBag.EthnicityID = new SelectList(db.Ethnicities, "EthnicityID", "EthnicityID", profile.EthnicityID);
            ViewBag.ExperienceID = new SelectList(db.Experiences, "ExperienceID", "ExperienceID", profile.ExperienceID);
            ViewBag.GenderID = new SelectList(db.Genders, "GenderID", "GenderID", profile.GenderID);
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreID", profile.GenreID);
            return View(profile);
        }

        // POST: Profiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProfileID,FirstName,LastName,AgeRange,Height,Weight,Bust,Waist,Dress,Hips,Cup,Shoe,ProfilePictureURL,ProfileVideoURL,EthnicityID,GenreID,ExperienceID,GenderID")] Profile profile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EthnicityID = new SelectList(db.Ethnicities, "EthnicityID", "EthnicityID", profile.EthnicityID);
            ViewBag.ExperienceID = new SelectList(db.Experiences, "ExperienceID", "ExperienceID", profile.ExperienceID);
            ViewBag.GenderID = new SelectList(db.Genders, "GenderID", "GenderID", profile.GenderID);
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreID", profile.GenreID);
            return View(profile);
        }

        // GET: Profiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profile profile = db.Profiles.Find(id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            return View(profile);
        }

        // POST: Profiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Profile profile = db.Profiles.Find(id);
            db.Profiles.Remove(profile);
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
