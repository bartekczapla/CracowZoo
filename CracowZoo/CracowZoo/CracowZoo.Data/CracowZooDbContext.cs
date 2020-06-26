using CracowZoo.Data.Seed;
using CracowZoo.Models;
using Microsoft.EntityFrameworkCore;

namespace CracowZoo.Data
{
    public class CracowZooDbContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }

        private readonly string _connectionString;

        public CracowZooDbContext(string connectionString)
            : base()
        {
            _connectionString = connectionString;
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
     }
}
