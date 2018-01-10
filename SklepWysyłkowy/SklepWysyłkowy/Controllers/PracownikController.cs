using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SklepWysyłkowy.Models;

namespace SklepWysyłkowy.Controllers
{
    public class PracownikController : Controller
    {
        private Pracownik.PracownikDBContext db = new Pracownik.PracownikDBContext();
        // GET: Pracownik
        public ActionResult Index()
        {
            var pracownicy = from p in db.Pracownicy
            orderby k.IDPracownika
            select p;
            return View(pracownicy);
        }

        // GET: Pracownik/Create
        public ActionResult Create()
        {
            return View();
        }


    }
}