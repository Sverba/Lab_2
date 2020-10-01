using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tourist_Agency.Models;

namespace Tourist_Agency.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Travel firstTravel = new Travel
        {
            TravelID = 1,
            Name = "Сонячна Іспанія",
            Description = "Дана путівка дасть змогу отримати приємні враження від сонячної та прекрасної Іспанії",
            Category = "Літня",
            SCountry = "Україна",
            STown = "Київ",
            FCountry = "Іспанія",
            FTown = "Мадрид",
            Price = 899M,
            Date = "15.10.2020",
            Duration = 14
        };
        public ActionResult Index()
        {
            return View(firstTravel);
        }
        public ActionResult Information()
        {
            return View(firstTravel);
        }        public ActionResult DemoExpression()
        {
            ViewBag.Count = 3;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;
            return View(firstTravel);
        }
        public ActionResult DemoArray()
        {
            Travel[] array = {
                new Travel {Name = "Cонячна Іспанія", Price = 899M},
                new Travel {Name = "Дивовижна Італія", Price = 849M},
                new Travel {Name = "Казвова Швейцарія", Price = 999M},
                new Travel {Name = "Пахуча Норвегія", Price = 749M},
                new Travel {Name = "Барвиста Фінляндія", Price = 699M}
 };
            return View(array);
        }
    }
}