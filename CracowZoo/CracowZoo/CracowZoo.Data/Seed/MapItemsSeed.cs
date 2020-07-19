﻿using CracowZoo.Models;
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
            #region RYBY 1-7
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 1, // Pirania czerwona
                X = 0,
                Y = 0,
                Marked = false
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 2, // Antias pomarańczowy
                X = 0,
                Y = 0,
                Marked = false
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 3, // Pyszczak żołty
                X = 0,
                Y = 0,
                Marked = false
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 4, // Szczelinowiec z Burundi
                X = 0,
                Y = 0,
                Marked = false
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 5, // Pokolec królewski
                X = 0,
                Y = 0,
                Marked = false
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 6, // Amfiprion okoniowy
                X = 0,
                Y = 0,
                Marked = false
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 7, // Stadnik żółtoogonowy
                X = 0,
                Y = 0,
                Marked = false
            });
            #endregion

            #region PłAZY 8-15

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 8, // Drzewołaz złoty
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 9,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 10,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 11,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 12,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 13,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 14,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 15,
                X = 0,
                Y = 0,
                Marked = false
            });
            #endregion

            #region GADY 16-30

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 16, // Żółw żabuti
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 17,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 18,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 19,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 20,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 21,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 22,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 23,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 24,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 25,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 26,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 27,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 28,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 29,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 30,
                X = 0,
                Y = 0,
                Marked = false
            });

            #endregion

            #region PTAKI 31-91

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 31, // Struś afrykański
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 32,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 33,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 34,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 35,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 36,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 37,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 38,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 39,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 40,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 41,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 42,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 43,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 44,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 45,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 46,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 47,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 48,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 49,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 50,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 51,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 52,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 53,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 54,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 55,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 56,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 57,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 58,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 59,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 60,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 61,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 62,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 63,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 64,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 65,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 66,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 67,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 68,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 69,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 70,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 71,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 72,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 73,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 74,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 75,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 76,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 77,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 78,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 79,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 80,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 81,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 82,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 83,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 84,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 85,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 86,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 87,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 88,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 89,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 90,
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 91,
                X = 0,
                Y = 0,
                Marked = false
            });

            #endregion

            #region SSAKI 92-170

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 92, // Kuskus ziemny
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 93, // Lotopałanka mała
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 94, // Walabia Benetta
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 95, // Słoń indyjski
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 96, // Pancernik włochaty
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 97, // Leniwiec dwupalczasty
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 98, // Lemur czerwonobrzuchy
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 99, // Lemur katta
                X = 0,
                Y = 0,
                Marked = false
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 100, // Lemur wari
                X = 0,
                Y = 0,
                Marked = false
            });
            #endregion
        }
    }
}
