using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capetropolis_Tourism.Models
{ 
        public class MealOrderModel
        {
            public Guid OrderID { get; set; }
            public DateTime OrderDate { get; set; }
            public string UserName { get; set; }
            public string MealType { get; set; }
            public string MealDetails { get; set; }
            public string Hotel { get; set; }
            public Guid MealAgentID { get; set; }
        }
}