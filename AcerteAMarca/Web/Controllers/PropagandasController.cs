using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dominio;
using Web.Models;

namespace Web.Controllers
{
    public class PropagandasController : Controller
    {
        private AcerteAMarcaContext db = new AcerteAMarcaContext();

        // GET: Propagandas
        public ActionResult Index()
        {
            return View(db.Propaganda.ToList());
        }

        // GET: Propagandas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Propaganda propaganda = db.Propaganda.Find(id);
            if (propaganda == null)
            {
                return HttpNotFound();
            }
            return View(propaganda);
        }

        // GET: Propagandas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Propagandas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id")] Propaganda propaganda)
        {
            if (ModelState.IsValid)
            {
                db.Propaganda.Add(propaganda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(propaganda);
        }

        // GET: Propagandas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Propaganda propaganda = db.Propaganda.Find(id);
            if (propaganda == null)
            {
                return HttpNotFound();
            }
            return View(propaganda);
        }

        // POST: Propagandas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id")] Propaganda propaganda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(propaganda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(propaganda);
        }

        // GET: Propagandas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Propaganda propaganda = db.Propaganda.Find(id);
            if (propaganda == null)
            {
                return HttpNotFound();
            }
            return View(propaganda);
        }

        // POST: Propagandas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Propaganda propaganda = db.Propaganda.Find(id);
            db.Propaganda.Remove(propaganda);
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
