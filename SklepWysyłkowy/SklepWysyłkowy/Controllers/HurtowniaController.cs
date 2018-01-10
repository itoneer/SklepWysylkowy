using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SklepWysyłkowy.Models;

namespace SklepWysyłkowy.Controllers
{
    public class HurtowniaController : Controller
    {
        private Hurtownia.HurtowniaDBContext db = new Hurtownia.HurtowniaDBContext();
        // GET: Hurtownia
        public ActionResult Index()
        {
            var hurtownie = from h in db.Hurtownie
            orderby h.IDHurtowni
            select h;
            return View(hurtownie);
        }

        // GET: Hurtownia/Create
        public ActionResult Create()
        {
            return View();
        }


    }
}