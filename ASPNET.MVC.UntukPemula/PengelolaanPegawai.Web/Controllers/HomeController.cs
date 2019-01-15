using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PengelolaanPegawai.Web.Models;

namespace PengelolaanPegawai.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        public ActionResult Login(LoginViewModel data)
        {
            return View();
        }

        // GET: PageNotFound
        public ActionResult PageNotFound()
        {
            return View();
        }
    }
}