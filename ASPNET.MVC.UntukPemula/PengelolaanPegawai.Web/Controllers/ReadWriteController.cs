using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PengelolaanPegawai.Web.Controllers
{
    public class ReadWriteController : Controller
    {
        // GET: ReadWrite
        public ActionResult Index()
        {
            return View();
        }

        // GET: ReadWrite/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReadWrite/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReadWrite/Create
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

        // GET: ReadWrite/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReadWrite/Edit/5
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

        // GET: ReadWrite/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReadWrite/Delete/5
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
