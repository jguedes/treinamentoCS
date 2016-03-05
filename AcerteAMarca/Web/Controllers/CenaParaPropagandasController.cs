using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Dominio;
using DAL;

namespace Web.Controllers
{
    public class CenaParaPropagandasController : Controller
    {
        private AcerteAMarcaContext db = new AcerteAMarcaContext();

        // GET: CenaParaPropagandas
        public ActionResult Index()
        {
            return View(db.Cena.ToList());
        }

        // GET: CenaParaPropagandas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CenaParaPropaganda cenaParaPropaganda = db.Cena.Find(id);
            if (cenaParaPropaganda == null)
            {
                return HttpNotFound();
            }
            return View(cenaParaPropaganda);
        }

        // GET: CenaParaPropagandas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CenaParaPropagandas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Identificador,HoraLimiteDeInteracaoComTelespectador")] CenaParaPropaganda cenaParaPropaganda)
        {
            if (ModelState.IsValid)
            {
                db.Cena.Add(cenaParaPropaganda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cenaParaPropaganda);
        }

        // GET: CenaParaPropagandas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CenaParaPropaganda cenaParaPropaganda = db.Cena.Find(id);
            if (cenaParaPropaganda == null)
            {
                return HttpNotFound();
            }
            return View(cenaParaPropaganda);
        }

        // POST: CenaParaPropagandas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Identificador,HoraLimiteDeInteracaoComTelespectador")] CenaParaPropaganda cenaParaPropaganda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cenaParaPropaganda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cenaParaPropaganda);
        }

        // GET: CenaParaPropagandas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CenaParaPropaganda cenaParaPropaganda = db.Cena.Find(id);
            if (cenaParaPropaganda == null)
            {
                return HttpNotFound();
            }
            return View(cenaParaPropaganda);
        }

        // POST: CenaParaPropagandas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            CenaParaPropaganda cenaParaPropaganda = db.Cena.Find(id);
            db.Cena.Remove(cenaParaPropaganda);
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
