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

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 201,
                Description = "Cechą odróżniającą ten gatunek od żółwia greckiego jest podzielona na pół tarczka nadogonowa.",
                AnimalId = 17
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 202,
                Description = "Żółwie bardzo często kopią nory, co pomaga ścierać nieustannie rosnące pazury.",
                AnimalId = 17
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 203,
                Description = "Gady te są przedstawicielami rodziny żółwi wężoszyjnych. Ich charakterystyczną cechą jest nieproporcjonalnie długa szyja, którą zwierzęta potrafią zginać w bok.",
                AnimalId = 18
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 204,
                Description = "Jeden z najmniejszych krokodyli. Jest najbardziej opancerzonym przedstawicielem rzędu. Dorasta do około 140 cm długości.",
                AnimalId = 19
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 205,
                Description = "Cechą charakterystyczną gatunku jest charakterystyczny „żagiel” u nasady ogona, dobrze widoczny zwłaszcza u samca.",
                AnimalId = 20
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 206,
                Description = "Doskonale pływa, nurkuje oraz sprawnie wspina się na konary drzew.",
                AnimalId = 20
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 207,
                Description = "Od roku 2007 w naszym Zoo agamy filipińskie regularnie składają jaja, czego rezultatem są liczne przychówki.",
                AnimalId = 20
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 208,
                Description = "Jest aktywny głównie w nocy.",
                AnimalId = 21
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 209,
                Description = "Nazywana jest dniówką ze względu na dzienny tryb życia.",
                AnimalId = 22
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 210,
                Description = "Bardzo szybko przemieszcza się po pionowych powierzchniach.",
                AnimalId = 22
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 211,
                Description = "Heloderma jest jadowitą jaszczurką. W przeciwieństwie do jadowitych węży podczas ukąszenia toksyna nie jest uwalniana od razu. Wydziela się dopiero w chwili mocnego nacisku mięśni szczęk.",
                AnimalId = 23
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 212,
                Description = "Nazywana jest jaszczurką Jezusa ze względu na umiejętność biegania po wodzie.",
                AnimalId = 24
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 213,
                Description = "Posiada duży, mięsisty język w kolorze niebieskim.",
                AnimalId = 25
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 214,
                Description = "Doskonale pływa i nurkuje. Bardzo sprawnie wspina się na drzewa.",
                AnimalId = 26
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 215,
                Description = "Jego bronią poza ostrymi pazurami oraz zębami jest mocno umięśniony ogon, którym potrafi zadawać potężne ciosy.",
                AnimalId = 26
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 216,
                Description = "Jest drugim co do wielkości waranem. Pod tym względem ustępuje tylko waranowi z Komodo. Osiąga do 3 m długości.",
                AnimalId = 26
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 217,
                Description = "Samca można odróżnić od samicy dzięki obecności parzystych pazurków odbytowych występujących po obu stronach kloaki.",
                AnimalId = 27
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 218,
                Description = "Aktywny o zmierzchu i nocą.",
                AnimalId = 28
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 219,
                Description = "Jest aktywny nocą – w ciągu dnia odpoczywa w ukryciu.",
                AnimalId = 29
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 220,
                Description = "Potrafi godzinami leżeć w wodzie bez ruchu wystawiając jedynie nozdrza i oczy ponad powierzchnię.",
                AnimalId = 30
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 221,
                Description = "Może przebywać pod wodą ponad 10 minut.",
                AnimalId = 30
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 222,
                Description = "Bywa bardzo agresywny.",
                AnimalId = 30
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