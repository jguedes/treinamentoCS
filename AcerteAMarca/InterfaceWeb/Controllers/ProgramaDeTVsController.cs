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
    public class ProgramaDeTVsController : Controller
    {
        private AcerteAMarcaContext db = new AcerteAMarcaContext();

        // GET: ProgramaDeTVs
        public ActionResult Index()
        {
            return View(db.ProgramaDeTV.ToList());
        }

        // GET: ProgramaDeTVs/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProgramaDeTV programaDeTV = db.ProgramaDeTV.Find(id);
            if (programaDeTV == null)
            {
                return HttpNotFound();
            }
            return View(programaDeTV);
        }

        // GET: ProgramaDeTVs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProgramaDeTVs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nome")] ProgramaDeTV programaDeTV)
        {
            if (ModelState.IsValid)
            {
                db.ProgramaDeTV.Add(programaDeTV);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(programaDeTV);
        }

        // GET: ProgramaDeTVs/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProgramaDeTV programaDeTV = db.ProgramaDeTV.Find(id);
            if (programaDeTV == null)
            {
                return HttpNotFound();
            }
            return View(programaDeTV);
        }

        // POST: ProgramaDeTVs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nome")] ProgramaDeTV programaDeTV)
        {
            if (ModelState.IsValid)
            {
                db.Entry(programaDeTV).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(programaDeTV);
        }

        // GET: ProgramaDeTVs/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProgramaDeTV programaDeTV = db.ProgramaDeTV.Find(id);
            if (programaDeTV == null)
            {
                return HttpNotFound();
            }
            return View(programaDeTV);
        }

        // POST: ProgramaDeTVs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            ProgramaDeTV programaDeTV = db.ProgramaDeTV.Find(id);
            db.ProgramaDeTV.Remove(programaDeTV);
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
