using CracowZoo.Models;
using Microsoft.EntityFrameworkCore;
namespace CracowZoo.Data.Seed
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>().HasData(new Test { Id = 1, Description = "This is new seed after architecture change" });
            modelBuilder.Entity<Test>().HasData(new Test { Id = 2, Description = "This is new seed after architecture change 2" });
        }
    }
}
