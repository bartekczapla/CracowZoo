using CracowZoo.DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CracowZoo.DataAccess.Seed
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>().HasData(new Test { Id = 1, Description = "This is test description from dB" });
            modelBuilder.Entity<Test>().HasData(new Test { Id = 2, Description = "This is test description 2 from dB" });
        }
    }
}
