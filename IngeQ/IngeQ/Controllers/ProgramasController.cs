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
    public class PROGRAMASController : Controller
    {
        private DB_A3E8FF_ingeqsqlEntities db = new DB_A3E8FF_ingeqsqlEntities();

        // GET: PROGRAMAS
        public ActionResult Index()
        {
            return View(db.PROGRAMAS.ToList());
        }

        // GET: PROGRAMAS/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROGRAMAS pROGRAMAS = db.PROGRAMAS.Find(id);
            if (pROGRAMAS == null)
            {
                return HttpNotFound();
            }
            return View(pROGRAMAS);
        }

        // GET: PROGRAMAS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PROGRAMAS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PROGRAMA,NOMBRE_PROGRAMA,FECHA_INICIO,FECHA_TERMINO,ESTADO_PROGRAMA,CAPACIDAD_PROGRAMA,CANTIDAD_CLASES")] PROGRAMAS pROGRAMAS)
        {
            if (ModelState.IsValid)
            {
                db.PROGRAMAS.Add(pROGRAMAS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pROGRAMAS);
        }

        // GET: PROGRAMAS/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROGRAMAS pROGRAMAS = db.PROGRAMAS.Find(id);
            if (pROGRAMAS == null)
            {
                return HttpNotFound();
            }
            return View(pROGRAMAS);
        }

        // POST: PROGRAMAS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PROGRAMA,NOMBRE_PROGRAMA,FECHA_INICIO,FECHA_TERMINO,ESTADO_PROGRAMA,CAPACIDAD_PROGRAMA,CANTIDAD_CLASES")] PROGRAMAS pROGRAMAS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pROGRAMAS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pROGRAMAS);
        }

        // GET: PROGRAMAS/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROGRAMAS pROGRAMAS = db.PROGRAMAS.Find(id);
            if (pROGRAMAS == null)
            {
                return HttpNotFound();
            }
            return View(pROGRAMAS);
        }

        // POST: PROGRAMAS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PROGRAMAS pROGRAMAS = db.PROGRAMAS.Find(id);
            db.PROGRAMAS.Remove(pROGRAMAS);
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
