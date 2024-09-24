using Microsoft.EntityFrameworkCore;
using WebApplication1_API.Models; // Ensure this is correct

namespace WebApplication1_API.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Office> Offices { get; set; }
        public DbSet<Realtor> Realtors { get; set; }

        //Constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // You can define relationships or default data here
        }
    }
}
