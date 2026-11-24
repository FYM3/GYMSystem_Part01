using GYMSystem_Part01.Entites;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GYMSystem_Part01.Context
{
    public class GymDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; Database = GYMSystemDB; Trusted_Connection = True; TrustServerCertificate = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        #region DbSets

        public DbSet<GymUser> GymUsers { get; set; } = default!;
          public DbSet<Member> Members { get; set; } = default!;
          public DbSet<Plan> Plans { get; set; } = default!;
          public DbSet<MemberShip> Memberships { get; set; } = default!;
          public DbSet<Trainer> Trainers { get; set; } = default!;

        #endregion
    }
}
