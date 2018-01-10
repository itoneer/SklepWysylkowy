using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SklepWysyłkowy.Models;

namespace SklepWysyłkowy.Controllers
{
    public class MiastoController : Controller
    {
        private Miasto.MiastoDBContext db = new Miasto.MiastoDBContext();
        // GET: Miasto
        public ActionResult Index()
        {
            var miasta = from k in db.Miasta
            orderby k.IDMiasta
            select k;
            return View(miasta);
        }

        // GET: Miasto/Create
        public ActionResult Create()
        {
            return View();
        }


    }
}