using CracowZoo.Data.Seed;
using CracowZoo.Models;
using Microsoft.EntityFrameworkCore;

namespace CracowZoo.Data
{
    public class CracowZooDbContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalTidbit> AnimalTidbits { get; set; }
        public DbSet<MapItem> MapItems { get; set; }
        public DbSet<ZooPlace> ZooPlaces { get; set; }

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
            modelBuilder.SeedAnimals();
            modelBuilder.SeedMapItems();
            modelBuilder.SeedAnimalTidbits();
        }
     }
}
