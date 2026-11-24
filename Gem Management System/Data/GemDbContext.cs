using Microsoft.EntityFrameworkCore;
using Gem_Management_System.Models;
using Gem_Management_System.Entities;
namespace Gem_Management_System.Data

{
    public class GemDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=GymManagementDB;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<MemberShip> MemberShips { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GemDbContext).Assembly);
        }


    }
}
