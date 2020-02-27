using CracowZoo.Core;
using CracowZoo.DataAccess.Entity;
using CracowZoo.DataAccess.Seed;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace CracowZoo.DataAccess
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
           // var platformSettingsProvider = DependencyService.Get<IPlatformSettingsProvider>(); not working :<
            optionsBuilder.UseSqlite(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
     }
}
