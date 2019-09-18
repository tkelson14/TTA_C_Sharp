using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        private CarInsuranceEntities db = new CarInsuranceEntities();

        // GET: Admin
        public ActionResult Index()
        {
            return View(db.Quotes.ToList());
        }

        // GET: Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quote Quote = db.Quotes.Find(id);
            if (Quote == null)
            {
                return HttpNotFound();
            }
            return View(Quote);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,CarYear,CarMake,CarModel,DUI,FullCoverageLiability,Quotes,DateOfBirth")] Quote Quote)
        {
            if (ModelState.IsValid)
            {
                db.Quotes.Add(Quote);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Quote);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quote Quote = db.Quotes.Find(id);
            if (Quote == null)
            {
                return HttpNotFound();
            }
            return View(Quote);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,CarYear,CarMake,CarModel,DUI,FullCoverageLiability,Quotes,DateOfBirth")] Quote Quote)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Quote).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Quote);
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quote Quote = db.Quotes.Find(id);
            if (Quote == null)
            {
                return HttpNotFound();
            }
            return View(Quote);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Quote Quote = db.Quotes.Find(id);
            db.Quotes.Remove(Quote);
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