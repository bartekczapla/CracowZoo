using CracowZoo.Enums;
using CracowZoo.Models;
using Microsoft.EntityFrameworkCore;

namespace CracowZoo.Data.Seed
{
    public static class AnimalsSeed
    {
        public static void SeedAnimals(this ModelBuilder modelBuilder)
        {
            #region RYBY
            // RYBY ID: 1-7
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 1,
                Name = "Pirania czerwona",
                Group = AnimalGroup.Fish,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Pygocentrus nattereri",
                Occurance = "Ameryka Południowa",
                LivingEnvritonment = "Dorzecze Amazonki, Orinoko, La Platy",
                Food = "Ryby, mięczaki, ptaki i ssaki. Żyje i żeruje w dużych stadach(ławicach) wykazując niezwykłą żarłoczność. W poszukiwaniu ofiary kieruje się przede wszystkim węchem",
                Breeding = "Samica składa ikrę w zagłębieniu podłoża. Jest ona pilnowana przez rodziców",
                AnimalDanger = AnimalDanger.High,
                MapItemId = 1,
                ImagePath = "_piraniaczerwona.jpg"
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 2,
                Name = "Antias pomarańczowy",
                Group = AnimalGroup.Fish,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Anthias squamipinnis",
                Occurance = "Indopacyfik",
                LivingEnvritonment = "Rafy koralowe",
                Food = "Zooplankton",
                Breeding = "Ryby te rozpoczynają życie jako samice. Dorastając niektóre z nich zmieniają płeć. Samiec tworzy harem. Jeśli zginie – samica może zmienić płeć aby go zastąpić.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 2,
                ImagePath = "_antiaspomaranczowy.jpg"
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 3,
                Name = "Pyszczak żołty",
                Group = AnimalGroup.Fish,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Labidochromis caeruleus",
                Occurance = "Jezioro Malawi w południowo - wschodniej Afryce",
                LivingEnvritonment = "Strefa przybrzeżna i głębsze strefy litoralu skalistego",
                Food = "Małe ryby i skorupiaki",
                Breeding = "Ryba jajorodna",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 3,
                ImagePath = "_pyszczak.jpg"
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 4,
                Name = "Szczelinowiec z Burundi",
                Group = AnimalGroup.Fish,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Neolamprologus brichardi",
                Occurance = "Afryka - wody jeziora Tanganika",
                LivingEnvritonment = "Skalista strefa przybrzeżna, na głębokości 5-10 metrów",
                Food = "Zooplankton",
                Breeding = "Tarło odbywa w szczelinach skalnych. Samica składa do 200 sztuk ikry. W okresie rozrodu ryba ta bywa agresywna.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 4,
                ImagePath = "_szczelinowieczburundi.jpg"
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 5,
                Name = "Pokolec królewski",
                Group = AnimalGroup.Fish,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Paracanthurus hepatus",
                Occurance = "Indopacyfik",
                LivingEnvritonment = "Przybrzeżne rafy koralowe",
                Food = "Wszystkożerna. Żywi się zooplanktonem i glonami.",
                Breeding = "Gatunek jajorodny. W czasie tarła samce bywają bardzo agresywne wobec samic.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 5,
                ImagePath = "_pokoleckrolewski.jpg"
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 6,
                Name = "Amfiprion okoniowy",
                Group = AnimalGroup.Fish,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Amphiprion ocellaris",
                Occurance = "Indopacyfik",
                LivingEnvritonment = "Spotykany w płytkich wodach, w pobliżu rafy koralowej.",
                Food = "Glony, drobny zooplankton.",
                Breeding = "Samica składa do 25 000 ziaren ikry, którą opiekuje się samiec.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 6,
                ImagePath = "_amfiprionokoniowy.jpg"
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 7,
                Name = "Stadnik żółtoogonowy",
                Group = AnimalGroup.Fish,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Chrysiptera parasema",
                Occurance = "Indopacyfik",
                LivingEnvritonment = "Rafy koralowe, bytuje na głębokości do około 16 metrów.",
                Food = "Wszystkożerna.",
                Breeding = "Ryba jajorodna.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 7,
                ImagePath = "_stadnikzoltoogonowy.jpg"
            });
            #endregion


            #region PłAZY
            // PŁAZY ID: 8-15

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 8,
                Name = "Drzewołaz złoty",
                Group = AnimalGroup.Amphibians,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Dendrobates auratus",
                Occurance = "Ameryka Środkowa i Południowa: od południowej Nikaragui przez Kostarykę i Panamę do północnej Kolumbii.",
                LivingEnvritonment = "Wilgotne lasy równikowe, plantacje.",
                Food = "Owadożerny.",
                Breeding = "Samce w okresie godowym wydają charakterystyczne dźwięki, którymi wabią samice. Samica składa 4–12 jaj, z których po 10–15 dniach wykluwają się kijanki.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 8,
                ImagePath = "_drzewolazzloty.jpg"
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 9,
                Name = "Drzewołaz żółtopasy",
                Group = AnimalGroup.Amphibians,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Dendrobates leucomelas",
                Occurance = "Ameryka Południowa - Wenezuela na południe od Orinoko oraz przyległe obszary Gujany i Brazylii.",
                LivingEnvritonment = "Dno wilgotnego lasu równikowego. Preferuje bardzo wilgotne środowisko. Spotykany między kamieniami korzeniami i liśćmi.",
                Food = "Małe owady.",
                Breeding = "Gody przypadają w porze deszczowej.Samce wabią samice wydając krótkie, trelujące głosy godowe. Samica składa do 13 jaj w małych zagłębieniach w ziemi z wodą lub w pochwach liści. Po 12 - 15 dniach wylęgają się kijanki.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 9,
                ImagePath = "_drzewolazzoltopasy.jpg"
            });
            #endregion

            // GADY ID: 16-30

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 16,
                Name = "Żółw żabuti",
                Group = AnimalGroup.Reptiles,
                ConservationStatus = ConservationStatus.Unknown, //?
                LatinSpecie = "Chelonoidis carbonaria",
                Occurance = "Ameryka Południowa od północnej Brazylii po północną Argentynę i Boliwię.",
                LivingEnvritonment = "Tropikalne lasy deszczowe, płytkie sadzawki.",
                Food = "Wszystkożerny. Żywi się głównie zielonymi częściami roślin i owocami. Dietę uzupełnia rybami i innymi drobnymi kręgowcami.",
                Breeding = "Samica składa od 5 do 15 jaj, z których młode wylęgają się po upływie około 5 miesięcy.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 16,
                ImagePath = "_zolwzabuti.jpg"
            });

            // PTAKI ID: 31-91

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 31,
                Name = "Struś afrykański",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern, 
                LatinSpecie = "Struthio camelus",
                Occurance = "Afryka na terenie południowej Sahary, Sudan, Etiopia, Somalia po Kenię, południowa Kenia po Tanzanię i Afryka Południowa.",
                LivingEnvritonment = "Pustynie, półpustynie, sawanny",
                Food = "Roślinożerne. Dietę uzupełniają owadami i niewielkimi kręgowcami.",
                Breeding = "Samcowi towarzyszy harem samic. Gniazdo ma postać płytkiego dołu o średnicy 3 m, wygrzebanego w piasku lub ziemi.W gnieździe znajdują się jaja wszystkich 2 - 5 samic haremu.Wysiadywane są 42 - 46 dni przez dominującą samicę,którą zmienia samiec.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 31,
                ImagePath = "_strusafrykanski.jpg"
            });

            // SSAKI ID: 92-170

            // ... jeszcze 3

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 95,
                Name = "Słoń indyjski",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Endangered,
                LatinSpecie = "Elephas maximus",
                Occurance = "Indie, Chiny, Cejlon, Sumatra, Borneo.",
                LivingEnvritonment = "Słoń indyjski zamieszkuje zróżnicowane środowiska – od gęstej dżungli po otwarte tereny trawiaste.",
                Food = "Trawa, liście, miękkie pędy roślin, owoce.",
                Breeding = "Ciąża trwa około 21 miesięcy. Rodzi się jedno młode ważące do 100 kg.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 95,
                ImagePath = "_slonindyjski.jpg"
            });
        }
    }
}
