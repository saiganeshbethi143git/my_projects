using System;

namespace BarberShop.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public TimeSpan Time { get; set; }
        public string Branch { get; set; }
        public DateTime Date { get; set; }
        public int People { get; set; }
        public string Message { get; set; }
    }
}
