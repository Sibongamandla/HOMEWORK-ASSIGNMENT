using System.Collections.Generic;

namespace Capetropolis_Tourism.Models
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Hotel> Hotels { get; set; }
        public string MainImage { get; set; }
        public string TourismImage { get; set; }
    }

    public class Hotel
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public List<string> MealTypes { get; set; }
        public Dictionary<string, (decimal price, string features)> RoomTypes { get; set; }
    }
}