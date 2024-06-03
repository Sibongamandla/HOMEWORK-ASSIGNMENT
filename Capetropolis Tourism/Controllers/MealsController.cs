using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capetropolis_Tourism.Models;

namespace Capetropolis_Tourism.Controllers
{
    public class MealsController : Controller
    {
        public static List<MealAgentModel> mealAgents = new List<MealAgentModel>();

        public ActionResult Register()
        {
            ViewBag.MealAgents = mealAgents;
            var model = new MealAgentModel();
            return View(mealAgents);
        }

        [HttpPost]
        public ActionResult Add(MealAgentModel agent)
        {
            agent.Id = Guid.NewGuid();
            mealAgents.Add(agent);
            return RedirectToAction("Register");
        }

        [HttpGet]
        public ActionResult Find(string searchTerm)
        {
            var foundAgents = mealAgents.Where(m => m.FirstName.Contains(searchTerm) || m.Surname.Contains(searchTerm)).ToList();
            return View("Register", foundAgents);
        }

        [HttpPost]
        public JsonResult GetAgentById(Guid id)
        {
            var agent = mealAgents.FirstOrDefault(m => m.Id == id);
            return Json(agent, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Edit(Guid id)
        {
            var agent = mealAgents.FirstOrDefault(m => m.Id == id);
            if (agent != null)
            {
                agent.IsEditing = true;
            }
            return RedirectToAction("Register");
        }

        [HttpPost]
        public ActionResult Update(MealAgentModel updatedAgent)
        {
            var agent = mealAgents.FirstOrDefault(m => m.Id == updatedAgent.Id);
            if (agent != null)
            {
                agent.FirstName = updatedAgent.FirstName;
                agent.Surname = updatedAgent.Surname;
                agent.Email = updatedAgent.Email;
                agent.Telephone = updatedAgent.Telephone;
                agent.MealService = updatedAgent.MealService;
               /* agent.IsEditing = false;*/
            }
            return RedirectToAction("Register");
        }

        [HttpPost]
        public ActionResult Delete(Guid id)
        {
            var agent = mealAgents.FirstOrDefault(m => m.Id == id);
            if (agent != null)
            {
                mealAgents.Remove(agent);
            }
            return RedirectToAction("Register");
        }
    }
}