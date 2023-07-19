using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .LogTo(Console.WriteLine, new[] { InMemoryEventId.ChangesSaved })
                .UseInMemoryDatabase("SpaceXDB", b => b.EnableNullChecks(false));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Launche>().Ignore(c => c.mission_id);
            modelBuilder.Entity<Launche>().Ignore(c => c.ships);
            modelBuilder.Entity<Launche>().Ignore(c => c.crew);
            modelBuilder.Entity<Links>().Ignore(c => c.flickr_images);
            modelBuilder.Entity<Payload>().Ignore(c => c.norad_id);
            modelBuilder.Entity<Payload>().Ignore(c => c.customers);
        }
        public DbSet<Launche> Launches { get; set; }
    }
}