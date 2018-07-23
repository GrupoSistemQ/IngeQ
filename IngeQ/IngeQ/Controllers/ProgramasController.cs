using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IngeQ.Models;

namespace IngeQ.Controllers
{
    public class ProgramasController : Controller
    {
        // GET: Programas
        public ActionResult Index()
        {
            db_host_ingeq bd = new db_host_ingeq();
            List<programas> programas = bd.programas.ToList();

            return View(programas);
        }

        // GET: Programas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Programas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Programas/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Programas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Programas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Programas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Programas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
