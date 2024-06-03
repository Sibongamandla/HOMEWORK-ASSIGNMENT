using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Capetropolis_Tourism.Models;

namespace Capetropolis_Tourism.Controllers
{
    public class BookingController : Controller
    {
        // Display the booking form for the selected hotel
        public ActionResult Bookings(string hotel)
        {
            if (HotelService.Hotels.ContainsKey(hotel))
            {
                ViewBag.Hotel = HotelService.Hotels[hotel];
                return View();
            }
            return HttpNotFound();
        }

        // Process the booking form submission
        [HttpPost]
        public ActionResult ConfirmBooking(BookingModel booking)
        {
            if (ModelState.IsValid)
            {
                // Generate a unique booking ID and capture the booking date and time
                booking.BookingId = Guid.NewGuid().ToString();
                booking.BookingDate = DateTime.Now;

                // Retrieve the selected hotel details
                if (HotelService.Hotels.ContainsKey(booking.HotelName))
                {
                    var hotel = HotelService.Hotels[booking.HotelName];
                    TempData["Hotel"] = hotel;
                }

                // Store the booking details in TempData to pass to the confirmation view
                TempData["Booking"] = booking;

                // Redirect to the booking confirmation page
                return RedirectToAction("BookingConfirmation");
            }

            // If the model state is invalid, re-display the form with validation errors
            if (HotelService.Hotels.ContainsKey(booking.HotelName))
            {
                ViewBag.Hotel = HotelService.Hotels[booking.HotelName];
            }
            return View("Bookings", booking);
        }

        // Display the booking confirmation page
        public ActionResult BookingConfirmation()
        {
            // Retrieve the booking details from TempData
            var booking = TempData["Booking"] as BookingModel;
            var hotel = TempData["Hotel"] as Hotel;

            if (booking != null && hotel != null)
            {
                ViewBag.Hotel = hotel;
                return View(booking);
            }
            return HttpNotFound();
        }
    }
}