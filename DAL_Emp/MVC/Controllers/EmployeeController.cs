using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC.Views;

namespace MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private DataBaseEntities db = new DataBaseEntities();

        // GET: /Employee/
        public ActionResult Index()
        {
            var employes = db.Employes.Include(e => e.Departement);
            return View(employes.ToList());
        }

        // GET: /Employee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employe employe = db.Employes.Find(id);
            if (employe == null)
            {
                return HttpNotFound();
            }
            return View(employe);
        }

        // GET: /Employee/Create
        public ActionResult Create()
        {
            ViewBag.NumDep = new SelectList(db.Departements, "NumDep", "NomDep");
            return View();
        }

        // POST: /Employee/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Matr,NomE,Post,DateEmb,Sup,Salaire,Comm,NumDep")] Employe employe)
        {
            if (ModelState.IsValid)
            {
                db.Employes.Add(employe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.NumDep = new SelectList(db.Departements, "NumDep", "NomDep", employe.NumDep);
            return View(employe);
        }

        // GET: /Employee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employe employe = db.Employes.Find(id);
            if (employe == null)
            {
                return HttpNotFound();
            }
            ViewBag.NumDep = new SelectList(db.Departements, "NumDep", "NomDep", employe.NumDep);
            return View(employe);
        }

        // POST: /Employee/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Matr,NomE,Post,DateEmb,Sup,Salaire,Comm,NumDep")] Employe employe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NumDep = new SelectList(db.Departements, "NumDep", "NomDep", employe.NumDep);
            return View(employe);
        }

        // GET: /Employee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employe employe = db.Employes.Find(id);
            if (employe == null)
            {
                return HttpNotFound();
            }
            return View(employe);
        }

        // POST: /Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employe employe = db.Employes.Find(id);
            db.Employes.Remove(employe);
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
