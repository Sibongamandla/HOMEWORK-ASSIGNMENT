using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capetropolis_Tourism.Models;

namespace Capetropolis_Tourism.Controllers
{
    public class OrdersController : Controller
    {
        private static List<MealOrderModel> mealOrders = new List<MealOrderModel>();
        private static List<MealAgentModel> mealAgents = MealsController.mealAgents; // Assuming same mealAgents list

        public ActionResult Order()
        {
            ViewBag.MealAgents = mealAgents;
            return View();
        }

        [HttpPost]
        public ActionResult Order(MealOrderModel order)
        {
            order.OrderID = Guid.NewGuid();
            order.OrderDate = DateTime.Now;
            mealOrders.Add(order);
            return RedirectToAction("ViewOrder", new { id = order.OrderID });
        }

        public ActionResult ViewOrder(Guid id)
        {
            var order = mealOrders.FirstOrDefault(m => m.OrderID == id);
            return View(order);
        }
    }
}