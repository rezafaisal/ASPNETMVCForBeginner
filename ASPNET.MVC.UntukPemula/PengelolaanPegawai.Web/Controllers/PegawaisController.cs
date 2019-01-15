using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PengelolaanPegawai.Web.Models;

namespace PengelolaanPegawai.Web.Controllers
{
    public class PegawaisController : Controller
    {
        private PegawaiDBEntities db = new PegawaiDBEntities();

        // GET: Pegawais
        public ActionResult Index()
        {
            var pegawais = db.Pegawais.Include(p => p.Divisi);
            return View(pegawais.ToList());
        }

        // GET: Pegawais/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pegawai pegawai = db.Pegawais.Find(id);
            if (pegawai == null)
            {
                return HttpNotFound();
            }
            return View(pegawai);
        }

        // GET: Pegawais/Create
        public ActionResult Create()
        {
            ViewBag.DivisiID = new SelectList(db.Divisis, "DivisiID", "NamaDivisi");
            return View();
        }

        // POST: Pegawais/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NIP,DivisiID,Nama,Alamat,TanggalLahir")] Pegawai pegawai)
        {
            if (ModelState.IsValid)
            {
                db.Pegawais.Add(pegawai);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DivisiID = new SelectList(db.Divisis, "DivisiID", "NamaDivisi", pegawai.DivisiID);
            return View(pegawai);
        }

        // GET: Pegawais/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pegawai pegawai = db.Pegawais.Find(id);
            if (pegawai == null)
            {
                return HttpNotFound();
            }
            ViewBag.DivisiID = new SelectList(db.Divisis, "DivisiID", "NamaDivisi", pegawai.DivisiID);
            return View(pegawai);
        }

        // POST: Pegawais/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NIP,DivisiID,Nama,Alamat,TanggalLahir")] Pegawai pegawai)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pegawai).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DivisiID = new SelectList(db.Divisis, "DivisiID", "NamaDivisi", pegawai.DivisiID);
            return View(pegawai);
        }

        // GET: Pegawais/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pegawai pegawai = db.Pegawais.Find(id);
            if (pegawai == null)
            {
                return HttpNotFound();
            }
            return View(pegawai);
        }

        // POST: Pegawais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Pegawai pegawai = db.Pegawais.Find(id);
            db.Pegawais.Remove(pegawai);
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
