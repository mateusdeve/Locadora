using Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Locadora.Controllers
{
    public class FilmeController : System.Web.Mvc.Controller
    {
        // GET: Filmes
        public ActionResult Index()
        {
            FilmesController controller = new FilmesController();
            var lst = controller.Listar();
            return View(lst);
        }

        // GET: Filmes/Details/5
        public ActionResult Buscar(int id)
        { 
            FilmesController controller = new FilmesController();
            var lst = controller.buscar(id);
            return View(lst);
        }

        // GET: Filmes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Filmes/Create
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

        // GET: Filmes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Filmes/Edit/5
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

        // GET: Filmes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Filmes/Delete/5
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
