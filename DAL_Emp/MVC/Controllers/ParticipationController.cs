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
    public class ParticipationController : Controller
    {
        private DataBaseEntities db = new DataBaseEntities();

        // GET: /Participation/
        public ActionResult Index()
        {
            var participations = db.Participations.Include(p => p.Employe).Include(p => p.Projet);
            return View(participations.ToList());
        }

        // GET: /Participation/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Participation participation = db.Participations.Find(id);
            if (participation == null)
            {
                return HttpNotFound();
            }
            return View(participation);
        }

        // GET: /Participation/Create
        public ActionResult Create()
        {
            ViewBag.Matr = new SelectList(db.Employes, "Matr", "NomE");
            ViewBag.CodeP = new SelectList(db.Projets, "CodeP", "NomP");
            return View();
        }

        // POST: /Participation/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Matr,CodeP,Fonction")] Participation participation)
        {
            if (ModelState.IsValid)
            {
                db.Participations.Add(participation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Matr = new SelectList(db.Employes, "Matr", "NomE", participation.Matr);
            ViewBag.CodeP = new SelectList(db.Projets, "CodeP", "NomP", participation.CodeP);
            return View(participation);
        }

        // GET: /Participation/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Participation participation = db.Participations.Find(id);
            if (participation == null)
            {
                return HttpNotFound();
            }
            ViewBag.Matr = new SelectList(db.Employes, "Matr", "NomE", participation.Matr);
            ViewBag.CodeP = new SelectList(db.Projets, "CodeP", "NomP", participation.CodeP);
            return View(participation);
        }

        // POST: /Participation/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Matr,CodeP,Fonction")] Participation participation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(participation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Matr = new SelectList(db.Employes, "Matr", "NomE", participation.Matr);
            ViewBag.CodeP = new SelectList(db.Projets, "CodeP", "NomP", participation.CodeP);
            return View(participation);
        }

        // GET: /Participation/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Participation participation = db.Participations.Find(id);
            if (participation == null)
            {
                return HttpNotFound();
            }
            return View(participation);
        }

        // POST: /Participation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Participation participation = db.Participations.Find(id);
            db.Participations.Remove(participation);
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
