using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IngeQ.Models;

namespace IngeQ.Controllers
{
    public class pruebaController : Controller
    {
        private db_host_ingeq db = new db_host_ingeq();

        // GET: prueba
        public ActionResult Index()
        {
            return View(db.programas.ToList());
        }

        // GET: prueba/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            programas programas = db.programas.Find(id);
            if (programas == null)
            {
                return HttpNotFound();
            }
            return View(programas);
        }

        // GET: prueba/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: prueba/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PROGRAMA,NOMBRE_PROGRAMA,FECHA_INICIO,FECHA_TERMINO,ESTADO_PROGRAMA,CAPACIDAD_PROGRAMA,CANTIDAD_CLASES")] programas programas)
        {
            if (ModelState.IsValid)
            {
                db.programas.Add(programas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(programas);
        }

        // GET: prueba/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            programas programas = db.programas.Find(id);
            if (programas == null)
            {
                return HttpNotFound();
            }
            return View(programas);
        }

        // POST: prueba/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PROGRAMA,NOMBRE_PROGRAMA,FECHA_INICIO,FECHA_TERMINO,ESTADO_PROGRAMA,CAPACIDAD_PROGRAMA,CANTIDAD_CLASES")] programas programas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(programas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(programas);
        }

        // GET: prueba/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            programas programas = db.programas.Find(id);
            if (programas == null)
            {
                return HttpNotFound();
            }
            return View(programas);
        }

        // POST: prueba/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            programas programas = db.programas.Find(id);
            db.programas.Remove(programas);
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
