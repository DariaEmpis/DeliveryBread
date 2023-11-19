using DeliveryBreadWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryBreadWebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Root> Roots { get; set; }
        public DbSet<Expedition> Expeditions { get; set; }
        public DbSet<Gate> Gates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Driver>()
                .HasOne(d => d.Car)        
                .WithOne(c => c.Driver)          
                .HasForeignKey<Car>(c => c.Id);  

            base.OnModelCreating(modelBuilder);
        }
    }
}