using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Dominio;
using DAL;

namespace Web.Controllers
{
    public class PropagandaMarcadasController : Controller
    {
        private AcerteAMarcaContext db = new AcerteAMarcaContext();

        // GET: PropagandaMarcadas
        public ActionResult Index()
        {
            return View(db.PropagandaMarcada.ToList());
        }

        // GET: PropagandaMarcadas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropagandaMarcada propagandaMarcada = db.PropagandaMarcada.Find(id);
            if (propagandaMarcada == null)
            {
                return HttpNotFound();
            }
            return View(propagandaMarcada);
        }

        // GET: PropagandaMarcadas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PropagandaMarcadas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,efetivada")] PropagandaMarcada propagandaMarcada)
        {
            if (ModelState.IsValid)
            {
                db.PropagandaMarcada.Add(propagandaMarcada);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(propagandaMarcada);
        }

        // GET: PropagandaMarcadas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropagandaMarcada propagandaMarcada = db.PropagandaMarcada.Find(id);
            if (propagandaMarcada == null)
            {
                return HttpNotFound();
            }
            return View(propagandaMarcada);
        }

        // POST: PropagandaMarcadas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,efetivada")] PropagandaMarcada propagandaMarcada)
        {
            if (ModelState.IsValid)
            {
                db.Entry(propagandaMarcada).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(propagandaMarcada);
        }

        // GET: PropagandaMarcadas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropagandaMarcada propagandaMarcada = db.PropagandaMarcada.Find(id);
            if (propagandaMarcada == null)
            {
                return HttpNotFound();
            }
            return View(propagandaMarcada);
        }

        // POST: PropagandaMarcadas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            PropagandaMarcada propagandaMarcada = db.PropagandaMarcada.Find(id);
            db.PropagandaMarcada.Remove(propagandaMarcada);
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
