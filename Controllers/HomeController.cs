using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rento.Data;


namespace Rento.Controllers
{
    public class HomeController : Controller
    {
        private RentoDBContext db = new RentoDBContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Car_List()
        {
            var cars = db.Cars.ToList();
            return View(cars);
        }
        public ActionResult Car_Info(int id)
        {
            var car = db.Cars.Find(id);

            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }
    }
}