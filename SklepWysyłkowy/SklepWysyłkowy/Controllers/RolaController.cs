using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SklepWysyłkowy.Models;

namespace SklepWysyłkowy.Controllers
{
    public class RolaController : Controller
    {
        private Rola.RolaDBContext db = new Rola.RolaDBContext();
        // GET: Rola
        public ActionResult Index()
        {
            var role = from r in db.Role
            orderby r.IDRoli
            select r;
            return View(role);
        }

        // GET: Rola/Create
        public ActionResult Create()
        {
            return View();
        }


    }
}