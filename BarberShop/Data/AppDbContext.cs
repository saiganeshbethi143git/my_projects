using Microsoft.EntityFrameworkCore;
using BarberShop.Models;

namespace BarberShop.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Booking> Bookings { get; set; }
    }
}
