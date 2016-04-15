using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LaTuerca.Models;

namespace LaTuerca.Controllers
{
    public class RepuestosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Repuestos
        public ActionResult Index()
        {
            return View(db.Repuestos.ToList());
        }

        // GET: Repuestos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Repuestos repuestos = db.Repuestos.Find(id);
            if (repuestos == null)
            {
                return HttpNotFound();
            }
            return View(repuestos);
        }

        // GET: Repuestos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Repuestos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NombreRepuesto,UnidadDeMedida,Proveedor,Marca,Modelo,Categoria,PrecioCosto")] Repuestos repuestos)
        {
            if (ModelState.IsValid)
            {
                db.Repuestos.Add(repuestos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(repuestos);
        }

        // GET: Repuestos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Repuestos repuestos = db.Repuestos.Find(id);
            if (repuestos == null)
            {
                return HttpNotFound();
            }
            return View(repuestos);
        }

        // POST: Repuestos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NombreRepuesto,UnidadDeMedida,Proveedor,Marca,Modelo,Categoria,PrecioCosto")] Repuestos repuestos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(repuestos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(repuestos);
        }

        // GET: Repuestos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Repuestos repuestos = db.Repuestos.Find(id);
            if (repuestos == null)
            {
                return HttpNotFound();
            }
            return View(repuestos);
        }

        // POST: Repuestos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Repuestos repuestos = db.Repuestos.Find(id);
            db.Repuestos.Remove(repuestos);
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
