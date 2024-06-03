using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capetropolis_Tourism.Models
{
    public static class HotelService
    {
        public static Dictionary<string, Hotel> Hotels = new Dictionary<string, Hotel>
        {
            {
                "CapeHoney", new Hotel {
                Name = "CapeHoney",
                Logo = "~/Content/Images/CapeHoneyLogo.png",
                MealTypes = new List<string> { "Regular", "Vegan", "Gluten-free" },
                RoomTypes = new Dictionary<string, (decimal price, string features)>
                {
                    { "Standard", (3000, "Breakfast excluded, single bed, TV, internet") },
                    { "Deluxe", (5000, "Breakfast included, double (2) single beds, TV, internet") },
                    { "Exquisite", (7000, "Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator") },
                    { "Executive", (10000, "Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, room service, tourism tour of Capetropolis") }
                }
            }},
            {
                "CapeIvory", new Hotel {
                    Name = "CapeIvory",
                    Logo = "~/Content/Images/CapeIvoryLogo.png",
                    MealTypes = new List<string> { "Regular", "Vegan", "Halal", "Kosher", "Gluten-free", "Keto" },
                    RoomTypes = new Dictionary<string, (decimal price, string features)>
                    {
                        { "Single", (2500, "Breakfast excluded; single bed, TV, internet") },
                        { "Double", (5000, "Breakfast included, double (2) single beds, TV, internet") },
                        { "Executive", (8000, "Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, buffet voucher") }
                    }
                }
            },
            {
                "CapeSweet", new Hotel {
                    Name = "CapeSweet",
                    Logo = "~/Content/Images/CapeSweetLogo.png",
                    MealTypes = new List<string> { "Regular", "Vegan", "Halal", "Kosher" },
                    RoomTypes = new Dictionary<string, (decimal price, string features)>
                    {
                        { "Tasty", (3500, "Breakfast included; two single beds, TV, internet") },
                        { "Comfort", (5000, "Breakfast included, two single beds, TV, internet, laundry, free parking") },
                        { "Executive", (9000, "Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, free parking, pet allowed, separate dining area") },
                        { "Diamond", (12000, "Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, free parking, pet allowed, room service, separate dining area, buffet") }
                    }
                }
            },
            {
                "CapeHive", new Hotel {
                    Name = "CapeHive",
                    Logo = "~/Content/Images/CapeHiveLogo.png",
                    MealTypes = new List<string> { "Regular", "Vegan", "Gluten-free", "Paleo" },
                    RoomTypes = new Dictionary<string, (decimal price, string features)>
                    {
                        { "Standard", (5000, "Breakfast included, single bed, TV, internet, laundry, free parking") },
                        { "Double", (7000, "Breakfast included, double (2) single beds, TV, internet") },
                        { "Executive", (10000, "Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, room service, tourism tour of Capetropolis") }
                    }
                }
            },
            {
                "CapeCow", new Hotel {
                    Name = "CapeCow",
                    Logo = "~/Content/Images/CapeCowLogo.png",
                    MealTypes = new List<string> { "Regular", "Vegan", "Halal", "Kosher", "Indian" },
                    RoomTypes = new Dictionary<string, (decimal price, string features)>
                    {
                        { "Budget", (2500, "Breakfast excluded; single bed, TV, internet") },
                        { "Spotlight", (4000, "Breakfast included; two single beds, TV, internet") },
                        { "Deluxe", (6000, "Breakfast included, single bed, TV, internet, laundry, free parking, tourism tour of Capetropolis") },
                        { "Gold", (8000, "Breakfast included, single bed, TV, internet, complimentary drinks in refrigerator, laundry, free parking, tourism tour of Capetropolis") },
                        { "Diamond", (12000, "Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, room service, tourism tour of Capetropolis") },
                        { "Platinum", (15000, "Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, room service, tourism tour of Capetropolis") }
                    }
                }
            }

        };
    }
}