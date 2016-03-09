using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DAL;
using Dominio;

namespace InterfaceWeb.Controllers
{
    public class TelespectadorParticipantesController : Controller
    {
        private AcerteAMarcaContext db = new AcerteAMarcaContext();

        // GET: TelespectadorParticipantes
        public ActionResult Index()
        {
            return View(db.TelespactadorParticipante.ToList());
        }

        // GET: TelespectadorParticipantes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TelespectadorParticipante telespectadorParticipante = db.TelespactadorParticipante.Find(id);
            if (telespectadorParticipante == null)
            {
                return HttpNotFound();
            }
            return View(telespectadorParticipante);
        }

        // GET: TelespectadorParticipantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TelespectadorParticipantes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,IdentificadorDoTelespectador")] TelespectadorParticipante telespectadorParticipante)
        {
            if (ModelState.IsValid)
            {
                db.TelespactadorParticipante.Add(telespectadorParticipante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(telespectadorParticipante);
        }

        // GET: TelespectadorParticipantes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TelespectadorParticipante telespectadorParticipante = db.TelespactadorParticipante.Find(id);
            if (telespectadorParticipante == null)
            {
                return HttpNotFound();
            }
            return View(telespectadorParticipante);
        }

        // POST: TelespectadorParticipantes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,IdentificadorDoTelespectador")] TelespectadorParticipante telespectadorParticipante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(telespectadorParticipante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(telespectadorParticipante);
        }

        // GET: TelespectadorParticipantes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TelespectadorParticipante telespectadorParticipante = db.TelespactadorParticipante.Find(id);
            if (telespectadorParticipante == null)
            {
                return HttpNotFound();
            }
            return View(telespectadorParticipante);
        }

        // POST: TelespectadorParticipantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TelespectadorParticipante telespectadorParticipante = db.TelespactadorParticipante.Find(id);
            db.TelespactadorParticipante.Remove(telespectadorParticipante);
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
