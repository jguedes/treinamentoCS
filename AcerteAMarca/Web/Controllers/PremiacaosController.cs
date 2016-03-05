using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Dominio;
using DAL;

namespace Web.Controllers
{
    public class PremiacaosController : Controller
    {
        private AcerteAMarcaContext db = new AcerteAMarcaContext();

        // GET: Premiacaos
        public ActionResult Index()
        {
            return View(db.Premiacao.ToList());
        }

        // GET: Premiacaos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Premiacao premiacao = db.Premiacao.Find(id);
            if (premiacao == null)
            {
                return HttpNotFound();
            }
            return View(premiacao);
        }

        // GET: Premiacaos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Premiacaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ObjetoPremio")] Premiacao premiacao)
        {
            if (ModelState.IsValid)
            {
                db.Premiacao.Add(premiacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(premiacao);
        }

        // GET: Premiacaos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Premiacao premiacao = db.Premiacao.Find(id);
            if (premiacao == null)
            {
                return HttpNotFound();
            }
            return View(premiacao);
        }

        // POST: Premiacaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ObjetoPremio")] Premiacao premiacao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(premiacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(premiacao);
        }

        // GET: Premiacaos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Premiacao premiacao = db.Premiacao.Find(id);
            if (premiacao == null)
            {
                return HttpNotFound();
            }
            return View(premiacao);
        }

        // POST: Premiacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Premiacao premiacao = db.Premiacao.Find(id);
            db.Premiacao.Remove(premiacao);
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
