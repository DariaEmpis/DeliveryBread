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

        DbSet<Driver> Drivers { get; set; }
        DbSet<Car> Cars { get; set; }
        DbSet<Root> Roots { get; set; }
        DbSet<Expedition> Expeditions { get; set; }
        DbSet<Gate> Gates { get; set; }

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