
using backend.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Core.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }

        public DbSet<Sport> Sports { get; set; }
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Competition> Competitions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Competition>()
                .HasOne(c => c.Sport)
                .WithMany(s => s.Competitions)
                .HasForeignKey(c => c.SportId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Athlete>()
                .HasOne(a => a.Sport)
                .WithMany(s => s.Athletes)
                .HasForeignKey(a => a.SportId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Competition>()
                .HasMany(c => c.Competitors)
                .WithMany(a => a.Competitions);

            modelBuilder.Entity<Competition>()
                .HasOne(c => c.Winner)
                .WithOne()
                .HasForeignKey<Competition>(c => c.WinnerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Competition>()
                .Property(c => c.Rang)
                .HasConversion<string>();

            modelBuilder.Entity<Athlete>()
                .Property(a => a.Region)
                .HasConversion<string>();

        }
    }
}
