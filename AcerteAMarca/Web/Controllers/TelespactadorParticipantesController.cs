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
    public class TelespactadorParticipantesController : Controller
    {
        private AcerteAMarcaContext db = new AcerteAMarcaContext();

        // GET: TelespactadorParticipantes
        public ActionResult Index()
        {
            return View(db.TelespactadorParticipante.ToList());
        }

        // GET: TelespactadorParticipantes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TelespectadorParticipante telespactadorParticipante = db.TelespactadorParticipante.Find(id);
            if (telespactadorParticipante == null)
            {
                return HttpNotFound();
            }
            return View(telespactadorParticipante);
        }

        // GET: TelespactadorParticipantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TelespactadorParticipantes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdentificadorDoTelespectador")] TelespectadorParticipante telespactadorParticipante)
        {
            if (ModelState.IsValid)
            {
                db.TelespactadorParticipante.Add(telespactadorParticipante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(telespactadorParticipante);
        }

        // GET: TelespactadorParticipantes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TelespectadorParticipante telespactadorParticipante = db.TelespactadorParticipante.Find(id);
            if (telespactadorParticipante == null)
            {
                return HttpNotFound();
            }
            return View(telespactadorParticipante);
        }

        // POST: TelespactadorParticipantes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdentificadorDoTelespectador")] TelespectadorParticipante telespactadorParticipante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(telespactadorParticipante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(telespactadorParticipante);
        }

        // GET: TelespactadorParticipantes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TelespectadorParticipante telespactadorParticipante = db.TelespactadorParticipante.Find(id);
            if (telespactadorParticipante == null)
            {
                return HttpNotFound();
            }
            return View(telespactadorParticipante);
        }

        // POST: TelespactadorParticipantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TelespectadorParticipante telespactadorParticipante = db.TelespactadorParticipante.Find(id);
            db.TelespactadorParticipante.Remove(telespactadorParticipante);
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
