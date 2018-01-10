using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SklepWysyłkowy.Models;

namespace SklepWysyłkowy.Controllers
{
    public class StatusZamowController : Controller
    {
        private StatusZamow.StatusZamowDBContext db = new StatusZamow.StatusZamowDBContext();
        // GET: StatusZamow
        public ActionResult Index()
        {
            var statusy = from s in db.Statusy
            orderby s.IDStatusu
            select s;
            return View(statusy);
        }

        // GET: StatusZamow/Create
        public ActionResult Create()
        {
            return View();
        }


    }
}