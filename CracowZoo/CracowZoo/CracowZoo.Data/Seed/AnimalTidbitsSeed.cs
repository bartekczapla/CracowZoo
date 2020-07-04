using CracowZoo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CracowZoo.Data.Seed
{
    public static class AnimalTidbitsSeed
    {
        public static void SeedAnimalTidbits(this ModelBuilder modelBuilder)
        {
            // RYBY
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 1,
                Description = "Żyje w stadach liczących 20-30 osobników",
                AnimalId = 1 // Pirania czerwona
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 2,
                Description = "Jest uważana za najbardziej niebezpieczną i agresywną piranię",
                AnimalId = 1 // Pirania czerwona
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 3,
                Description = "W Brazylii wprowadza się specjalne strefy ochronne, w celu zabezpieczenia zażywających kąpieli osób przed atakami ryb",
                AnimalId = 1 // Pirania czerwona
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 4,
                Description = "Często przebywa w pobliżu wraków statków. Od tego pochodzi jej inna nazwa „antias wrakówka”.",
                AnimalId = 2 // Antias pomarańczowy
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 5,
                Description = "Przedstawiciel rodziny pielęgnicowatych. Osiąga około 10 cm długości.",
                AnimalId = 3 // Pyszczak żołty
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 6,
                Description = "Przedstawiciel rodziny pielęgnicowatych. Gatunek terytorialny. Osiąga około 10 cm długości.",
                AnimalId = 4 // 
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 7,
                Description = "U nasady płetwy ogonowej posiada wysuwane ostrze, służące do obrony przed wrogami.",
                AnimalId = 5 // Pokolec królewski
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 8,
                Description = "Przedstawiciel rodziny pokolcowatych. Osiąga 25 cm długości.",
                AnimalId = 5 // Pokolec królewski
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 9,
                Description = "Bytują pojedynczo, w parach lub w małych ławicach.",
                AnimalId = 6 // Amfiprion okoniowy
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 10,
                Description = "Żyją w symbiozie z ukwiałami, co przynosi obopólne korzyści. Amfiprion jest bezpieczny wśród parzących czułków ukwiała. Obecność ryby zwabia zwierzęta, które mogą stać się pożywieniem koralowca.",
                AnimalId = 6 // Amfiprion okoniowy
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 11,
                Description = "Ryby dorastają do 7 cm długości ciała.",
                AnimalId = 7 // Stadnik żółtoogonowy
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 12,
                Description = "Przedstawiciel rodziny garbikowatych. Żyje w niewielkich grupach.",
                AnimalId = 7 // Stadnik żółtoogonowy
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 13,
                Description = "Jedna z nielicznych tropikalnych ryb morskich, którą udało się rozmnożyć w akwarium.",
                AnimalId = 7 // Stadnik żółtoogonowy
            });

            // PŁAZY

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 14,
                Description = "W skórze tego płaza znajdują się gruczoły produkujące silną neurotoksynę.",
                AnimalId = 8
            });

            // GADY

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 15,
                Description = "Karapaks (grzbietowa część pancerza) prezentowanego w naszym Zoo osobnika mierzy 40 cm długości. Ma on ponad 50 lat.",
                AnimalId = 16 //Żółw żabuti
            });

            // PTAKI

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 16,
                Description = "Największy ptak żyjący obecnie na ziemi, najszybszy spośród nielotnych ptaków lądowych.",
                AnimalId = 31 // Struś afrykański
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 17,
                Description = "Na dłuższych dystansach biega z prędkością 50 km/h, a na krótszych – nawet do 70 km/h.",
                AnimalId = 31 // Struś afrykański
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 18,
                Description = "Jego stopy zakończone są tylko 2 palcami.",
                AnimalId = 31 // Struś afrykański
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 19,
                Description = "Ma doskonały wzrok – widzi dobrze na odległość do około 5 km.",
                AnimalId = 31 // Struś afrykański
            });


            // SSAKI

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 20,
                Description = "W Azji wykorzystywany jako zwierzę pociągowe, juczne i wierzchowe.",
                AnimalId = 95 // Słoń indyjski
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 21,
                Description = "Słonie prowadzą stadny tryb życia. Przewodnikiem stada jest stara samica.",
                AnimalId = 95 // Słoń indyjski
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 22,
                Description = "Samce są nieco mniejsze i smuklejsze od samic.",
                AnimalId = 9 // PLAZY
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 23,
                Description = "Samice bywają wobec siebie agresywne.",
                AnimalId = 9 // PLAZY
            });

            //modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            //{
            //    Id = ,
            //    Description = "",
            //    AnimalId = 
            //});
        }
    }
}
