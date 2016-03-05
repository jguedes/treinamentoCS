using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dominio;
using DAL;

namespace Web.Controllers
{
    public class AcerteAMarcasController : Controller
    {
        private AcerteAMarcaContext db = new AcerteAMarcaContext();

        // GET: AcerteAMarcas
        public ActionResult Index()
        {
            return View(db.AcerteAMarca.ToList());
        }

        // GET: AcerteAMarcas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcerteAMarca acerteAMarca = db.AcerteAMarca.Find(id);
            if (acerteAMarca == null)
            {
                return HttpNotFound();
            }
            return View(acerteAMarca);
        }

        // GET: AcerteAMarcas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AcerteAMarcas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id")] AcerteAMarca acerteAMarca)
        {
            if (ModelState.IsValid)
            {
                db.AcerteAMarca.Add(acerteAMarca);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(acerteAMarca);
        }

        // GET: AcerteAMarcas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcerteAMarca acerteAMarca = db.AcerteAMarca.Find(id);
            if (acerteAMarca == null)
            {
                return HttpNotFound();
            }
            return View(acerteAMarca);
        }

        // POST: AcerteAMarcas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id")] AcerteAMarca acerteAMarca)
        {
            if (ModelState.IsValid)
            {
                db.Entry(acerteAMarca).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(acerteAMarca);
        }

        // GET: AcerteAMarcas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcerteAMarca acerteAMarca = db.AcerteAMarca.Find(id);
            if (acerteAMarca == null)
            {
                return HttpNotFound();
            }
            return View(acerteAMarca);
        }

        // POST: AcerteAMarcas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            AcerteAMarca acerteAMarca = db.AcerteAMarca.Find(id);
            db.AcerteAMarca.Remove(acerteAMarca);
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
