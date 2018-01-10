using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SklepWysyłkowy.Models;

namespace SklepWysyłkowy.Controllers
{
    public class KategoriaController : Controller
    {
        private Kategoria.KategoriaDBContext db = new Kategoria.MiastoDBContext();
        // GET: Kategoria
        public ActionResult Index()
        {
            var kategoria = from k in db.Kategorie
            orderby k.IDKategorii
            select k;
            return View(kategorie);
        }

        // GET: Kategoria/Create
        public ActionResult Create()
        {
            return View();
        }


    }
}