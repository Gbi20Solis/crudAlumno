using crudEntity.Context;
using crudEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crudEntity.Controllers
{
    public class alumnoController : Controller
    {
        alumnoContext obj = new alumnoContext();
        private alumnoModelo datosAlumnos;

        // GET: alumno
        public ActionResult Index()
        {
            return View(obj.alumnos.ToList());
        }

        // GET: alumno/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: alumno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: alumno/Create
        [HttpPost]
        public ActionResult Create(alumnoModelo datosalumno)
        {
            try
            {
                // TODO: Add insert logic here
                obj.alumnos.Add(datosAlumnos);
                obj.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: alumno/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: alumno/Edit/5
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

        // GET: alumno/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: alumno/Delete/5
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
