using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

using PengelolaanPegawai.Web.Models;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PengelolaanPegawai.Web.Controllers
{
    public class TestController : Controller
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        // GET: Test
        public ActionResult Index()
        {
            //TestViewModel model = new TestViewModel();
            //try
            //{
            var model = new TestViewModel
            {
                Roles = context.Roles.ToList().Select(x => new SelectListItem
                {
                    Value = x.Id,
                    Text = x.Name
                })
            };
            //ViewBag.Roles = new SelectList(context.Roles.Select(x => x).ToList(), "Id", "Name");
            //var roles = context.Roles.Select(x => x).ToList();
            //List<SelectListItem> data = new List<SelectListItem>();
            //foreach (var role in roles)
            //{
            //    data.Add(new SelectListItem { Text = role.Name, Value = role.Id });
            //}
            //model.Roles = data;

            //ViewBag.Roles = data;
            //AccountController account = new AccountController();
            //ApplicationUser user = context.Users.FirstOrDefault(u => u.UserName.Equals("rezafaisal", StringComparison.CurrentCultureIgnoreCase));
            //ViewBag.User = user.UserName;
            //account.UserManager.AddToRole(user.UserName, "Admin");
            //if (user != null)
            //{
            //    account.UserManager.AddToRole("rezafaisal", "Admin");
            //}
            //}
            //catch (Exception ex)
            //{
            //    ViewBag.Pesan = ex.Message;
            //}
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(TestViewModel model)
        {

            model.Roles = context.Roles.ToList().Select(x => new SelectListItem
            {
                Value = x.Id,
                Text = x.Name
            });

            ViewBag.Username = model.UserName;
            ViewBag.Role = context.Roles.FirstOrDefault(p => p.Id.Equals(model.RoleId)).Name;

            return View(model);
        }
    }
}