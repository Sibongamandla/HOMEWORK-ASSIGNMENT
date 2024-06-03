
using System;

namespace Capetropolis_Tourism.Models
{
    public class BookingModel
    {
        public string BookingId { get; set; }
        public string HotelName { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Initials { get; set; }
        public string Email { get; set; }
        public string IdType { get; set; }
        public string IdNum { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string MealReq { get; set; }
        public string RoomType { get; set; }
        public decimal Price { get; set; }
        public string Features { get; set; } 
        public DateTime BookingDate { get; set; }
    }
}