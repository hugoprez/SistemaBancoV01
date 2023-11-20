using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaBancoV01.Controllers
{
    public class ClientController : Controller
    {
        // mostrar lista de Clientes
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Client/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Client/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Client/Create
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

        //
        // GET: /Client/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Client/Edit/5
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

        //
        // GET: /Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id== null)
            {
                return RedirectToAction("index");
            }
            return View();
        }

        //
        // POST: /Client/Delete/5

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete_POST(int id)
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