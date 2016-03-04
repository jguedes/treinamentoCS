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
    public class RegrasController : Controller
    {
        private AcerteAMarcaContext db = new AcerteAMarcaContext();

        // GET: Regras
        public ActionResult Index(long? premiacaoId)
        {

            ICollection<Premiacao> i = new List<Premiacao>();

            i.Add(db.Premiacao.Find(premiacaoId));

            return View(i);
        }

        // GET: Regras/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regra regra = db.Regras.Find(id);
            if (regra == null)
            {
                return HttpNotFound();
            }
            return View(regra);
        }

        // GET: Regras/Create
        public ActionResult Create(long? premiacaoId)
        {
            Regra regra = new Regra();

            regra.Premiacao_Id = premiacaoId;

            return View(regra);
        }

        // POST: Regras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descricao")] Regra regra)
        {
            //Console.WriteLine("ok");
            if (ModelState.IsValid)
            {
                db.Regras.Add(regra);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(regra);
        }

        // GET: Regras/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regra regra = db.Regras.Find(id);
            if (regra == null)
            {
                return HttpNotFound();
            }
            return View(regra);
        }

        // POST: Regras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descricao")] Regra regra)
        {
            if (ModelState.IsValid)
            {
                db.Entry(regra).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(regra);
        }

        // GET: Regras/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regra regra = db.Regras.Find(id);
            if (regra == null)
            {
                return HttpNotFound();
            }
            return View(regra);
        }

        // POST: Regras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Regra regra = db.Regras.Find(id);
            db.Regras.Remove(regra);
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
