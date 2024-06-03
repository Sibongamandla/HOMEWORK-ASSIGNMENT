using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capetropolis_Tourism.Models
{
    public class MealAgentModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email {  get; set; }
        public string Telephone { get; set; }
        public List<string> MealService {  get; set; } = new List<string>();
        public List<string> AvailableMealServices { get; } = new List<string>
        {
            "Regular", "Vegan", "Indian", "Halal", "Kosher", "Keto", "Paleo", "Gluten-free"
        };
        public bool IsEditing { get; set; } = false;
        
    }
}