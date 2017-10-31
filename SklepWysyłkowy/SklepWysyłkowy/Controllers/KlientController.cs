using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SklepWysyłkowy.Models;

namespace SklepWysyłkowy.Controllers
{
    public class KlientController : Controller
    {
        private Klient.KlientDBContext db = new Klient.KlientDBContext();
        // GET: Klient
        public ActionResult Index()
        {
            var klienci = from k in db.Klienci
            orderby k.IDKlienta
            select k;
            return View(klienci);
        }

        // GET: Klient/Create
        public ActionResult Create()
        {
            return View();
        }


    }
}