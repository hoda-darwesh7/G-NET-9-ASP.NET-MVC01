using Microsoft.EntityFrameworkCore;
using MVC_1.Configrations;
using MVC_1.Models;
using System.Numerics;

namespace MVC_1.Context
{
    public class GymDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = 7ODA ; Database = GymDb ; Trusted_Connection = true ; TrustServerCertificate = true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Plan>(new PlanConfigration());
        }
        public DbSet<Plan> Plans { get; set; }
    }
}
