using Microsoft.EntityFrameworkCore;

namespace GBCSportingWeb.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base( options )
        {
                      
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Incident> Incidents { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Technician> Technicians { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country { CountryId = 1, Name = "Canada" });

            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, },
                new Customer { CustomerId = 2, });

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, },
                new Product { ProductId = 2, });

            modelBuilder.Entity<Technician>().HasData(
                new Technician { TechnicianId = 1, },
                new Technician { TechnicianId = 2, });

            modelBuilder.Entity<Incident>().HasData(
                new Incident { IncidentId = 1, CustomerId = 1, ProductId = 1, TechnicianId = 1, Title = "Problem!!", DateOpened = DateTime.Now, DateClosed = DateTime.Now },
                new Incident { IncidentId = 2, CustomerId = 2, ProductId = 2, TechnicianId = 2, Title = "Another one!!!", DateOpened = DateTime.Now, DateClosed = DateTime.Now });

            
        }
    }
}
