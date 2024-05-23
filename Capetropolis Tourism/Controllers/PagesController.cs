using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capetropolis_Tourism.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult Bookings()
        {
            return View();
        }

        public ActionResult BookingConfirmation()
        {
            return View();
        }

        
    }
}
