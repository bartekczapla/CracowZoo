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
            #region RYBY 1-7
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

            #endregion

            #region PłAZY 8-15

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 100,
                Description = "W skórze tego płaza znajdują się gruczoły produkujące silną neurotoksynę.",
                AnimalId = 8
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 101,
                Description = "Samce są nieco mniejsze i smuklejsze od samic.",
                AnimalId = 9
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 102,
                Description = "Samice bywają wobec siebie agresywne.",
                AnimalId = 9
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 103,
                Description = "Drzewołaz malarski jest gatunkiem o bardzo dużej zmienności osobniczej.",
                AnimalId = 10
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 104,
                Description = "Osobniki obydwu płci łatwo odróżnić: zgrubienia na końcach palców przednich kończyn samców są większe niż na palcach samic i mają kształt sercowaty.",
                AnimalId = 10
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 105,
                Description = "Jest to jeden z najczęściej hodowanych przedstawicieli rodziny drzewołazowatych.",
                AnimalId = 11
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 106,
                Description = "Jaskrawe ubarwienie strony brzusznej wskazuje na toksyczność i przykry smak tego płaza. Odstrasza to potencjalne drapieżniki.",
                AnimalId = 12
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 107,
                Description = "Palce tego płaza zakończone są przylgami.",
                AnimalId = 13
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 108,
                Description = "Są aktywne nocą.",
                AnimalId = 13
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 109,
                Description = "Samce są nieco mniejsze od samic.",
                AnimalId = 13
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 110,
                Description = "Jest jednym z największych przedstawicieli australijskich płazów bezogonowych – osiąga 10 cm długości. ",
                AnimalId = 14
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 111,
                Description = "W niewoli dożywa nawet do 16 lat.",
                AnimalId = 14
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 112,
                Description = "Gatunek ten bywa hodowany w domowych terrariach.",
                AnimalId = 15
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 113,
                Description = "Samce dorastają do 6 cm, samice mogą osiągnąć długość nawet ponad 10 cm.",
                AnimalId = 15
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 114,
                Description = "Młode żabki są jaśniejsze od dorosłych osobników.",
                AnimalId = 15
            });

            #endregion

            #region GADY 16-30

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 200,
                Description = "Karapaks (grzbietowa część pancerza) prezentowanego w naszym Zoo osobnika mierzy 40 cm długości. Ma on ponad 50 lat.",
                AnimalId = 16 //Żółw żabuti
            });

            #endregion

            #region PTAKI 31-91

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 300,
                Description = "Największy ptak żyjący obecnie na ziemi, najszybszy spośród nielotnych ptaków lądowych.",
                AnimalId = 31 // Struś afrykański
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 301,
                Description = "Na dłuższych dystansach biega z prędkością 50 km/h, a na krótszych – nawet do 70 km/h.",
                AnimalId = 31 // Struś afrykański
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 302,
                Description = "Jego stopy zakończone są tylko 2 palcami.",
                AnimalId = 31 // Struś afrykański
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 303,
                Description = "Ma doskonały wzrok – widzi dobrze na odległość do około 5 km.",
                AnimalId = 31 // Struś afrykański
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 304,
                Description = "Zagrożony, struś ucieka, ale może też zadać obrażenia, a nawet zabić swoimi silnymi nogami.",
                AnimalId = 31 // Struś afrykański
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 305,
                Description = "Wbrew powszechnemu przekonaniu strusie nie zakopują głowy w piasek, aby uniknąć niebezpieczeństwa",
                AnimalId = 31 // Struś afrykański
            });
            #endregion

            #region SSAKI 92-170

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 400,
                Description = "W Azji wykorzystywany jako zwierzę pociągowe, juczne i wierzchowe.",
                AnimalId = 95 // Słoń indyjski
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 401,
                Description = "Słonie prowadzą stadny tryb życia. Przewodnikiem stada jest stara samica.",
                AnimalId = 95 // Słoń indyjski
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 402,
                Description = "Samce są nieco mniejsze i smuklejsze od samic.",
                AnimalId = 9 
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 403,
                Description = "Samice bywają wobec siebie agresywne.",
                AnimalId = 9 
            });

            //modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            //{
            //    Id = ,
            //    Description = "",
            //    AnimalId = 
            //});

            #endregion
        }
    }
}

//modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
//            {
//                Description = "",
//                AnimalId = 
//            });