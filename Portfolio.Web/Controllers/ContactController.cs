using Microsoft.AspNetCore.Mvc;
using YourProjectNamespace.Data;
using YourProjectNamespace.Models;

namespace YourProjectNamespace.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Submit(string name, string email, string subject, string message)
        {
            var data = new ContactMessage
            {
                Name = name,
                Email = email,
                Subject = subject,
                Message = message,
                CreatedOn = DateTime.Now
            };

            _context.ContactMessages.Add(data);
            _context.SaveChanges();

            TempData["Success"] = "Message Sent Successfully!";
            return RedirectToAction("Index", "Home");
        }
    }
}
