using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Implementasi.MVC.Models;

namespace Implementasi.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Visitor data)
        {
            ViewBag.Pesan = "Hello " + data.Nama + " di " + data.Alamat;
            return View();
        }
    }
}