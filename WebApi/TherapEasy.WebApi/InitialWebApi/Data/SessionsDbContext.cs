using InitialWebApi.Model;
using Microsoft.EntityFrameworkCore;

namespace InitialWebApi.Data
{
    public class SessionsDbContext : DbContext
    {
        public DbSet<Sessions> Sessions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("YourConnectionStringHere");
            }

        }
    }
}