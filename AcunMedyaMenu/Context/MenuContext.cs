using AcunMedyaMenu.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcunMedyaMenu.Context
{
    public class MenuContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-NUB224AS;initial catalog=AcunMedyaMenuDb; integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}

