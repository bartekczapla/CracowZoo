using CracowZoo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CracowZoo.Data.Seed
{
    public static class MapItemsSeed
    {
        public static void SeedMapItems(this ModelBuilder modelBuilder)
        {
            // RYBY
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 1, // Pirania czerwona
                X = 0,
                Y = 0
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 2, // Antias pomarańczowy
                X = 0,
                Y = 0
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 3, // Pyszczak żołty
                X = 0,
                Y = 0
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 4, // Szczelinowiec z Burundi
                X = 0,
                Y = 0
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 5, // Pokolec królewski
                X = 0,
                Y = 0
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 6, // Amfiprion okoniowy
                X = 0,
                Y = 0
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 7, // Stadnik żółtoogonowy
                X = 0,
                Y = 0
            });

            //PŁAZY

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = , // 
            //    X = 0,
            //    Y = 0
            //});

        }
    }
}
