using CracowZoo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CracowZoo.Data.Seed
{
    public static class ZooEventsSeed
    {
        public static void SeedZooEvents(this ModelBuilder modelBuilder)
        {
            #region Karmienie słoni
            modelBuilder.Entity<ZooEvent>().HasData(new ZooEvent
            {
                Id = 1,
                Name = "Karmienie słoni",
                Conditions = "(przy sprzyjających warunkach atmosferycznych)"
            });

            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 1,
                ZooEventId = 1,
                Day = DayOfWeek.Monday,
                Time = new TimeSpan(13, 0, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 2,
                ZooEventId = 1,
                Day = DayOfWeek.Tuesday,
                Time = new TimeSpan(13, 0, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 3,
                ZooEventId = 1,
                Day = DayOfWeek.Wednesday,
                Time = new TimeSpan(13, 0, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 4,
                ZooEventId = 1,
                Day = DayOfWeek.Thursday,
                Time = new TimeSpan(13, 0, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 5,
                ZooEventId = 1,
                Day = DayOfWeek.Friday,
                Time = new TimeSpan(13, 0, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 6,
                ZooEventId = 1,
                Day = DayOfWeek.Saturday,
                Time = new TimeSpan(13, 0, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 7,
                ZooEventId = 1,
                Day = DayOfWeek.Sunday,
                Time = new TimeSpan(13, 0, 0)
            });

            #endregion

            #region Karmienie uchatek
            modelBuilder.Entity<ZooEvent>().HasData(new ZooEvent
            {
                Id = 2,
                Name = "Karmienie uchatek"
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 8,
                ZooEventId = 2,
                Day = DayOfWeek.Monday,
                Time = new TimeSpan(9, 30, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 9,
                ZooEventId = 2,
                Day = DayOfWeek.Tuesday,
                Time = new TimeSpan(9, 30, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 10,
                ZooEventId = 2,
                Day = DayOfWeek.Wednesday,
                Time = new TimeSpan(9, 30, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 11,
                ZooEventId = 2,
                Day = DayOfWeek.Thursday,
                Time = new TimeSpan(9, 30, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 12,
                ZooEventId = 2,
                Day = DayOfWeek.Saturday,
                Time = new TimeSpan(9, 30, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 13,
                ZooEventId = 2,
                Day = DayOfWeek.Sunday,
                Time = new TimeSpan(14, 0, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 14,
                ZooEventId = 2,
                Day = DayOfWeek.Monday,
                Time = new TimeSpan(14, 0, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 15,
                ZooEventId = 2,
                Day = DayOfWeek.Tuesday,
                Time = new TimeSpan(14, 0, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 16,
                ZooEventId = 2,
                Day = DayOfWeek.Wednesday,
                Time = new TimeSpan(14, 0, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 17,
                ZooEventId = 2,
                Day = DayOfWeek.Thursday,
                Time = new TimeSpan(14, 0, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 18,
                ZooEventId = 2,
                Day = DayOfWeek.Saturday,
                Time = new TimeSpan(14, 0, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 19,
                ZooEventId = 2,
                Day = DayOfWeek.Sunday,
                Time = new TimeSpan(14, 0, 0)
            });
            #endregion

            #region Karmienie pingwinów
            modelBuilder.Entity<ZooEvent>().HasData(new ZooEvent
            {
                Id = 3,
                Name = "Karmienie pingwinów",
                Conditions = "(przy sprzyjających warunkach atmosferycznych)"
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 20,
                ZooEventId = 3,
                Day = DayOfWeek.Monday,
                Time = new TimeSpan(10, 0, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 21,
                ZooEventId = 3,
                Day = DayOfWeek.Tuesday,
                Time = new TimeSpan(10, 0, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 22,
                ZooEventId = 3,
                Day = DayOfWeek.Wednesday,
                Time = new TimeSpan(10, 0, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 23,
                ZooEventId = 3,
                Day = DayOfWeek.Thursday,
                Time = new TimeSpan(10, 0, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 24,
                ZooEventId = 3,
                Day = DayOfWeek.Thursday,
                Time = new TimeSpan(10, 0, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 25,
                ZooEventId = 3,
                Day = DayOfWeek.Saturday,
                Time = new TimeSpan(10, 0, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 26,
                ZooEventId = 3,
                Day = DayOfWeek.Sunday,
                Time = new TimeSpan(10, 0, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 27,
                ZooEventId = 3,
                Day = DayOfWeek.Monday,
                Time = new TimeSpan(13, 30, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 28,
                ZooEventId = 3,
                Day = DayOfWeek.Tuesday,
                Time = new TimeSpan(13, 30, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 29,
                ZooEventId = 3,
                Day = DayOfWeek.Wednesday,
                Time = new TimeSpan(13, 30, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 30,
                ZooEventId = 3,
                Day = DayOfWeek.Thursday,
                Time = new TimeSpan(13, 30, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 31,
                ZooEventId = 3,
                Day = DayOfWeek.Friday,
                Time = new TimeSpan(13, 30, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 32,
                ZooEventId = 3,
                Day = DayOfWeek.Saturday,
                Time = new TimeSpan(13, 30, 0)
            });
            modelBuilder.Entity<ZooEventDate>().HasData(new ZooEventDate
            {
                Id = 33,
                ZooEventId = 3,
                Day = DayOfWeek.Sunday,
                Time = new TimeSpan(13, 30, 0)
            });
            #endregion
        }
    }
}
