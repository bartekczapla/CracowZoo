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
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false,
            //    Description = "",
            //    MapItemType = MapItemType.SingleAnimal
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 2, // Antias pomarańczowy
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 3, // Pyszczak żołty
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 4, // Szczelinowiec z Burundi
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 5, // Pokolec królewski
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 6, // Amfiprion okoniowy
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 7, // Stadnik żółtoogonowy
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            #endregion

            #region PłAZY 8-15

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 8, // Drzewołaz złoty
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 9,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 10,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 11,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 12,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 13,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 14,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 15,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            #endregion

            #region GADY 16-30

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 16, // Żółw żabuti
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 17,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 18,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 19,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 20,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 21,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 22,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 23,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 24,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 25,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 26,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 27,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 28,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 29,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 30,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            #endregion

            #region PTAKI 31-91

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 31, // Struś afrykański
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Strusie afrykańskie",
                MapItemType = MapItemType.SingleAnimal
            });

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 32,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 33,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 34,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 35,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 36,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 37,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 38,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 39,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 40,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 41,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 42,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 43,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 44,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 45,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 46,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 47,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 48,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 49,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 50,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 51,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Pingwiny Humboldta",
                MapItemType = MapItemType.SingleAnimal
            });

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 52,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Flamingi",
                MapItemType = MapItemType.SingleAnimal
            });

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 53,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 54,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 55,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 56,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 57,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 58,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 59,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 60,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 61,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 62,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 63,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 64,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 65,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 66,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Żurawie mandżurskie",
                MapItemType = MapItemType.SingleAnimal
            });

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 67,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 68,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 69,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 70,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 71,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 72,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 73,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 74,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 75,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 76,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 77,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 78,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 79,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 80,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 81,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 82,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 83,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 84,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 85,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 86,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 87,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 88,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 89,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 90,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 91,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            #endregion

            #region SSAKI 92-169

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 92, // Kuskus ziemny
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 93, // Lotopałanka mała
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 94, // Walabia Benetta
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 95, // Słoń indyjski
                Latitude = 50.0547071927596,
                Longitude = 19.8540695384145,
                Marked = false,
                Name = "Słonie",
                MapItemType = MapItemType.SingleAnimal
            });

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 96, // Pancernik włochaty
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 97, // Leniwiec dwupalczasty
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 98, // Lemur czerwonobrzuchy
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 99, // Lemur katta
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 100, // Lemur wari
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});

            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 101,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 102,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 103,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 104,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 105,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 106,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 107,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 108,
            //    Latitude = 0,
            //    Longitude = 0,
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
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 111,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 112,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 113,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 114,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 115,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 116,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 117,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Manule",
                MapItemType = MapItemType.SingleAnimal
            });
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 118,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 119,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 120,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 121,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 122,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 123,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 124,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 125,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 126,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 127,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 128,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 129,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 130,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 131,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 132,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 133,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 134,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 135,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Uchatki patagońskie",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 136,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Wydry",
                MapItemType = MapItemType.SingleAnimal
            });
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 137,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 138,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 139,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 140,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 141,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Pandy małe",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 142,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Osły",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 143,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Zebry Chapmana",
                MapItemType = MapItemType.SingleAnimal
            });
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 144,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 145,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Konie przewalskiego",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 146,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Kułany",
                MapItemType = MapItemType.SingleAnimal
            });
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 147,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 148,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 149,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Hipopotamy karłowate",
                MapItemType = MapItemType.SingleAnimal
            });
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 150,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 151,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 152,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 153,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Wikunie",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 154,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Renifery",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 155,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Jelenie europejskie",
                MapItemType = MapItemType.SingleAnimal
            });
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 156,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 157,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Jelenie Milu",
                MapItemType = MapItemType.SingleAnimal
            });
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 158,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 159,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Mundżaki chińskie",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 160,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Żyrafy",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 161,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Antylopy Eland",
                MapItemType = MapItemType.SingleAnimal
            });
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 162,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 163,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Owce grzywiaste Arui",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 164,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Takiny",
                MapItemType = MapItemType.SingleAnimal
            });
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 165,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            //modelBuilder.Entity<MapItem>().HasData(new MapItem
            //{
            //    Id = 166,
            //    Latitude = 0,
            //    Longitude = 0,
            //    Marked = false
            //});
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 167,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Antylopy addaks",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 168,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Kob śniady",
                MapItemType = MapItemType.SingleAnimal
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 169,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Antylopy kob liczi",
                MapItemType = MapItemType.SingleAnimal
            });

            #endregion

            #region GRUPY ZWIERZĄT
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 300,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Bażanty, Papugi",
                Description = "Woliery przy kasie ZOO zamieszkują bażanty (tragopany, bażnty srebrzyste, olśniaki himalajskie, uszaki brunatne i siwe), papugi (nierozłączki, aleksandretty różane, mnichy), toko czarnoskrzydłe, kukabury, turaki, gołębie.",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 301,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Pazurzatki",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 302,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Surykatki",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 303,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Ptaki w wolierach",
                Description = "Woliery przy dużym stawie zamieszkują papugi, bażanty, kaczki oraz sowy uszate.",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 304,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Ptaki wodne – duży staw",
                Description = "Duży Staw zamieszkują gęsi, kaczki, pelikany różowe, marabuty, żurawie koroniaste, ptaki brodzące: bocian biały i czarny, ibisy purpurowe, australijskie i warząchy.",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 305,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Ptaki wodne – mały staw",
                Description = "Mały Staw zamieszkują kazarki, ohary, hełmiatki, bernikle białolice, łabędzie czarne i żurawie koroniaste.",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 306,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Koty",
                Description = "Kotowate średniej wielkości",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 307,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Jeżozwierze, Psowate",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 308,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Tapiry i nandu",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 309,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Wielbłądy i Gwanko",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 310,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Małe drapieżniki i gryzonie",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 311,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Sowy i ptaki drapieżne",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 312,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Kotowate",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 313,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Kangury i strusie emu",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 314,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Orły, Sępy i Kondory",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 315,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Lemury, Małpy Sajmrir",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 316,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Antylopy Nilgau, Markury",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 317,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Daniele, Jelenie Barasinga",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 318,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Wielkie koty",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 319,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Sowy",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 320,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Nocny pawilon",
                Description = "Pawilon ten zamieszkują fenki, pancerniki włochate, kuskusy ziemne, nietoperze rudawki, lori małe, galago, lotopałanki małe",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 321,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Średnie drapieżniki",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 322,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Małpy",
                Description = "",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 323,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Egzotarium",
                Description = "Eksponujemy w nim małą cząstkę ekosystemu rafy koralowej Indopacyfiku, na który składają się: żywe koralowce, wieloszczety, strzykwa, krewetki, rozgwiazda, jeżowiec, ryby morskie.",
                MapItemType = MapItemType.ManyAnimals
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 324,
                Latitude = 0,
                Longitude = 0,
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
                Latitude = 50.0551575271377,
                Longitude = 19.8539763316512,
                Marked = false,
                Name = "Wejście",
                MapItemType = MapItemType.Place
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 401,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Plac zabaw",
                MapItemType = MapItemType.Place
            });
            modelBuilder.Entity<MapItem>().HasData(new MapItem
            {
                Id = 402,
                Latitude = 0,
                Longitude = 0,
                Marked = false,
                Name = "Ul pszczeli",
                MapItemType = MapItemType.Place
            });
            #endregion
        }
    }
}
