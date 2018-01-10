using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SklepWysyłkowy.Models;

namespace SklepWysyłkowy.Controllers
{
    public class ProduktController : Controller
    {
        private Produkt.KlientDBContext db = new Produkt.ProduktDBContext();
        // GET: Produkt
        public ActionResult Index()
        {
            var produkty = from p in db.Produkty
            orderby p.IDProduktu
            select p;
            return View(produkty);
        }

        // GET: Produkt/Create
        public ActionResult Create()
        {
            return View();
        }


    }
}