using CracowZoo.Enums;
using CracowZoo.Models;
using Microsoft.EntityFrameworkCore;

namespace CracowZoo.Data.Seed
{
    public static class AnimalsSeed
    {
        public static void SeedAnimals(this ModelBuilder modelBuilder)
        {
            #region RYBY 1-7
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

            #region PłAZY 8-15

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

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 10,
                Name = "Drzewołaz malarski",
                Group = AnimalGroup.Amphibians,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Dendrobates tinctorius",
                Occurance = "Ameryka Południowa - od Gujany po Brazylię.",
                LivingEnvritonment = "Dno wilgotnego lasu równikowego.",
                Food = "Owady.",
                Breeding = "Okres godowy przypada na porę deszczową. Samica składa 5–10 jaj, z których po 14–18 dniach wykluwają się kijanki. Samiec zwilża złożone jaja i przenosi kijanki do zbiornika z wodą.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 10,
                ImagePath = "_drzewolazmalarski.jpg"
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 11,
                Name = "Drzewołaz skoczny",
                Group = AnimalGroup.Amphibians,
                ConservationStatus = ConservationStatus.Endangered,
                LatinSpecie = "Phyllobates vittatus",
                Occurance = "Ameryka Środkowa - od Kostaryki do zachodniej Panamy.",
                LivingEnvritonment = "Tropikalne lasy deszczowe. Bytuje głównie między kamieniami, korzeniami drzew i pod liśćmi.",
                Food = "Owadożerny.",
                Breeding = " Samiec w porze godowej wabi partnerkę wydając trelujący głos. Samica składa do 25 jaj. Samiec zapładnia je, strzeże i zwilża wodą. Po 9-17 dniach z jaj wylęgają się kijanki. Samiec przenosi je do zbiornika z wodą.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 11,
                ImagePath = "_drzewolazskoczny.jpg"
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 12,
                Name = "Kumak dalekowschodni",
                Group = AnimalGroup.Amphibians,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Bombina orientalis",
                Occurance = "Wschodnia Syberia, północno - wschodnie Chiny, północna Korea oraz japońskie wyspy Tushima i Kiusiu.",
                LivingEnvritonment = "Pola ryżowe, rowy melioracyjne, stawy, mniejsze zbiorniki wody stojącej, małe cieki wodne, wypełnione wodą koleiny.",
                Food = "Owady, inne stawonogi, dżdżownice, małe ślimaki.",
                Breeding = "Samica składa do 100 jaj. Samiec natychmiast je zapładnia. Samica przykleja jaja do powierzchni kamieni i roślin wodnych. Po 3-6 dniach wylęgają się z nich kijanki, które przeobrażają się po 4-6 tygodniach (zależnie od temperatury wody).",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 12,
                ImagePath = "_kumakdalekowschodni.jpg"
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 13,
                Name = "Rzekotka czerwonooka",
                Group = AnimalGroup.Amphibians,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Agalychnis callidryas",
                Occurance = "Ameryka Środkowa - od Meksyku do Panamy.",
                LivingEnvritonment = "Wilgotny las równikowy.",
                Food = "Owadożerna.",
                Breeding = "Okres godowy przypada na porę deszczową. Samica składa pakiety jaj liczące nawet do 70 sztuk. Są one przytwierdzone do roślin znajdujących się tuż nad zbiornikiem wodnym. Kijanki wykluwają się po około tygodniu i wpadają do wody, gdzie trwa ich dalszy rozwój.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 13,
                ImagePath = "_rzekotkaczerwonooka.jpg"
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 14,
                Name = "Rzekotka szmaragdowa",
                Group = AnimalGroup.Amphibians,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Pelodryas caerulea",
                Occurance = "Australia.",
                LivingEnvritonment = "Wilgotne lasy tropikalne, środowiska zurbanizowane.",
                Food = "Owady, dżdżownice, małe płazy i gady, mysie noworodki.",
                Breeding = "Gatunek ten rozmnaża się w porze deszczowej. Samica składa jaja w kłębach liczących do około 200 sztuk. Rozwój zarodkowy przebiega szybko, kijanki wylęgają się w ciągu 48 godzin. Przeobrażają się w młode rzekotki już po 4-8 tygodniach.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 14,
                ImagePath = "_rzekotkaszmaragdowa.jpg"
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 15,
                Name = "Żaba pomidorowa",
                Group = AnimalGroup.Amphibians,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Dyscophus guineti",
                Occurance = "Wschodnie wybrzeże Madagaskaru.",
                LivingEnvritonment = "Podmokłe lasy, pola uprawne, plantacje, ogrody.",
                Food = "Owady, dżdżownice, małe gryzonie.",
                Breeding = "Samica składa do 1500 jaj. Kijanki wylęgają się z nich po około 36 godzinach. Po 45 dniach opuszczają wodę, przekształcone w małe żabki.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 15,
                ImagePath = "_zabapomidorowa.jpg"
            });
            #endregion

            #region GADY 16-30

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
            #endregion

            #region PTAKI 31-91

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

            #endregion

            #region SSAKI 92-170
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 92,
                Name = "Kuskus ziemny",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Phalanger gymnotis",
                Occurance = "Nowa Gwinea i wyspa Aru.",
                LivingEnvritonment = "Lasy równikowe.",
                Food = "Zwierzę wszystkożerne. Chętnie zjada liście, pąki i pędy roślin, a także pokarm zwierzęcy – ptasie jaja, pisklęta i owady.",
                Breeding = "Ciąża trwa 2 tygodnie. Po tym czasie rodzi się młode, którego dalszy rozwój przebiega w matczynej torbie.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 92,
                ImagePath = "_kuskusziemny.jpg"
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 93,
                Name = "Lotopałanka mała",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Petaurus breviceps",
                Occurance = "Australia, Nowa Gwinea.",
                LivingEnvritonment = "Lasy deszczowe, plantacje orzechów kokosowych, zarośla.",
                Food = "Małe bezkręgowce oraz soki roślinne i owoce.",
                Breeding = "Ciąża trwa 21 dni. Samica rodzi 2 - 3 młode.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 93,
                ImagePath = "_lotopalankamala.jpg"
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 94,
                Name = "Walabia Benetta",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Macropus rufogriseus",
                Occurance = "Wschodnia i południowo-wschodnia Australia oraz Tasmania.",
                LivingEnvritonment = "Zamieszkuje otwarte tereny przybrzeżne.",
                Food = "Typowy roślinożerca. Żywi się głównie liśćmi i trawą.",
                Breeding = "Po krótkim, około 35 – dniowym okresie ciąży samica rodzi młode wielkości ziarna fasoli, nagie i ślepe. Wędruje ono wzdłuż wylizanej przez matkę trasy od jej dróg rodnych do wnętrza torby. Tam obejmuje pyszczkiem sutek matki i rozwija się dalej przez około 7 miesięcy.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 94,
                ImagePath = "_walabiabenetta.jpg"
            });

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

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 96,
                Name = "Pancernik włochaty",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Chaetophractus villosus",
                Occurance = "Argentyna, Boliwia, Chile i Urugwaj.",
                LivingEnvritonment = "Zamieszkuje łąki, lasy, sawanny, tereny rolnicze, pampy - typowe dla Ameryki Południowej środowisko o charakterze stepowym.",
                Food = "Głównie bezkręgowce, a także małe kręgowce, owoce, padlina.",
                Breeding = "Po ciąży trwającej 2 miesiące rodzą się najczęściej 2 młode.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 96,
                ImagePath = "_pancernikwlochaty.jpg"
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 97,
                Name = "Leniwiec dwupalczasty",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Choloepus didactylus",
                Occurance = "Wenezuela, Gujana i północna Brazylia.",
                LivingEnvritonment = "Wilgotne lasy nizinne.",
                Food = "Liście, pędy roślin i owoce.",
                Breeding = "Ciąża trwa około 10 miesięcy. W miocie tylko jedno młode, które przyczepia się do włosów na piersi i brzuchu matki.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 97,
                ImagePath = "_leniwiecdwupalczasty.jpg"
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 98,
                Name = "Lemur czerwonobrzuchy",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Vulnerable,
                LatinSpecie = "Eulemur rubriventer",
                Occurance = "Madagaskar.",
                LivingEnvritonment = "Lasy deszczowe.",
                Food = "Owoce, pędy, bezkręgowce, drobne kręgowce.",
                Breeding = "Po ciąży trwającej 120 dni samica rodzi jedno młode, które jest noszone przez rodziców do około 35 dnia życia. Później opiekuje się nim głównie samiec. Matka karmi młode do piątego miesiąca życia.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 98,
                ImagePath = "_lemurczerwonobrzuchy.jpg"
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 99,
                Name = "Lemur katta",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Endangered,
                LatinSpecie = "Lemur catta",
                Occurance = "Południowo-zachodnia część Madagaskaru.",
                LivingEnvritonment = "Suche, otwarte tereny, rzadziej lasy.",
                Food = "Owoce, nasiona, liście, młode pędy roślin, kwiaty i drobne bezkręgowce.",
                Breeding = "Ciąża trwa 134-138 dni. Samica rodzi zazwyczaj 1, czasem 2 młode o masie 50-80 g, które po urodzeniu przyczepiają się do futra matki. Matka opiekuje się młodymi przez 6 miesięcy.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 99,
                ImagePath = "_lemurkatta.jpg"
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 100,
                Name = "Lemur wari",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.CriticallyEndangered,
                LatinSpecie = "Varecia rubra",
                Occurance = "Wschodni Madagaskar.",
                LivingEnvritonment = "Tropikalne lasy deszczowe.",
                Food = "Roślinożerny. Chętnie zjada owoce, a dietę uzupełnia nasionami, liśćmi i nektarem.",
                Breeding = "Po ciąży trwającej około 100 dni samica rodzi zwykle 2-3 młode, które początkowo przebywają w gnieździe zbudowanym na drzewie.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 100,
                ImagePath = "_warirudy.jpg"
            });

            #endregion
        }
    }
}
//modelBuilder.Entity<Animal>().HasData(new Animal
//            {
//                Id = ,
//                Name = "",
//                Group = AnimalGroup.Amphibians,
//                ConservationStatus = ConservationStatus.LeastConcern,
//                LatinSpecie = "",
//                Occurance = "",
//                LivingEnvritonment = "",
//                Food = "",
//                Breeding = "",
//                AnimalDanger = AnimalDanger.None,
//                MapItemId = ,
//                ImagePath = ".jpg"
//            });