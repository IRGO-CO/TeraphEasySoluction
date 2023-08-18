using Microsoft.EntityFrameworkCore;
using TherapEasy.WebApi.Models;

namespace TherapEasy.WebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        //public DbSet<User> Users { get; set; }
        public DbSet<Session> Sessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* modelBuilder.Entity<User>(e =>
            {
                e.HasKey(u => u.Id); // Define a chave primária

                // Configuração de propriedades
                e.Property(u => u.Name).IsRequired().HasMaxLength(100);
                e.Property(u => u.IsTherapist);
                e.Property(u => u.UserName).IsRequired().HasMaxLength(50);
                e.Property(u => u.Email).IsRequired().HasMaxLength(100);
                e.Property(u => u.PasswordHash).IsRequired().HasMaxLength(200); // Aumente o tamanho conforme necessário

                // Configuração do relacionamento com Sessions
                e.HasMany(u => u.SessionsAsTherapist)
                    .WithOne(s => s.Therapist)
                    .HasForeignKey(s => s.TherapistId);
                e.HasMany(u => u.SessionsAsPatient)
                    .WithOne(s => s.Patient)
                    .HasForeignKey(s => s.PatientId);

            });*/

            modelBuilder.Entity<Session>(e =>
            {
                e.HasKey(u => u.Id);
                e.Property(u => u.StartTime).IsRequired();
                e.Property(u => u.EndTime).IsRequired();
                e.Property(u => u.IsActive);
                e.Property(u => u.Description);
            });
        }
    }
}