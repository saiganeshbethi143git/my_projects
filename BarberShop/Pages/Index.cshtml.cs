using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BarberShop.Data;
using BarberShop.Models;

namespace BarberShop.Pages
{
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        public IndexModel(AppDbContext context) => _context = context;

        public void OnGet() {}

        public IActionResult OnPost(
            string bb_name,
            string bb_phone,
            string bb_time,
            string bb_branch,
            string bb_date,
            int bb_number,
            string? bb_message)
        {
            var booking = new Booking
            {
                FullName = bb_name,
                Phone = bb_phone,
                Time = TimeSpan.Parse(bb_time),
                Branch = bb_branch,
                Date = DateTime.Parse(bb_date),
                People = bb_number,
                Message = bb_message ?? ""
            };

            _context.Bookings.Add(booking);
            _context.SaveChanges();

            TempData["Success"] = "✅ Booking Submitted Successfully";
            return RedirectToPage();
        }
    }
}
