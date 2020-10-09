using CracowZoo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CracowZoo.Data.Seed
{
    public static class TicketsSeed
    {
        public static void SeedTickets(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                Id = 1,
                Type = "Normalny",
                AdditionalInfo = string.Empty,
                SummerPrice = 22,
                WinterPrice = 18,
            });

            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                Id = 2,
                Type = "Ulgowy",
                AdditionalInfo = "Przysługuje dzieciom od 3 roku życia, uczniom szkół podstawowych, dziennych szkół ponadpodstawowych, studentom do ukończenia 26 roku życia, emerytom i rencistom.",
                SummerPrice = 15,
                WinterPrice = 10,
            });
            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                Id = 3,
                Type = "Zbiorowy",
                AdditionalInfo = "Dla uczestników wycieczek zorganizowanych przez biura turystyczne, organizacje społeczne i inne organizacje oraz szkoły), na 10 - cioro zwiedzających 1 osoba opieki ma wstęp bezpłatny.",
                SummerPrice = 15,
                WinterPrice = 10,
            });
            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                Id = 4,
                Type = "Roczny",
                AdditionalInfo = "Ważny przez 365 dni od dnia zakupu.",
                SummerPrice = 200,
                WinterPrice = 0,
            });
            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                Id = 5,
                Type = "Krakowska Karta Rodzinna 3+",
                AdditionalInfo = "Bilet normalny 11 zł, bilet ulgowy 8 zł (obowiązuje przez cały rok).",
                SummerPrice = 11,
                WinterPrice = 0,
            });
            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                Id = 6,
                Type = "Program Kraków dla rodziny „N”",
                AdditionalInfo = "Dziecko niepełnosprawne – wejście bezpłatne, osoba dorosła – bilet normalny 11 zł, dziecko towarzyszące – bilet ulgowy 8 zł(obowiązuje przez cały rok).",
                SummerPrice = 11,
                WinterPrice = 0,
            });
        }
    }
}
