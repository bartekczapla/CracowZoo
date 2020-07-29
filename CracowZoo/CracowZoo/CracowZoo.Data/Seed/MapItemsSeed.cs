using CracowZoo.Enums;
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
            #region RYBY 1-7
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 1, // Pirania czerwona
            //    X = 0,
            //    Y = 0,
            //    Marked = false,
            //    Description = "",
            //    MapItemType = MapItemType.SingleAnimal
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 2, // Antias pomarańczowy
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 3, // Pyszczak żołty
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 4, // Szczelinowiec z Burundi
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 5, // Pokolec królewski
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 6, // Amfiprion okoniowy
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 7, // Stadnik żółtoogonowy
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            #endregion

            #region PłAZY 8-15

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 8, // Drzewołaz złoty
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 9,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 10,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 11,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 12,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 13,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 14,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 15,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            #endregion

            #region GADY 16-30

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 16, // Żółw żabuti
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 17,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 18,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 19,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 20,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 21,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 22,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 23,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 24,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 25,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 26,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 27,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 28,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 29,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 30,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            #endregion

            #region PTAKI 31-91

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 31, // Struś afrykański
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Strusie afrykańskie",
                MapItemType = MapItemType.SingleAnimal
            });

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 32,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 33,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 34,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 35,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 36,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 37,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 38,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 39,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 40,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 41,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 42,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 43,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 44,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 45,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 46,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 47,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 48,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 49,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 50,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 51,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Pingwiny Humboldta",
                MapItemType = MapItemType.SingleAnimal
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 52,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Flamingi",
                MapItemType = MapItemType.SingleAnimal
            });

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 53,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 54,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 55,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 56,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 57,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 58,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 59,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 60,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 61,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 62,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 63,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 64,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 65,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 66,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Żurawie mandżurskie",
                MapItemType = MapItemType.SingleAnimal
            });

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 67,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 68,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 69,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 70,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 71,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 72,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 73,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 74,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 75,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 76,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 77,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 78,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 79,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 80,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 81,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 82,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 83,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 84,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 85,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 86,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 87,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 88,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 89,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 90,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 91,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            #endregion

            #region SSAKI 92-169

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 92, // Kuskus ziemny
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 93, // Lotopałanka mała
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 94, // Walabia Benetta
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 95, // Słoń indyjski
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Słonie",
                MapItemType = MapItemType.SingleAnimal
            });

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 96, // Pancernik włochaty
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 97, // Leniwiec dwupalczasty
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 98, // Lemur czerwonobrzuchy
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 99, // Lemur katta
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 100, // Lemur wari
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 101,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 102,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 103,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 104,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 105,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 106,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 107,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 108,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 109,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 110,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 111,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 112,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 113,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 114,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 115,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 116,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 117,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Manule",
                MapItemType = MapItemType.SingleAnimal
            });
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 118,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 119,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 120,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 121,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 122,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 123,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 124,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 125,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 126,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 127,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 128,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 129,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 130,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 131,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 132,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 133,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 134,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 135,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Uchatki patagońskie",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 136,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Wydry",
                MapItemType = MapItemType.SingleAnimal
            });
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 137,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 138,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 139,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 140,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 141,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Pandy małe",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 142,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Osły",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 143,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Zebry Chapmana",
                MapItemType = MapItemType.SingleAnimal
            });
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 144,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 145,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Konie przewalskiego",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 146,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Kułany",
                MapItemType = MapItemType.SingleAnimal
            });
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 147,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 148,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 149,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Hipopotamy karłowate",
                MapItemType = MapItemType.SingleAnimal
            });
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 150,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 151,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 152,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 153,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Wikunie",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 154,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Renifery",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 155,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Jelenie europejskie",
                MapItemType = MapItemType.SingleAnimal
            });
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 156,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 157,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Jelenie Milu",
                MapItemType = MapItemType.SingleAnimal
            });
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 158,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 159,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Mundżaki chińskie",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 160,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Żyrafy",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 161,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Antylopy Eland",
                MapItemType = MapItemType.SingleAnimal
            });
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 162,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 163,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Owce grzywiaste Arui",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 164,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Takiny",
                MapItemType = MapItemType.SingleAnimal
            });
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 165,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 166,
            //    X = 0,
            //    Y = 0,
            //    Marked = false
            //});
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 167,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Antylopy addaks",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 168,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Kob śniady",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 169,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Antylopy kob liczi",
                MapItemType = MapItemType.SingleAnimal
            });

            #endregion

            #region GRUPY ZWIERZĄT
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 300,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Bażanty, Papugi",
                Description = "Woliery przy kasie ZOO zamieszkują bażanty (tragopany, bażnty srebrzyste, olśniaki himalajskie, uszaki brunatne i siwe), papugi (nierozłączki, aleksandretty różane, mnichy), toko czarnoskrzydłe, kukabury, turaki, gołębie.",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 301,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Pazurzatki",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 302,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Surykatki",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 303,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Ptaki w wolierach",
                Description = "Woliery przy dużym stawie zamieszkują papugi, bażanty, kaczki oraz sowy uszate.",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 304,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Ptaki wodne – duży staw",
                Description = "Duży Staw zamieszkują gęsi, kaczki, pelikany różowe, marabuty, żurawie koroniaste, ptaki brodzące: bocian biały i czarny, ibisy purpurowe, australijskie i warząchy.",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 305,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Ptaki wodne – mały staw",
                Description = "Mały Staw zamieszkują kazarki, ohary, hełmiatki, bernikle białolice, łabędzie czarne i żurawie koroniaste.",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 306,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Koty",
                Description = "Kotowate średniej wielkości",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 307,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Jeżozwierze, Psowate",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 308,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Tapiry i nandu",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 309,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Wielbłądy i Gwanko",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 310,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Małe drapieżniki i gryzonie",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 311,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Sowy i ptaki drapieżne",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 312,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Kotowate",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 313,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Kangury i strusie emu",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 314,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Orły, Sępy i Kondory",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 315,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Lemury, Małpy Sajmrir",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 316,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Antylopy Nilgau, Markury",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 317,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Daniele, Jelenie Barasinga",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 318,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Wielkie koty",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 319,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Sowy",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 320,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Nocny pawilon",
                Description = "Pawilon ten zamieszkują fenki, pancerniki włochate, kuskusy ziemne, nietoperze rudawki, lori małe, galago, lotopałanki małe",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 321,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Średnie drapieżniki",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 322,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Małpy",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 323,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Egzotarium",
                Description = "Eksponujemy w nim małą cząstkę ekosystemu rafy koralowej Indopacyfiku, na który składają się: żywe koralowce, wieloszczety, strzykwa, krewetki, rozgwiazda, jeżowiec, ryby morskie.",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 324,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Mini Zoo",
                Description = "",
                MapItemType = MapItemType.Place
            });
            #endregion

            #region MIEJSCA
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 400,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Wejście",
                MapItemType = MapItemType.Place
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 401,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Plac zabaw",
                MapItemType = MapItemType.Place
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 402,
                X = 0,
                Y = 0,
                Marked = false,
                Name = "Ul pszczeli",
                MapItemType = MapItemType.Place
            });
            #endregion
        }
    }
}
