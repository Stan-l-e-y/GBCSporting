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
    }
}
