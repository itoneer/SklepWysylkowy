using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SklepWysyłkowy.Models;

namespace SklepWysyłkowy.Controllers
{
    public class ZamowienieController : Controller
    {
        private Zamowienie.ZamowienieDBContext db = new Zamowienie.ZamowienieDBContext();
        // GET: Zamowienie
        public ActionResult Index()
        {
            var zamowienia = from z in db.Zamowienia
            orderby z.IDZamowienia
            select z;
            return View(zamowienia);
        }

        // GET: Zamowienie/Create
        public ActionResult Create()
        {
            return View();
        }


    }
}