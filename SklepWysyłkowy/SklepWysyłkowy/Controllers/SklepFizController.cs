using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SklepWysyłkowy.Models;

namespace SklepWysyłkowy.Controllers
{
    public class SklepFizController : Controller
    {
        private SklepFiz.SklepFizDBContext db = new SklepFiz.SklepFizDBContext();
        // GET: SklepFiz
        public ActionResult Index()
        {
            var sklepy = from s in db.Sklepy
            orderby s.IDSklepu
            select s;
            return View(sklepy);
        }

        // GET: SklepFiz/Create
        public ActionResult Create()
        {
            return View();
        }


    }
}