using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;

namespace SamuraiApp.Data
{
    public class SamuraiDbContext : DbContext
    {
        public SamuraiDbContext()
        {
            
        }

        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Clan> Clans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = SamuraiAppData";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}