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
                //MapItemId = ,
                ImagePath = "_piraniaczerwona.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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
                //MapItemId = ,
                ImagePath = "_antiaspomaranczowy.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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
               // MapItemId = ,
                ImagePath = "_pyszczak.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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
                //MapItemId = ,
                ImagePath = "_szczelinowieczburundi.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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
                //MapItemId = ,
                ImagePath = "_pokoleckrolewski.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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
               // MapItemId = ,
                ImagePath = "_amfiprionokoniowy.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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
                //MapItemId = ,
                ImagePath = "_stadnikzoltoogonowy.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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
                //MapItemId = ,
                ImagePath = "_drzewolazzloty.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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
               // MapItemId = ,
                ImagePath = "_drzewolazzoltopasy.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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
               // MapItemId = ,
                ImagePath = "_drzewolazmalarski.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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
               // MapItemId = ,
                ImagePath = "_drzewolazskoczny.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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
               // MapItemId = ,
                ImagePath = "_kumakdalekowschodni.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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
               // MapItemId = ,
                ImagePath = "_rzekotkaczerwonooka.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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
                //MapItemId = ,
                ImagePath = "_rzekotkaszmaragdowa.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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
               // MapItemId = ,
                ImagePath = "_zabapomidorowa.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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
               // MapItemId = ,
                ImagePath = "_zolwzabuti.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });


            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 17,
                Name = "Żółw stepowy",
                Group = AnimalGroup.Reptiles,
                ConservationStatus = ConservationStatus.Unknown,
                LatinSpecie = "Testudo horsfieldii",
                Occurance = "Południowo-wschodnia Rosja, Kazachstan, Uzbekistan, Azerbejdżan, Kirgistan, Pakistan, Turkmenistan, Iran, Mongolia, Chiny.",
                LivingEnvritonment = "Suche, trawiaste obszary o skalnym podłożu.",
                Food = "Świeże pędy roślin stepowych, zioła, trawy, kwiaty i owoce.",
                Breeding = "Samica składa jaja po okresie 6-8 tygodni od zakończenia okresu hibernacji (spoczynku zimowego). Inkubacja trwa od 60 do nawet 85 dni (zależnie od temperatury).",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_zolwstepowy.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 18,
                Name = "Żółw papuaski",
                Group = AnimalGroup.Reptiles,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Elseya novaeguineae",
                Occurance = "Australia, Nowa Gwinea.",
                LivingEnvritonment = "Ciepłe laguny.",
                Food = "Roślinność wodna, owady, skorupiaki, ryby.",
                Breeding = "",
                AnimalDanger = AnimalDanger.None,
                //MapItemId = ,
                ImagePath = "_zolwpapuaski.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 19,
                Name = "Kajman karzełkowaty",
                Group = AnimalGroup.Reptiles,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Paleosuchus palpebrosus",
                Occurance = "Ameryka Południowa.",
                LivingEnvritonment = "Śródleśne strumienie oraz rzeki o kamienistym dnie.",
                Food = "Ryby, ptaki, drobne ssaki, płazy.",
                Breeding = "Samica kopie bardzo obszerne gniazdo, do którego składa kilkanaście jaj. Temperatura panująca w gnieździe wynosi około 30 C i wpływa na determinację płci. Po około 90 dniach z jaj wylęgają się młode osobniki. Matka wraca do miejsca złożenia jaj, nawoływana przez młode kajmany charakterystycznymi odgłosami i pomaga im wydostać się z gniazda.",
                AnimalDanger = AnimalDanger.None,
                //MapItemId = ,
                ImagePath = "_kajman.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 20,
                Name = "Agama żaglowa filipińska",
                Group = AnimalGroup.Reptiles,
                ConservationStatus = ConservationStatus.Vulnerable,
                LatinSpecie = "Hydrosaurus pustulatus",
                Occurance = "Północna część Filipin. Gatunek endemiczny.",
                LivingEnvritonment = "Brzegi rzek oraz płytkich zbiorników wodnych, lasy.",
                Food = "Małe ptaki, jaja, ryby, duże owady, owoce oraz zielone części roślin.",
                Breeding = "Samica składa jaja, z których po około 110 dniach wykluwają się młode osobniki.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_agamazaglowafilipinska.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 21,
                Name = "Gekon lamparci",
                Group = AnimalGroup.Reptiles,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Eublepharis macularius",
                Occurance = "Azja środkowo-wschodnia, Iran, Pakistan.",
                LivingEnvritonment = "Tereny pustynne i półpustynne.",
                Food = "Owady, oseski gryzoni.",
                Breeding = "Samica składa 2 jaja, z których po około 80 dniach wykluwają się młode osobniki. Płeć młodych zależy od temperatury inkubacji.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_gekonlamparci.jpg",
                Length = "",
                Weight = "",
                Longevity = "12 lat"
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 22,
                Name = "Gekon madagaskarski",
                Group = AnimalGroup.Reptiles,
                ConservationStatus = ConservationStatus.Unknown,
                LatinSpecie = "Phelsuma madagascariensis grandis",
                Occurance = "Madagaskar",
                LivingEnvritonment = "Lasy w północnej i wschodniej części wyspy.",
                Food = "Owady, dojrzałe owoce, nektar.",
                Breeding = "Samica kilka razy w roku składa 2 jaja.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_gekonmadagaskarski.jpg",
                Length = "30 cm",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 23,
                Name = "Heloderma meksykańska",
                Group = AnimalGroup.Reptiles,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Heloderma horridum exasperatum",
                Occurance = "Ameryka Północna - głównie Meksyk i Gwatemala.",
                LivingEnvritonment = "Półsuche, trawiasto-kamieniste tereny wzdłuż wybrzeża Pacyfiku.",
                Food = "Jaja ptaków, gryzonie, duże owady.",
                Breeding = "Samica składa kilkanaście jaj. Po około półrocznej inkubacji wylęgają się młode osobniki.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_helodermameksykanska.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 24,
                Name = "Bazyliszek płatkogłowy",
                Group = AnimalGroup.Reptiles,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Basiliscus plumifrons",
                Occurance = "Kostaryka.",
                LivingEnvritonment = "Lasy w pobliżu rzek.",
                Food = "Owady i inne bezkręgowce, drobne kręgowce, owoce.",
                Breeding = "Samica składa kilkanaście jaj. Inkubacja trwa około 2 miesiące.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_bazyliszekplatkoglowy.jpg",
                Length = "75 cm",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 25,
                Name = "Scynk wielki",
                Group = AnimalGroup.Reptiles,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Tiliqua gigas",
                Occurance = "Nowa Gwinea i okoliczne wyspy.",
                LivingEnvritonment = "Preferuje suche, ciepłe, urozmaicone środowiska.",
                Food = "Wszystkożerna. Żywi się ślimakami, stawonogami, mniejszymi jaszczurkami, padliną.",
                Breeding = "Żyworodna. Samica rodzi do 10 młodych.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_scynkwielki.jpg",
                Length = "50 cm",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 26,
                Name = "Waran leśny",
                Group = AnimalGroup.Reptiles,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Varanus salvator",
                Occurance = "Azja południowo-wschodnia. Od Cejlonu po Filipiny oraz Chiny.",
                LivingEnvritonment = "Podmokłe lasy, sąsiedztwo dużych zbiorników wodnych.",
                Food = "Kręgowce: głównie ryby i ptaki, ptasie jaja i pisklęta.",
                Breeding = "Gatunek jajorodny. Samica składa kilkadziesiąt (do 30) jaj w wykopanych przez siebie głębokich norach.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_waranlesny.jpg",
                Length = "do 3 m",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 27,
                Name = "Boa dusiciel",
                Group = AnimalGroup.Reptiles,
                ConservationStatus = ConservationStatus.Unknown,
                LatinSpecie = "Boa constrictor",
                Occurance = "Ameryka Środkowa i Południowa.",
                LivingEnvritonment = "Lasy tropikalne.",
                Food = "Małe i średniej wielkości ssaki, ptaki, gady, płazy oraz ryby.",
                Breeding = "Żyworodny. Po ciąży trwającej 110-200 dni samica rodzi nawet do 50 młodych.",
                AnimalDanger = AnimalDanger.High,
               // MapItemId = ,
                ImagePath = "_boadusiciel.jpg",
                Length = "do 3,5 m",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 28,
                Name = "Boa psiogłowy",
                Group = AnimalGroup.Reptiles,
                ConservationStatus = ConservationStatus.Unknown,
                LatinSpecie = "Corallus caninus",
                Occurance = "Ameryka Południowa - Brazylia, Gujana, Peru.",
                LivingEnvritonment = "Lasy deszczowe. Najchętniej przebywa w koronach drzew większość czasu spędzając w charakterystycznej pozycji zwinięty na poziomej gałęzi.",
                Food = "Głównie małe ssaki i ptaki.",
                Breeding = "Gatunek żyworodny. Młode węże od chwili urodzenia aż do pierwszego roku życia mają jaskrawy pomarańczowy lub czerwony kolor. Po upływie roku przyjmują zielone ubarwienie.",
                AnimalDanger = AnimalDanger.None,
                //MapItemId = ,
                ImagePath = "_boapsioglowy.jpg",
                Length = "2 m",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 29,
                Name = "Lancetogłów mleczny",
                Group = AnimalGroup.Reptiles,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Lampropeltis triangulum sinaloae",
                Occurance = "Zachodnia część Meksyku.",
                LivingEnvritonment = "Lasy, obszary trawiaste, półpustynie.",
                Food = "Gryzonie, płazy, małe ptaki, inne węże, jaszczurki, bezkręgowce.",
                Breeding = "Samica składa 5-16 jaj. Inkubacja trwa 35-66 dni.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_lancetoglowmleczny.jpg",
                Length = "do 120 cm",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 30,
                Name = "Anakonda żółta",
                Group = AnimalGroup.Reptiles,
                ConservationStatus = ConservationStatus.Unknown,
                LatinSpecie = "Eunectes notaeus",
                Occurance = "Ameryka Południowa: Paragwaj, Argentyna, Brazylia.",
                LivingEnvritonment = "Różnego rodzaju zbiorniki wodne, strumienie, podmokłe siedliska w lasach tropikalnych, mokradła, tereny bagienne.",
                Food = "Ssaki, ptaki, ryby.",
                Breeding = "Wąż żyworodny. Samica po 6 miesięcznej ciąży rodzi do 40 młodych.",
                AnimalDanger = AnimalDanger.High,
               // MapItemId = ,
                ImagePath = "_anakondazolta.jpg",
                Length = "3-3,5 m",
                Weight = "30-40 kg",
                Longevity = "15-20 lat"
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
                Breeding = "Samcowi towarzyszy harem samic. Gniazdo ma postać płytkiego dołu o średnicy 3 m, wygrzebanego w piasku lub ziemi.W gnieździe znajdują się jaja wszystkich 2 - 5 samic haremu. Wysiadywane są 42 - 46 dni przez dominującą samicę,którą zmienia samiec.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 31,
                ImagePath = "_strusafrykanski.jpg",
                Length = "210-275 cm",
                Weight = "100-156 kg",
                Longevity = "do 75 lat"
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 32,
                Name = "Nandu szare",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.NearThreatened,
                LatinSpecie = "Rhea americana",
                Occurance = "Wschodnia część Ameryki Południowej. Brazylia, Paragwaj, Urugwaj, Argentyna.",
                LivingEnvritonment = "Stepy i sawanny.",
                Food = "Liście, nasiona, korzenie i owoce. Dieta jest uzupełniana owadami, a także jaszczurkami, żabami, małymi ptakami i wężami.",
                Breeding = "Jeden samiec łączy się z 6-15 samicami. Broni swego haremu i terytorium przed innymi dorosłymi samcami. Samice składają do wspólnego gniazda 15-30 jaj. Wysiaduje je tylko samiec przez 35-40 dni. Samiec również opiekuje się pisklętami, które zaraz po wykluciu są samodzielne.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 308,
                ImagePath = "_nanduszare.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 33,
                Name = "Emu",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Dromaius novaehollandiae",
                Occurance = "Australia",
                LivingEnvritonment = "Krzaczaste stepy, otwarte równiny, mało zwarte lasy w suchych okolicach.",
                Food = "Głównie nasiona, owady i owoce.",
                Breeding = "Gniazdo umieszczone jest na ziemi. W zniesieniu 5-15 jaj, wysiadywanych przez samca 56 dni. Samiec również sprawuje opiekę nad pisklętami.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 313,
                ImagePath = "_emu.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 34,
                Name = "Perliczka",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Afryka na południe od Sahary.",
                Occurance = "Afryka na południe od Sahary.",
                LivingEnvritonment = "Zamieszkuje zróżnicowane środowiska oprócz lasu równikowego i pustyń.",
                Food = "Nasiona, bulwy, jagody, bezkręgowce.",
                Breeding = "Gniazdo znajduje się na ziemi. Samica składa do 12 jaj i wysiaduje je przez 24 do 27 dni. Samiec pomaga wychowywać młode.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_perliczka.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 35,
                Name = "Perlica sępia",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Acryllium vulturinum",
                Occurance = "Wschodnia Afryka – Etiopia, Somalia, Kenia, Uganda, Tanzania.",
                LivingEnvritonment = "Zamieszkuje sawanny, półsuche tereny trawiaste z krzewami i nadrzeczne zarośla.",
                Food = "Nasiona, liście traw i ziół, owoce, pączki, bulwy, owady, pająki, ślimaki.",
                Breeding = "W sezonie lęgowym ptaki łączą się w pary. Gniazdo ma postać zagłębienia w ziemi, często znajduje się pod osłoną roślinności. W zniesieniu nawet do 15 jaj. Inkubacja trwa 23-25 dni, wysiaduje samica.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_perlicasepia.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 36,
                Name = "Uszak siwy",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Crossoptilon auritum",
                Occurance = "Chiny.",
                LivingEnvritonment = "Zamieszkuje lasy iglaste i mieszane, łąki powyżej granicy lasu (do wysokości 3 500 m n.p.m.).",
                Food = "Głównie pokarm roślinny-pączki i liście, owoce, nasiona. Dietę uzupełnia owadami.",
                Breeding = "Gatunek monogamiczny – kogut łączy się z jedną kurą. Gniazdo zakłada na ziemi, w zagłębieniu pod osłoną roślinności. W zniesieniu 6-12 jaj, wysiaduje tylko samica 24-28 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 300,
                ImagePath = "_uszaksiwy.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 37,
                Name = "Olśniak himalajski",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Lophophorus impejanus",
                Occurance = "Azja od wschodniego Afganistanu przez Himalaje, Kaszmir, północne Indie, Nepal, południowy Tybet i Butan.",
                LivingEnvritonment = "Zamieszkuje górskie lasy iglaste i mieszane na wysokości od 2100 do 4500 m.",
                Food = "Nasiona, bulwy, korzonki, owoce, bezkręgowce.",
                Breeding = "Gniazdo znajduje się na ziemi, w zagłębieniu, często pod osłoną roślinności. W zniesieniu 3-8 jaj, wysiaduje samica około 27 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 300,
                ImagePath = "_olsniakhimalajski.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 38,
                Name = "Bażant annamski",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.CriticallyEndangered,
                LatinSpecie = "Lophura edwardsi",
                Occurance = "Centralny Wietnam.",
                LivingEnvritonment = "Zamieszkuje górskie lasy, gęste zarośla w pobliżu strumieni.",
                Food = "Różne części roślin, owoce, nasiona i rożne drobne owady.",
                Breeding = "Samica składa 4-7 jaj i wysiaduje je w gnieździe znajdującym się na ziemi przez 21-22 dni, a następnie opiekuje się pisklętami. Młode osiągają dojrzałość płciową w wieku 2 lat.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_bazantannamski.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 39,
                Name = "Bernikla białolica",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Branta leucopsis",
                Occurance = "Grenlandia, Archipelag Svalbard, północna część Norwegii. Zimuje na wybrzeżach Morza Północnego i Zatoki Biskajskiej, a nawet na Półwyspie Iberyjskim.",
                LivingEnvritonment = "Skaliste wybrzeża północnych mórz, tundra w sąsiedztwie bagien i jezior. Zimuje na łąkach i pastwiskach położonych w pobliżu morza.",
                Food = "Przeważnie pokarm roślinny zbierany na lądzie. Na zimowisku dieta uzupełniana jest mięczakami i skorupiakami morskimi.",
                Breeding = "Gnieździ się kolonijnie na skałach w pobliżu morza. Wyprowadza 1 lęg w roku, w zniesieniu znajduje się 4-5 jaj. Wysiaduje samica przez 24-25 dni.",
                AnimalDanger = AnimalDanger.None,
              //  MapItemId = ,
                ImagePath = "_berniklabialolica.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 40,
                Name = "Bernikla rdzawoszyja",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.Endangered,
                LatinSpecie = "Branta ruficollis",
                Occurance = "Zachodnia Syberia. Zimuje na wybrzeżu Morza Kaspijskiego i Zatoki Perskiej.",
                LivingEnvritonment = "Tundra, lasotundra, step, mokradła i bagna, starorzecza, stawy hodowlane.",
                Food = "Przeważnie pokarm roślinny zbierany na lądzie: trawy, zboża, liście, zielone części roślin wodnych.",
                Breeding = "Gniazduje w luźnych koloniach, często w sąsiedztwie miejsc lęgowych ptaków drapieżnych i sów, które zwiększają bezpieczeństwo bernikli i ich lęgu. W zniesieniu zwykle 6-7 jaj. Samica wysiaduje przez około 25 dni.",
                AnimalDanger = AnimalDanger.None,
              //  MapItemId = ,
                ImagePath = "_berniklardzawoszyja.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 41,
                Name = "Gęś hawajska",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.Vulnerable,
                LatinSpecie = "Branta sandvicensis",
                Occurance = "Hawaje",
                LivingEnvritonment = "Stoki gór wulkanicznych do wysokości 2500 m n.p.m, łąki.",
                Food = "Głównie pokarm roślinny: trawy, zioła, jagody, zielone części roślin, liście.",
                Breeding = "Gniazdo znajduje się na ziemi, w zagłębieniach terenu, często pomiędzy blokami lawy. W zniesieniu 3-5 jaj, okres inkubacji trwa około 29 dni.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_geshawajska.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 42,
                Name = "Łabędź czarny",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Cygnus atratus",
                Occurance = "Australia, Tasmania, Nowa Zelandia",
                LivingEnvritonment = "Różnego rodzaju stojące i wolno płynące wody śródlądowe, zatoki morskie i laguny, zbiorniki wodne w parkach.",
                Food = "Różne części roślin wodnych, wodorosty. Żerują również na pastwiskach i okresowo zalewanych polach.",
                Breeding = "Gniazda zakładają na suchym lądzie lub wśród roślinności bagiennej. W zniesieniu zwykle 5-6 jaj, okres inkubacji wynosi 36-40 dni. Często gniazduje w koloniach.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 304,
                ImagePath = "_labedzczarny.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 43,
                Name = "Drzewica dwubarwna",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Dendrocygna bicolor",
                Occurance = "Indie, wschodnia Afryka, północne i wschodnie rejony Ameryki Południowej, Meksyk",
                LivingEnvritonment = "Okolice zbiorników wodnych, bagna oraz rozlewiska rzek",
                Food = "Różne części roślin, owoce, drobne bezkręgowce wodne.",
                Breeding = "Gniazduje w pojedynczych parach lub luźnych koloniach. W zniesieniu średnio 10 jaj, inkubacja trwa 24-28 dni.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_drzewicadwubarwna.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 44,
                Name = "Kazarka",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Tadorna ferruginea",
                Occurance = "Wschodnia część basenu Morza Śródziemnego, Morza Czarnego, w pasie Azji Środkowej po Amur oraz w północno-zachodniej Afryce po Wyżynę Abisyńską",
                LivingEnvritonment = "Jeziora w pobliżu stepów i półpustyń. W górach zamieszkuje tereny położone do wysokości 3000 m n.p.m.",
                Food = "Pokarm mieszany z przewagą roślinnego.",
                Breeding = "Gniazduje w szczelinach skalnych, rozpadlinach, opuszczonych norach ssaków. W zniesieniu 8-12 jaj. Wysiadywanie trwa 27-29 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 304,
                ImagePath = "_kazarka.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 45,
                Name = "Ohar",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Tadorna tadorna",
                Occurance = "Obszary położone w pobliżu wybrzeża Bałtyku, Morza Północnego i Atlantyku aż po Morze Śródziemne. W Polsce na Półwyspie Helskim",
                LivingEnvritonment = "Bagna i rozlewiska",
                Food = "Głównie pokarm zwierzęcy – skorupiaki, mięczaki, owady wodne. Dietę uzupełnia pokarmem roślinnym.",
                Breeding = "Ptaki łączą się w pary na całe życie. Gniazda zakładają w dziuplach lub opuszczonych norach innych zwierząt. W zniesieniu 8-10 jaj, inkubacja trwa około 30 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 305,
                ImagePath = "_ohar.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 46,
                Name = "Mandarynka",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Aix galericulata",
                Occurance = "Dorzecze rzeki Amur, Sachalin, Japonia, Mandżuria, południowo - wschodnie Chiny",
                LivingEnvritonment = "Rzeki z zalesionymi wysepkami, jeziora śródleśne, laski łęgowe, parki",
                Food = "Pokarm roślinny: nasiona, rośliny wodne. Dietę uzupełnia pokarmem zwierzęcym: zjada owady, małe gady i ryby.",
                Breeding = "Toki samca są bardzo urozmaicone i widowiskowe. Gniazdo zakłada w dziupli drzewa w pobliżu wody. Po wylęgu kaczęta wyskakują z dziupli bezpośrednio do wody.",
                AnimalDanger = AnimalDanger.None,
              //  MapItemId = ,
                ImagePath = "_mandarynka.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 47,
                Name = "Karolinka",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Aix sponsa",
                Occurance = "Ameryka Północna (licznie w stanie Karolina), Kuba",
                LivingEnvritonment = "Bagna, rozlewiska, jeziora, rzeki",
                Food = "Skorupiaki, owady, rośliny wodne.",
                Breeding = "W zniesieniu 8-12 jaj, wysiadywanych przez samicę w dziupli przez 28-30 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 303,
                ImagePath = "_karolinka.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 48,
                Name = "Dziwonos",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Sarkidiornis melanotos",
                Occurance = "Środkowa i południowa Afryka, Madagaskar, południowa Azja.",
                LivingEnvritonment = "Bagna, rzeki, jeziora i otwarte tereny podmokłe.",
                Food = "Trawa, nasiona zbóż, rośliny wodne, bezkręgowce.",
                Breeding = "Gniazduje w dziuplach drzew lub na ziemi. W zniesieniu 6-20 jaj. Inkubacja trwa 28-30 dni.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_dziwonos.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 49,
                Name = "Podgorzałka",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.NearThreatened,
                LatinSpecie = "Aythia nyroca",
                Occurance = "Południowo – wschodnia Europa, Azja środkowa, północna Afryka.",
                LivingEnvritonment = "Płytkie stawy i jeziora z pasem trzcinowisk, czasem bardzo małe zbiorniki wodne.",
                Food = "Rośliny wodne, owady i ich larwy, ślimaki, kijanki i młode żabki. W poszukiwaniu pożywienia nurkuje.",
                Breeding = "Do gniazda zbudowanego w gęstych szuwarach samica składa 7-11 jaj. Okres inkubacji wynosi około 25 dni. Lęgi poprzedzone są bardzo widowiskowymi tokami.",
                AnimalDanger = AnimalDanger.None,
              //  MapItemId = ,
                ImagePath = "_podgorzalka.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 50,
                Name = "Hełmiatka",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Netta rufina",
                Occurance = "Od Półwyspu Iberyjskiego po Azję Środkową. Zimuje w basenie Morza Śródziemnego.",
                LivingEnvritonment = "Jeziora zarośnięte szuwarami, otwarte zbiorniki wodne nieporośnięte roślinnością, zimą również zatoki morskie.",
                Food = "Głównie zielone części roślin wodnych, młode pędy, korzonki, nasiona, kłącza. Dietę uzupełnia pokarmem zwierzęcym – mięczakami, skorupiakami, owadami, małymi rybami, płazami. Żeruje na wodzie, czasem nurkuje na głębokość do 4 m.",
                Breeding = "Gniazduje pojedynczo lub w małych koloniach w pobliżu zbiorników wodnych. W zniesieniu znajduje się 7-10 jaj, wysiadywanych przez 28 dni. Matka wodzi kaczęta przez okres około 2 miesięcy.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_helmiatka.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 51,
                Name = "Pingwin Humboldta",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.Vulnerable,
                LatinSpecie = "Spheniscus humboldti",
                Occurance = "Wybrzeża Peru i Chile.",
                LivingEnvritonment = "Wybrzeże morskie w rejonie oddziaływania zimnego prądu morskiego, zwanego Prądem Humboldta.",
                Food = "Głównie ryby. Dietę uzupełnia głowonogami i skorupiakami.",
                Breeding = "W naturze rozmnaża się w ciągu całego roku. Gniazda zakłada na klifach, w jaskiniach, rozpadlinach skalnych, rzadziej na otwartej przestrzeni. W zniesieniu 2 jaja, wysiadywanie trwa 40-42 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 51,
                ImagePath = "_pingwinhumboldta.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 52,
                Name = "Flaming różowy",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Phoenicopterus ruber roseus",
                Occurance = "Południowa Europa, zachodnie wybrzeże Atlantyku, Afryka, Indie. Jest najszerzej rozprzestrzenionym gatunkiem flaminga.",
                LivingEnvritonment = "Słone laguny, brzegi jezior, rozlewiska rzek.",
                Food = "Drobne mięczaki, skorupiaki, owady i pokarm roślinny.",
                Breeding = "Do gniazda w kształcie kopca, zbudowanego z mułu samica składa zazwyczaj 1 jajo. Szaro upierzone młode wylęgają się po okresie inkubacji trwającym około 30 dni. Dojrzałość płciową uzyskują po 5-6 latach. Gatunek ten gniazduje w koloniach, liczących nawet do kilku tysięcy osobników.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 52,
                ImagePath = "_flaming.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 53,
                Name = "Bocian biały",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Ciconia ciconia",
                Occurance = "Gniazduje w Europie (na północy po Finlandię), w północno-zachodniej Afryce i Azji południowo-zachodniej (na wschodzie po południowy Kazachstan). Zimuje w Afryce od tropikalnej Afryki Subsaharyjskiej po Republikę Południowej Afryki i w Indiach.",
                LivingEnvritonment = "Tereny podmokłe z grupami drzew, krajobraz rolniczy w pobliżu siedzib ludzkich.",
                Food = "Gryzonie, ssaki owadożerne, płazy, duże owady, ryby, dżdżownice, jaja i pisklęta ptaków.",
                Breeding = "W zniesieniu 3-6 jaj, wysiadywanych przez 33-34 dni przez oboje rodziców. Pisklęta przebywają w gnieździe 2 miesiące, rodzice wspólnie się nimi opiekują. Gniazda budowane są na drzewach, wieżach, dachach domów, na słupach telegraficznych.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 304,
                ImagePath = "_bocianbialy.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 54,
                Name = "Bocian czarny",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Ciconia nigra",
                Occurance = "Azja, środkowa i wschodnia Europa oraz Półwysep Iberyjski. Zimuje w Afryce i Azji południowej.",
                LivingEnvritonment = "Rozległe, podmokłe lasy, obfitujące w zbiorniki wodne, śródleśne bagna i łąki, brzegi rzek w dolinach górskich.",
                Food = "Ryby, płazy, inne drobne kręgowce i owady.",
                Breeding = "W zniesieniu 3-5 jaj, okres inkubacji wynosi 30-40 dni.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_bocianczarny.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 55,
                Name = "Marabut afrykański",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Leptoptilos crumeniferus",
                Occurance = "Środkowa i wschodnia Afryka.",
                LivingEnvritonment = "Sawanna, mokradła, brzegi zbiorników wodnych, spotykany również w pobliżu osad rybackich, rzeźni i na wysypiskach śmieci.",
                Food = "Głównie padlina. Dietę uzupełnia rybami, gryzoniami, jaszczurkami, wężami, ptakami, owadami.",
                Breeding = "Gniazda zakłada wysoko na drzewach. Tworzy kolonie liczące 20-60 par. W zniesieniu 2-3 jaja, po około 30 dniach wykluwają się pisklęta.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 304,
                ImagePath = "_marabutafrykanski.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 56,
                Name = "Ibis purpurowy",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Eudocimus ruber",
                Occurance = "łnocna część Ameryki Południowej.",
                LivingEnvritonment = "Mokradła, pola ryżowe, zarośla mangrowe, płytkie jeziora.",
                Food = "Skorupiaki, owady, mięczaki, narybek.",
                Breeding = "Gniazduje w koloniach, często wspólnie z innymi gatunkami ibisów i czaplami. Gniazdo budowane jest na drzewie. W zniesieniu znajdują się zwykle 2 jaja, okres inkubacji wynosi 21-23 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 304,
                ImagePath = "_ibispurpurowy.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 57,
                Name = "Ibis australijski",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Threskiornis molucca",
                Occurance = "Australia, Nowa Gwinea, południowe Molukki, Wyspy Sundajskie.",
                LivingEnvritonment = "Przybrzeżne laguny strefy pływowej, płytkie śródlądowe rozlewiska, bagna.",
                Food = "Owady, skorupiaki, mięczaki, drobne kręgowce.",
                Breeding = "Gnieździ się w koloniach liczących nawet do 20 tysięcy par, często z innymi ptakami brodzącymi. W zniesieniu 1-4 jaja, okres inkubacji wynosi 20-23 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 304,
                ImagePath = "_ibisaustralijski.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 58,
                Name = "Warzęcha czerwonolica",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Platalea alba",
                Occurance = "Afryka od Senegalu, Etiopii do Afryki Południowej, Madagaskar.",
                LivingEnvritonment = "Rozlewiska rzek oraz bagna porośnięte wysokimi krzewami i drzewami.",
                Food = "Skorupiaki, mięczaki, małe ryby, płazy i gady. Żeruje stadnie na płyciznach, odcedzając pokarm z wody i mułu przy pomocy rozszerzonego na końcu dzioba.",
                Breeding = "Gniazduje w koloniach, czasem wspólnie z innymi ptakami brodzącymi i kormoranami. W zniesieniu zazwyczaj 2-3 jaja, inkubacja trwa 25-29 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 304,
                ImagePath = "_warzechaczerwonolica.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 59,
                Name = "Czapla nadobna",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Egretta garzetta",
                Occurance = "Południowa Europa, południowa Azja, wschodnia i zachodnia Afryka, wchodnia Australia.",
                LivingEnvritonment = "Tereny położone nad ujściami rzek, bagna i inne obszary podmokłe.",
                Food = "Ryby, żaby, owady wodne, szarańczaki, ważki, drobne zwierzęta lądowe. W wodzie wypłaszają zwierzęta wodne z ich kryjówek poruszając szybko długimi palcami nóg.",
                Breeding = "Gniazduje kolonijnie, często z innymi gatunkami ptaków brodzących, a także z kormoranami. Wyprowadza 1 lęg w roku. W zniesieniu znajduje się najczęściej 3-5 jaj, wysiadywanych 21-22 dni. Młode przebywają w gnieździe około 30 dni.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_czaplanadobna.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 60,
                Name = "Pelikan różowy",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "elecanus onocrotalus",
                Occurance = "Południowo-wschodnia Europa, Azja Mniejsza i środkowa, Indie, wyspowo w południowej i wschodniej Afryce.",
                LivingEnvritonment = "Brzegi śródlądowych zbiorników wodnych, delty rzek zarośniętych trzciną i krzewami, bagna z płytkimi jeziorkami, laguny, wolno płynące rzeki.",
                Food = "Ryby łowione najczęściej zespołowo.",
                Breeding = "Gnieździ się w koloniach. Wyprowadza 1 lęg w roku. W zniesieniu 1-3 jaj. Okres inkubacji trwa 29-36 dni. Pisklęta wykluwają się nagie, ich skóra ma ciemnoszare zabarwienie.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 304,
                ImagePath = "_pelikanrozowy.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 61,
                Name = "Kondor wielki",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.NearThreatened,
                LatinSpecie = "Vultur gryphus",
                Occurance = "Andy od Wenezueli do Ziemi Ognistej.",
                LivingEnvritonment = "Wysokie partie gór do wysokości 5000 m n.p.m.",
                Food = "Głównie padlina ssaków lądowych i morskich, ptasie jaja. Zdobyczy wypatruje szybując wysoko w powietrzu.",
                Breeding = "Gnieździ się we wnękach półek skalnych na wysokich urwiskach. W zniesieniu 1 jajo, wysiadywane przez oboje rodziców około 60 dni. Młode osiąga zdolność do lotu po około 6 miesiącach, a dojrzałość płciową dopiero po 6 latach.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 314,
                ImagePath = "_kondorwielki.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 62,
                Name = "Sęp kasztanowaty",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.NearThreatened,
                LatinSpecie = "Aegypius monachus",
                Occurance = "Południowa Palearktyka. Zamieszkuje Półwysep Iberyjski, Bałkany, pasma górskie Azji aż po Pacyfik. Zimuje w Sudanie, Pakistanie, Indiach, Korei, na Środkowym Wschodzie.",
                LivingEnvritonment = "Wyżej położone zadrzewione obszary, lasy górskie, łąki, stepy.",
                Food = "Głównie padlina, rzadziej poluje na żywe zwierzęta.",
                Breeding = "Gniazdo zakłada najczęściej wysoko na drzewach, rzadziej na skałach. W zniesieniu zwykle 1 jajo, okres inkubacji trwa 54-56 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 314,
                ImagePath = "_sepkasztanowaty.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 63,
                Name = "Orzeł przedni",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.NearThreatened,
                LatinSpecie = "Aquila chrysaetos chrysaetos",
                Occurance = "Europa i Azja aż do zachodniej Syberii.",
                LivingEnvritonment = "Lasy w sąsiedztwie rozległych łąk, doliny rzeczne ze starodrzewami, góry.",
                Food = "Ptaki i ssaki średniej wielkości: gryzonie, króliki, zające, świstaki, kuropatwy, w mniejszym stopniu gady i padlina.",
                Breeding = "Gnieździ się na półkach skalnych lub w koronach wysokich drzew. Samica składa od 1 do 3 jaj, które wysiaduje przez 41-45 dni. Młode przebywają w gnieździe około 3 miesiące.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 314,
                ImagePath = "_orzelprzedni.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 64,
                Name = "Orzeł cesarski",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.Vulnerable,
                LatinSpecie = "Aquila heliaca",
                Occurance = "Europa południowo-wschodnia, Półwysep Pirenejski, południowo-zachodnia i środkowa Azja.",
                LivingEnvritonment = "Stepy i inne otwarte tereny nizinne porośnięte niewielkimi lasami.",
                Food = "Susły, chomiki, króliki i ptaki średniej wielkości.",
                Breeding = "Łączy się w pary na całe życie. W zniesieniu zwykle 2-3 jaja, wysiadywane przez samicę przez 43 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 311,
                ImagePath = "_orzelcesarski.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 65,
                Name = "Żuraw koroniasty wschodni",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.Endangered,
                LatinSpecie = "Balearica regulorum gibbericeps",
                Occurance = "Wschodnia i południowa Afryka.",
                LivingEnvritonment = "Podmokłe tereny w pobliżu jezior i rzek.",
                Food = "Małe kręgowce, owady, pokarm roślinny.",
                Breeding = "Gniazdo buduje najczęściej na ziemi, bardzo rzadko na drzewie. Samica składa 1-4 jaja. Ich wysiadywaniem i opieką nad potomstwem zajmują się oboje rodzice. Inkubacja trwa 28-31 dni. Młode osiągają dojrzałość płciową w trzecim roku życia.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 305,
                ImagePath = "_zurawkoroniasty.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 66,
                Name = "Żuraw mandżurski",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.Endangered,
                LatinSpecie = "Grus japonensis",
                Occurance = "Japońska wyspa Hokkaido, północno-wschodnie Chiny, południowo-wschodnia Rosja. Zimuje w Korei i we wschodnich Chinach.",
                LivingEnvritonment = "Bagna, pola ryżowe, podmokłe łąki.",
                Food = "Ryby, gryzonie, płazy, owady, trawy i inne rośliny.",
                Breeding = "W okresie godowym żurawie wykonują bardzo efektowne tańce. Samica składa 2 jaja, inkubacja trwa 29-34 dni. Młode osiągają dojrzałość płciową w wieku 3-4 lat.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 66,
                ImagePath = "_zurawmandzurski.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 67,
                Name = "Gołąbek diamentowy",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Geopelia cuneata",
                Occurance = "Rozległe obszary Australii, z wyjątkiem wybrzeża na południu, wschodzie i zachodzie.",
                LivingEnvritonment = "Tereny porośnięte krzewami, chętnie w pobliżu rzek lub zbiorników wodnych, łąki.",
                Food = "Nasiona, młode pędy roślin, larwy owadów. Żeruje najczęściej na ziemi.",
                Breeding = "Niedbale wykonane gniazdo budują oboje rodzice, na zmianę wysiadują jaja i wspólnie opiekują się młodymi. W zniesieniu znajdują się 2 jaja, okres inkubacji wynosi 13 dni.",
                AnimalDanger = AnimalDanger.None,
              //  MapItemId = ,
                ImagePath = "_golabekdiamentowy.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 68,
                Name = "Koroniec plamoczuby",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.NearThreatened,
                LatinSpecie = "Goura victoria",
                Occurance = "Nowa Gwinea",
                LivingEnvritonment = "Tereny podmokłe, bagna, lasy.",
                Food = "Głównie jagody i nasiona.",
                Breeding = "W zniesieniu 1 jajo, okres inkubacji wynosi 30 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 300,
                ImagePath = "_koroniecplamoczuby.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 69,
                Name = "Lorysa górska",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Trichoglossus haematodus",
                Occurance = "Wschodnie, północne i południowe wybrzeża Australii, Tasmania, Nowa Gwinea, Nowa Kaledonia, okoliczne wyspy Pacyfiku.",
                LivingEnvritonment = "Obrzeża lasów, lasy różnego typu, zadrzewione tereny podmokłe, sawanna, plantacje palm kokosowych, tereny położone w pobliżu siedzib ludzkich.",
                Food = "Owoce, nasiona, nektar.",
                Breeding = "Gnieździ się w dziuplach drzew. Na małych atolach wolnych od drapieżników zakłada gniazda na ziemi. W zniesieniu 1-3 jaj, okres inkubacji wynosi około 25 dni.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_lorysagorska.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 70,
                Name = "Aleksandretta różana",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Psittacula alexandri",
                Occurance = "Północne Indie, Nepal, Birma, Tajlandia, południowe Chiny.",
                LivingEnvritonment = "Lasy do wysokości około 2000 m n.p.m, plantacje ryżu.",
                Food = "Nasiona, orzechy, owoce.",
                Breeding = "Gniazduje w dziuplach. Samica składa 3-4 jaja, wysiaduje je około 28 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 303,
                ImagePath = "_aleksandrettarozana.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 71,
                Name = "Aleksandretta obrożna",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Psittacula krameri",
                Occurance = "Od Afryki przez Afganistan, Pakistan, Indie, Sri Lankę i Birmę aż po Nepal. Żyje dziko również w zachodniej Europie.",
                LivingEnvritonment = "Tereny rolnicze, skraje lasów, parki i ogrody.",
                Food = "Owoce, nasiona, orzechy, kwiaty, nektar. Czasem wyrządzają szkody w uprawach cytrusów i innych owoców.",
                Breeding = "Gniazduje w dziuplach drzew, we wnękach skalnych, a nawet w szczelinach ścian budynków. W zniesieniu 3-4 jaja, inkubacja trwa 24 dni.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_aleksandrettaobrozna.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 72,
                Name = "Żako kongijskie",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.Vulnerable,
                LatinSpecie = "Psittacus erithacus",
                Occurance = "Środkowo-zachodnia Afryka.",
                LivingEnvritonment = "Wilgotne lasy nizinne, galeriowe, mangrowe, sawanna z rzadka porośnięta drzewami, obszary uprawne.",
                Food = "Owoce, nasiona, ziarno zbóż, ryżu i kukurydzy.",
                Breeding = "Gniazduje w dziupli wysokiego drzewa. W zniesieniu 2-4 jaja. Inkubacja trwa 21-30 dni. Młode opuszczają gniazdo po około 10 tygodniach.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 303,
                ImagePath = "_zakokongijskie.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 73,
                Name = "Ararauna zwyczajna",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Ara ararauna",
                Occurance = "Ameryka Południowa od Panamy po północny Paragwaj i Brazylię.",
                LivingEnvritonment = "Lasy galeriowe, sawanny porośnięte pojedynczymi drzewami.",
                Food = "Owoce, nasiona drzew i krzewów, orzechy, młode pędy. W poszukiwaniu pokarmu zalatują czasem w pobliże siedzib ludzkich i sieją spustoszenie wśród roślin uprawnych.",
                Breeding = "Gniazduje w dziuplach wysokich drzew. Samica składa 1-3 jaj, wysiaduje je około 26 dni. Młode opuszczają gniazdo po 95 dniach.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_araraunazwyczajna.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 74,
                Name = "Ara żółtoskrzydła",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Ara macao",
                Occurance = "Ameryka Południowa od Panamy przez Brazylię, Ekwador, Peru i Boliwię.",
                LivingEnvritonment = "Wilgotne lasy równikowe, często w pobliżu brzegów rzek.",
                Food = "Owoce, nasiona, liście, młode pędy, kwiaty. Czasem przebywają w pobliżu siedzib ludzkich",
                Breeding = "W zależności od regionu papugi te gniazdują w różnych porach roku. Gniazdo zakładają w dziuplach umieszczonych na wysokości 7-40 m. W zniesieniu 1-4 jaj, inkubacja trwa 24-28 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 303,
                ImagePath = "_arazoltoskrzydla.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 75,
                Name = "Ara zielona",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.Vulnerable,
                LatinSpecie = "Ara militaris",
                Occurance = "Meksyk, Kolumbia, Ekwador, Peru, Boliwia, Argentyna.",
                LivingEnvritonment = "Lasy deszczowe i górskie do wysokości 2600 m n.p.m.",
                Food = "Nasiona palm, orzechy, owoce. Ptaki te mogą wyrządzać szkody na plantacjach kukurydzy i w sadach.",
                Breeding = "Gniazduje w dziuplach i szczelinach klifów i skarp. W zniesieniu 2-3 jaja.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 303,
                ImagePath = "_arazielona.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 76,
                Name = "Mnicha",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Myiopsitta monachus",
                Occurance = "Argentyna, Paragwaj, Urugwaj, Boliwia, Brazylia. Introdukowana w wielu rejonach świata (m.in. w Wielkiej Brytanii i Hiszpanii).",
                LivingEnvritonment = "Lasy, tereny rolnicze. Przystosowała się do życia w miastach.",
                Food = "Nasiona, owoce, młode pędy drzew, owady i ich larwy.",
                Breeding = "Gnieździ się w koloniach, buduje duże gniazda z patyków, których waga może dochodzić do 200 kg. Bywają one zasiedlane przez kilka par zajmujących odrębne komory lęgowe. W zniesieniu do 11 jaj, okres inkubacji wynosi około 24 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 300,
                ImagePath = "_mnicha.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 77,
                Name = "Konura nandaj",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Nandayus nenday",
                Occurance = "Boliwia, Brazylia, Paragwaj, Argentyna.",
                LivingEnvritonment = "Lasy galeriowe, sawanny, pastwiska, zarośla.",
                Food = "Nasiona, owoce, kwiaty, pączki drzew i krzewów.",
                Breeding = "Gniazduje w dziuplach drzew. W zniesieniu zwykle 4 jaja, okres inkubacji wynosi 21-23 dni.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_konuranandaj.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 78,
                Name = "Amazonka niebieskoczelna",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Amazona aestiva",
                Occurance = "schodnia Brazylia, Paragwaj i północna Argentyna.",
                LivingEnvritonment = "Lasy deszczowe, suche stepy rzadko porośnięte drzewami.",
                Food = "Owoce, owady, młode liście, pędy drzew.",
                Breeding = "W okresie lęgowym tworzy stada, które mogą liczyć nawet setki osobników. Samica składa 2-4 jaj, z których po około 30 dniach wykluwają się pisklęta.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_amazonkaniebieskoczelna.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 79,
                Name = "Puchacz",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Bubo bubo",
                Occurance = "Europa i Azja z wyjątkiem obszarów położonych na północy tych kontynentów.",
                LivingEnvritonment = "Duże kompleksy leśne, często w pobliżu terenów otwartych lub dużych śródleśnych jezior, również olsy, łęgi.",
                Food = "Małe i średniej wielkości ssaki i ptaki. Poluje m. in. na jeże, wiewórki, gryzonie, gołębie, kuropatwy, wrony, kaczki, łyski.",
                Breeding = "Gnieździ się w opuszczonych gniazdach ptaków drapieżnych, pod wykrotami na ziemi lub na półce skalnej. W zniesieniu 2-4 jaja, wysiadywane przez samicę 34-36 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 311,
                ImagePath = "_puchacz.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 80,
                Name = "Sowa śnieżna",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Nyctea scandiaca",
                Occurance = "Północne rejony Eurazji i Ameryki Północnej.",
                LivingEnvritonment = "Tundra, wrzosowiska, tereny przybrzeżne.",
                Food = "Gryzonie, głównie lemingi, ptaki, sporadycznie ryby, płazy, skorupiaki, chrząszcze.",
                Breeding = "Gnieździ się na wyżej położonych, pagórkowatych torfowiskach i w zagłębieniach terenu. Samica składa od 3 do 10 jaj. Po 31-33 dniach wykluwają się szarobiałe pisklęta. Samiec aktywnie uczestniczy w odchowie młodych.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 320,
                ImagePath = "_sowasniezna.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 81,
                Name = "Puszczyk",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Strix aluco",
                Occurance = "Niemal cała Europa, północna Afryka, Azja (północno-zachodnie Indie, południowe Chiny, Korea, Tajwan).",
                LivingEnvritonment = "Lasy liściaste i mieszane, parki, zadrzewienia w pobliżu siedzib ludzkich. Spotykany nawet w centrum dużych miast.",
                Food = "Gryzonie, ptaki do wielkości bażanta, żaby, owady, padlina.",
                Breeding = "Gniazduje w obszernych dziuplach, opuszczonych gniazdach innych ptaków, szczelinach skalnych, zabudowaniach. Chętnie zajmuje odpowiednie skrzynki lęgowe. W zniesieniu 2-4 jaja, inkubacja trwa 28-30 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 320,
                ImagePath = "_puszczyk.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 82,
                Name = "Puszczyk mszarny",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Strix nebulosa",
                Occurance = "Północne rejony Europy, Azji i Ameryki Północnej.",
                LivingEnvritonment = "Tajga, borealne regiony górskie, torfowiska, lasotundra z gęstymi zaroślami.",
                Food = "Głównie gryzonie. Poluje również na ptaki, żaby, duże owady, wiewiórki, zające.",
                Breeding = "Gniazduje w opuszczonych gniazdach ptaków drapieżnych, czasem odbierając je prawowitym właścicielom. Gnieździ się również w złomach grubych pni drzew. W zniesieniu zwykle 3-4 jaja, samica wysiaduje je 28-30 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 320,
                ImagePath = "_puszczykmszarny.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 83,
                Name = "Puszczyk uralski",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Strix uralensis",
                Occurance = "Eurazja: od Skandynawii i krajów nadbałtyckich aż po Morze Japońskie oraz wyspowe obszary Karpat, Alp i Gór Dynarskich.",
                LivingEnvritonment = "Puszcze, duże kompleksy leśne, zarówno iglaste, jak i mieszane.",
                Food = "Gryzonie leśne, młode zające, drobne i średniej wielkości ptaki. Dietę uzupełnia płazami, jaszczurkami, owadami.",
                Breeding = "Gnieździ się w dużych dziuplach lub opuszczonych gniazdach ptaków drapieżnych. W zniesieniu zwykle 2-4 jaja, wysiadywane przez samicę 28-34 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 320,
                ImagePath = "_puszczykuralski.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 84,
                Name = "Kukabura chichotliwa",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Dacelo novaeguineae",
                Occurance = "Nowa Gwinea, Tasmania, wschodnia i południowa Australia.",
                LivingEnvritonment = "Brzegi lasów, luźne zadrzewienia.",
                Food = "Jaszczurki, węże, owady, kraby, ptasie pisklęta, inne drobne kręgowce.",
                Breeding = "Jest gatunkiem monogamicznym, ptaki łączą się w trwałe pary. Gniazduje w dziuplach, termitierach, budkach lęgowych. Składa najczęściej 2-3 jaja. Inkubacja trwa 24-29 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 300,
                ImagePath = "_kukabura.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 85,
                Name = "Gwarek",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Gracula religiosa",
                Occurance = "Południowa Azja od Indii i Cejlonu po Malezję i Indonezję.",
                LivingEnvritonment = "Lasy, tereny uprawne z wysokimi drzewami, brzegi lasów na nizinach i na terenach wyżej położonych (do wysokości około 2000 m n.p.m.).",
                Food = "Owoce, nektar, owady, czasem drobne kręgowce (np. jaszczurki).",
                Breeding = "Gnieździ się w dziuplach. W zniesieniu 2-3 jaja, okres inkubacji trwa 13-17 dni, wysiaduje samiec i samica.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_gwarek.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 86,
                Name = "Błyszczak purpurowy",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Lamprotornis purpureus",
                Occurance = "Afryka: Senegal, Gwinea, Uganda, Kenia.",
                LivingEnvritonment = "Sawanna.",
                Food = "Jagody, nasiona, owady i inne bezkręgowce. Nie gardzi również resztkami mięsa, pozostawionymi przez drapieżniki.",
                Breeding = "Gniazduje w dziuplach. Samica składa 2-4 jaja. Wysiadywanie trwa około 2 tygodnie. Pisklęta przebywają w gnieździe 4 tygodnie.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_blyszczakpurpurowy.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 87,
                Name = "Wikłacz ognisty",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Euplectes orix",
                Occurance = "Środkowa i południowa Afryka",
                LivingEnvritonment = "Suche sawanny, lasy galeriowe, uprawy w pobliżu osad ludzkich i zakrzewienia wzdłuż strumieni.",
                Food = "Głównie nasiona traw i innych roślin, nektar, jagody, owady. Powodują duże straty w uprawach.",
                Breeding = "Samiec łączy się z 2-3 samicami. Charakterystyczne gniazdo wikłaczy ma kształt spłaszczonej kuli. W zniesieniu 2-4 jaja. Wysiaduje tylko samica przez 12-15 dni.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_wiklaczogniasty.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 88,
                Name = "Bażant srebrzysty",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Lophura nycthemera",
                Occurance = "Zamieszkuje Tajlandię, Wietnam, Birmę, Laos, południowe Chiny i wyspę Hajnan.",
                LivingEnvritonment = "Lasy liściaste i bambusowe, głównie na wysokości 1500-2000 m n.p.m, pola uprawne.",
                Food = "Różne części roślin, owoce, nasiona. Dietę uzupełnia owadami.",
                Breeding = "W zniesieniu 6-8 jaj. Wysiaduje samica przez około 25 dni. Pisklęta są wodzone przez matkę, czasami samiec jej w tym pomaga.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 300,
                ImagePath = "_bazantsrebrzysty.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 89,
                Name = "Paw",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Pavo cristatus",
                Occurance = "Sri Lanka, Pakistan, Indie",
                LivingEnvritonment = "Lasy liściaste, nadrzeczne zarośla, tereny uprawne",
                Food = "Wszystkożerny, zjada nasiona, owoce oraz zwierzęta – zarówno bezkręgowce jak i drobne kręgowce, w tym węże, inne małe gady i ssaki.",
                Breeding = "W zniesieniu 3-6 jaj. Inkubacja trwa około 30 dni, wysiaduje tylko samica. Gniazdo umieszczone jest na ziemi, pod osłoną roślinności, wyścielone mchem i korzonkami.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_paw.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 90,
                Name = "Tragopan Temmincka",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Tragopan temminckii",
                Occurance = "Indie, Wietnam, Tybet, północne Chiny.",
                LivingEnvritonment = "Lasy mieszane, zarośla bambusowe i rododendrodowe do wysokości 2500 m n.p.m.",
                Food = "Liście, kwiaty, źdźbła traw, pędy bambusa, nasiona różnych roślin, owady.",
                Breeding = "Gniazdo znajduje się na drzewie na wysokości 0,5 – 8 m nad ziemią. W zniesieniu 3-8 jaj, wysiaduje tylko samica przez 26-28 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 300,
                ImagePath = "_tragopantemmincka.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 91,
                Name = "Bernikla kanadyjska",
                Group = AnimalGroup.Birds,
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Branta canadensis",
                Occurance = "Ameryka Północna (od Alaski aż po Wielkie Jeziora). W Europie hodowana jako ptak ozdobny. Uciekinierzy z niewoli dali początek populacjom, które występują obecnie w Wielkiej Brytanii, Skandynawii oraz Europie Zachodniej.",
                LivingEnvritonment = "Zamieszkuje tereny położone w pobliżu morskich brzegów, dużych rzek albo jezior, bagna, łąki, pastwiska, a nawet parki miejskie.",
                Food = "Przeważnie pokarm roślinny: trawy, korzonki, liście, owoce, zielone części roślin wodnych, ziarno, wodorosty.",
                Breeding = "Gniazdo znajduje się na ziemi w pobliżu wody. W zniesieniu zwykle 4-7 jaj, inkubacja trwa około 30 dni. Pisklęta są zagniazdownikami, co oznacza, że bardzo szybko po wykluciu z jaja są zdolne do samodzielnego życia, sprawnie chodzą, biegają i pływają.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_berniklakanadyjska.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            #endregion

            #region SSAKI 92-169
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 92,
                Name = "Kuskus ziemny",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Phalanger gymnotis",
                Occurance = "Nowa Gwinea i wyspa Aru.",
                LivingEnvritonment = "Lasy równikowe.",
                Food = "Zwierzę wszystkożerne. Chętnie zjada liście, pąki i pędy roślin, a także pokarm zwierzęcy – ptasie jaja, pisklęta i owady.",
                Breeding = "Ciąża trwa 2 tygodnie. Po tym czasie rodzi się młode, którego dalszy rozwój przebiega w matczynej torbie.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 320,
                ImagePath = "_kuskusziemny.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 93,
                Name = "Lotopałanka mała",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Petaurus breviceps",
                Occurance = "Australia, Nowa Gwinea.",
                LivingEnvritonment = "Lasy deszczowe, plantacje orzechów kokosowych, zarośla.",
                Food = "Małe bezkręgowce oraz soki roślinne i owoce.",
                Breeding = "Ciąża trwa 21 dni. Samica rodzi 2 - 3 młode.",
                AnimalDanger = AnimalDanger.None,
              //  MapItemId = ,
                ImagePath = "_lotopalankamala.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 94,
                Name = "Kangur Walabia Benetta",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Macropus rufogriseus",
                Occurance = "Wschodnia i południowo-wschodnia Australia oraz Tasmania.",
                LivingEnvritonment = "Zamieszkuje otwarte tereny przybrzeżne.",
                Food = "Typowy roślinożerca. Żywi się głównie liśćmi i trawą.",
                Breeding = "Po krótkim, około 35 – dniowym okresie ciąży samica rodzi młode wielkości ziarna fasoli, nagie i ślepe. Wędruje ono wzdłuż wylizanej przez matkę trasy od jej dróg rodnych do wnętrza torby. Tam obejmuje pyszczkiem sutek matki i rozwija się dalej przez około 7 miesięcy.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 313,
                ImagePath = "_walabiabenetta.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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
                ImagePath = "_slonindyjski.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 96,
                Name = "Pancernik włochaty",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Chaetophractus villosus",
                Occurance = "Argentyna, Boliwia, Chile i Urugwaj.",
                LivingEnvritonment = "Zamieszkuje łąki, lasy, sawanny, tereny rolnicze, pampy - typowe dla Ameryki Południowej środowisko o charakterze stepowym.",
                Food = "Głównie bezkręgowce, a także małe kręgowce, owoce, padlina.",
                Breeding = "Po ciąży trwającej 2 miesiące rodzą się najczęściej 2 młode.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 321,
                ImagePath = "_pancernikwlochaty.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 97,
                Name = "Leniwiec dwupalczasty",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Choloepus didactylus",
                Occurance = "Wenezuela, Gujana i północna Brazylia.",
                LivingEnvritonment = "Wilgotne lasy nizinne.",
                Food = "Liście, pędy roślin i owoce.",
                Breeding = "Ciąża trwa około 10 miesięcy. W miocie tylko jedno młode, które przyczepia się do włosów na piersi i brzuchu matki.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_leniwiecdwupalczasty.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 98,
                Name = "Lemur czerwonobrzuchy",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Endangered,
                LatinSpecie = "Eulemur rubriventer",
                Occurance = "Madagaskar.",
                LivingEnvritonment = "Lasy deszczowe.",
                Food = "Owoce, pędy, bezkręgowce, drobne kręgowce.",
                Breeding = "Po ciąży trwającej 120 dni samica rodzi jedno młode, które jest noszone przez rodziców do około 35 dnia życia. Później opiekuje się nim głównie samiec. Matka karmi młode do piątego miesiąca życia.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 315,
                ImagePath = "_lemurczerwonobrzuchy.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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
                MapItemId = 315,
                ImagePath = "_lemurkatta.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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
                MapItemId = 315,
                ImagePath = "_warirudy.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 101,
                Name = "Lori mały",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Vulnerable,
                LatinSpecie = "Nycticebus pygmaeus",
                Occurance = "Wietnam, Laos, Chiny i Kambodża.",
                LivingEnvritonment = "Lasy deszczowe.",
                Food = "Owady, mięczaki, jaja, jaszczurki, ptaki, małe ssaki, owoce i inne części roślin.",
                Breeding = "Po trwającej ok. 190 dni ciąży samica rodzi 1–2 młode, które karmi mlekiem przez około 9 miesięcy. Młode po narodzinach są w pełni rozwinięte i pokryte futrem.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_lorimaly.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 102,
                Name = "Marmozeta białoczelna",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Callithrix geoffroyi",
                Occurance = "Południowo-wschodnia Brazylia.",
                LivingEnvritonment = "Wilgotne lasy nizinne.",
                Food = "Owoce, owady, żywica drzew, rzadziej kwiaty, nektar, ślimaki, pająki oraz drobne kręgowce.",
                Breeding = "Po ciąży trwającej około 140 dni rodzą się 1-3 młode. Młodymi opiekują się zarówno matka jak i ojciec.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_marmozetabialoczelna.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 103,
                Name = "Lwiatka złota",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Endangered,
                LatinSpecie = "Leontopithecus rosalia",
                Occurance = "Południowo-wschodnia Brazylia.",
                LivingEnvritonment = "Nizinny las deszczowy.",
                Food = "Owoce, nasiona, kwiaty, nektar, żywica, ślimaki, jaszczurki, pająki, owady.",
                Breeding = "Po ciąży trwającej 125-132 dni rodzi się 1-3 młodych, którymi opiekuje się ojciec i matka.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_lwiatkazlota.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 104,
                Name = "Tamaryna białoczuba",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.CriticallyEndangered,
                LatinSpecie = "Saguinus oedipus",
                Occurance = "Północno-zachodnia Kolumbia.",
                LivingEnvritonment = "Lasy deszczowe.",
                Food = "Owoce, owady, pająki, małe kręgowce, ptasie jaja.",
                Breeding = "Ciąża trwa 6 miesięcy. Samica rodzi 1-2 młode.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 301,
                ImagePath = "_tamarynabialoczuba.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 105,
                Name = "Sajmiri wiewiórcza",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Saimiri sciureus",
                Occurance = "Północna i środkowa część Ameryki Południowej.",
                LivingEnvritonment = "Wilgotne lasy dorzecza Amazonki.",
                Food = "Owoce, owady, nektar, pająki, ptasie jaja, młode ptaki, nietoperze.",
                Breeding = "Po ciąży trwającej 160-170 dni rodzi się 1 młode.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 315,
                ImagePath = "_sajmiriwiewiorcza.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 106,
                Name = "Mangaba czarna",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.NearThreatened,
                LatinSpecie = "Lophocebus aterrimus",
                Occurance = "Afryka Centralna, na południe od rzeki Kongo.",
                LivingEnvritonment = "Lasy.",
                Food = "Głównie owoce i nasiona. Dietę uzupełnia młodymi liśćmi, nektarem, kwiatami, owadami, małymi gadami.",
                Breeding = "Ciąża trwa około 170 dni. Samica rodzi zazwyczaj jedno młode, które pozostaje pod jej opieką około 1,5 roku.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_mangabaczarna.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 107,
                Name = "Mandryl",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Vulnerable,
                LatinSpecie = "Mandrillus sphinx",
                Occurance = "Afryka od południowego Kamerunu po Kongo.",
                LivingEnvritonment = "Lasy równikowe.",
                Food = "Owoce, nasiona, bulwy, orzechy oraz owady i małe kręgowce.",
                Breeding = "Po ciąży trwającej około 250 dni na świat przychodzi jedno młode, którym opiekuje się matka, nosząc je na brzuchu, a potem na grzbiecie.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 322,
                ImagePath = "_mandryl.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 108,
                Name = "Gereza abisyńska",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Colobus guereza",
                Occurance = "Środkowa i wschodnia Afryka: Kamerun, Nigeria, Etiopia, Kenia, Tanzania i Czad.",
                LivingEnvritonment = "Lasy deszczowe, górskie i nizinne centralnej i wschodniej Afryki do wysokości 3300 m n.p.m.",
                Food = "Liście (najchętniej młode), owoce, pączki liści i kwiatów.",
                Breeding = "Po ciąży trwającej 160-170 dni rodzi się jedno młode. W przeciwieństwie do osobników dorosłych, skóra noworodka jest różowa, a jego futerko białe. W trzecim tygodniu życia uszy i skóra na twarzy malucha zaczynają stopniowo zmieniać kolor na szary. Z czasem młode coraz bardziej upodabnia się do dorosłych, czarno-białych małp.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_gerezaabisynska.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 109,
                Name = "Lutung jawajski",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Vulnerable,
                LatinSpecie = "Trachypithecus auratus auratus",
                Occurance = "Jawa, Bali i Indonezja.",
                LivingEnvritonment = "Lasy deszczowe.",
                Food = "Głównie młode liście z niską zawartością włókna, owoce, kwiaty i owady.",
                Breeding = "Ciąża u tego gatunku trwa 6 miesięcy. Młode po urodzeniu ma zawsze intensywnie pomarańczowy kolor sierści. Opiekują się nim wszystkie samice w grupie.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_lutung.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 110,
                Name = "Gibbon białoręki",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Endangered,
                LatinSpecie = "Hylobates lar",
                Occurance = "Półwysep Indochiński i Sumatra.",
                LivingEnvritonment = "Wilgotne lasy nizinne, a także lasy górskie do wysokości około 2000 m n.p.m.",
                Food = "Owoce, liście, pąki, kwiaty, ptasie jaja, młode ptaki, pająki, owady.",
                Breeding = "Po ciąży trwającej około 6 miesięcy rodzi się jedno młode, którym początkowo opiekuje się wyłącznie matka, a następnie również ojciec.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 322,
                ImagePath = "_gibbonbialoreki.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 111,
                Name = "Szympans",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Endangered,
                LatinSpecie = "Pan troglodytes",
                Occurance = "Środkowa Afryka.",
                LivingEnvritonment = "Dżungla, sucha sawanna, górskie lasy.",
                Food = "Pokarm roślinny, owady, małe i średniej wielkości ssaki.",
                Breeding = "Po ciąży trwającej około 230 dni przychodzi na świat najczęściej jedno młode, które przez kilka lat zachowuje bliskie więzy z matką.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 322,
                ImagePath = "_szympans.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 112,
                Name = "Wiewiórka trójbarwna",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Callosciurus prevostii",
                Occurance = "Tajlandia, Indonezja, Malezja.",
                LivingEnvritonment = "Lasy.",
                Food = "Owoce, nasiona, orzechy, pączki drzew i krzewów, owady, jaja ptaków.",
                Breeding = "Ciąża trwa około 40 dni. Młode początkowo przebywają w gnieździe znajdującym się w dziupli lub w rozgałęzieniu konarów drzewa. Jest ono wyścielone miękkimi gałązkami i liśćmi.",
                AnimalDanger = AnimalDanger.None,
              //  MapItemId = ,
                ImagePath = "_wiewiorkatrojbarwna.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 113,
                Name = "Jeżozwierz indyjski",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Hystrix indica",
                Occurance = "Azja południowo-zachodnia: Indie, Cejlon, Turkiestan.",
                LivingEnvritonment = "Suche tereny skaliste, lasy i sawanny.",
                Food = "Pokarm roślinny, chętnie owoce. Dietę uzupełnia owadami.",
                Breeding = "Ciąża trwa około 100 dni. Samica rodzi 2–4 młodych, pokrytych miękkimi białymi kolcami.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 307,
                ImagePath = "_jezozwierz.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 114,
                Name = "Rudawka nilowa",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Rousettus aegyptiacus",
                Occurance = "Cypr, Afryka, Bliski i Środkowy Wschód po Pakistan.",
                LivingEnvritonment = "Na schronienia wybiera głównie drzewa i jaskinie.",
                Food = "Owoce, kwiaty, liście, nektar.",
                Breeding = "Po ciąży trwającej około 4 miesięcy rodzi się zwykle jedno młode. Rzadko zdarzają się porody bliźniąt.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 320,
                ImagePath = "_rudawkanilowa.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 115,
                Name = "Karakal",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Caracal caracal",
                Occurance = "Afryka, Półwysep Arabski, Azja (Afganistan, Pakistan, Iran, Indie).",
                LivingEnvritonment = "Sawanny, półpustynie, krzaczaste zarośla.",
                Food = "Małe ssaki, ptaki, węże, płazy.",
                Breeding = "Po ciąży trwającej około 70 dni rodzą się 1-3 młode.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 306,
                ImagePath = "_karakal.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 116,
                Name = "Chaus",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Felis chaus",
                Occurance = "Występuje w Egipcie oraz zachodniej, środkowej i południowej Azji aż po Płw. Indochiński.",
                LivingEnvritonment = "Zamieszkuje gęsto zakrzewione i porośnięte trzcinami brzegi wód.",
                Food = "Ryby, płazy, małe gady, gryzonie i ptaki. Poluje w dzień i nocą.",
                Breeding = "Po ciąży trwającej 63-68 dni na świat przychodzi 3-5 młodych.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 321,
                ImagePath = "_chaus.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 117,
                Name = "Manul",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.NearThreatened,
                LatinSpecie = "Otocolobus manul",
                Occurance = "Azja Środkowa, Iran, Afganistan, Pakistan.",
                LivingEnvritonment = "Zamieszkuje stepy, skaliste pustynie, równiny i góry do wysokości 4500 m n.p.m.",
                Food = "Drobne gryzonie (myszoskoczki, karczowniki, chomiki, wiewiórki),       a także zające i ptaki.",
                Breeding = "Ciąża trwa 66-75 dni. W kwietniu lub maju samica rodzi od 4 do 6 młodych.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 117,
                ImagePath = "_manul.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 118,
                Name = "Żbik",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Felis silvestris",
                Occurance = "Południowa i środkowa Europa, Azja Mniejsza, Kaukaz, północna Afryka.",
                LivingEnvritonment = "Lasy mieszane i liściaste z bogatym podszytem, zakrzaczenia śródpolne, doliny potoków i rzek.",
                Food = "Drobne gryzonie, ssaki owadożerne, kuraki leśne i inne ptaki, zające, padlina.",
                Breeding = "Samica po ciąży trwającej 63-68 dni rodzi raz w roku 1-7 kociąt na przełomie maja i czerwca. Matka karmi kocięta przez około 1,5 miesiąca. Młode usamodzielniają się po 5-6 miesiącach, dojrzałość płciową osiągają po 10-12 miesiącach.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 321,
                ImagePath = "_zbik.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 119,
                Name = "Kot argentyński",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Leopardus geoffroyi",
                Occurance = "Boliwijskie i argentyńskie Andy, południowa część Paragwaju i Brazylii, zachodnia część Urugwaju i Chile.",
                LivingEnvritonment = "Zamieszkuje stepy, lasy, tereny górzyste do wysokości 3300 m n.p.m.",
                Food = "Gryzonie, ryby, żaby, ptaki, zające.",
                Breeding = "Po ciąży trwającej 62-76 dni samica rodzi 1-3 młode, które osiągają dojrzałość płciową w wieku około 18 miesięcy.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 306,
                ImagePath = "_kotargentynski.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 120,
                Name = "Kot arabski",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.NearThreatened,
                LatinSpecie = "Felis margarita",
                Occurance = "Sahara, Półwysep Arabski, zachodni Egipt, pogranicze Pakistanu i Afganistanu.",
                LivingEnvritonment = "Głównie pustynie, spotykany również na równinach ubogich w roślinność i skalistych dolinach.",
                Food = "Myszoskoczki, nornikowate, zające, pająki, jaszczurki, ptaki, owady oraz węże.",
                Breeding = "Po ciąży trwającej 59-67 dni na świat przychodzi 2-5 kociąt (najczęściej 3). Dojrzałość płciową osiągają w wieku 9-14 miesięcy.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_kotarabski.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 121,
                Name = "Ocelot",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Leopardus pardalis",
                Occurance = "Ameryka Środkowa i północna część Ameryki Południowej.",
                LivingEnvritonment = "Głównie lasy deszczowe, rzadziej spotykany na obszarach porośniętych ciernistymi zaroślami.",
                Food = "Gryzonie, oposy, króliki, ptaki, małe naczelne, ryby, żaby, owady.",
                Breeding = "Po ciąży trwającej 79-82 dni rodzi się najczęściej 1 młode.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 306,
                ImagePath = "_ocelot.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 122,
                Name = "Serwal",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Leptailurus serval",
                Occurance = "Afryka na południe od Sahary.",
                LivingEnvritonment = "Zakrzewione sawanny, stepy.",
                Food = "Ptaki, gryzonie, zające, płazy, gady, ryby, owady. W czasie polowania siedzi zaczajony w trawie, lokalizuje swoją ofiarę nasłuchując i w pewnym momencie wyskakuje wysoko, spadając na ziemię z wyciągniętymi pazurami dokładnie w miejscu, gdzie znajduje się zdobycz.",
                Breeding = "Ciąża trwa 68-74 dni. Przed porodem samica przygotowuje gniazdo w gęstej roślinności lub w gnieździe innego zwierzęcia. W miocie 1-4 kociąt (zwykle 2). W 4 tygodniu młode zaczynają jeść mięso.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 306,
                ImagePath = "_serwal.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 123,
                Name = "Ryś",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Lynx lynx",
                Occurance = "Od środkowej Europy i Skandynawii, poprzez Turcję, Irak, Iran, Rosję i Mongolię aż do Mandżurii.",
                LivingEnvritonment = "Lasy, rzadziej tereny bardziej otwarte, półpustynne, słabiej zadrzewione i obszary górskie.",
                Food = "Dzikie ssaki kopytne (głównie sarna). W górach kozice. Jego ofiarą padają również łosie, renifery, jelenie, dziki, zające, kuraki, drobne gryzonie.",
                Breeding = "Ruja przypada na luty i marzec. Po ciąży trwającej 67-74 dni rodzą się najczęściej 2 - 3 młode.Matka karmi je mlekiem 70 - 80 dni.W wieku około 3 miesięcy młode opuszczają gniazdo i podążają za matką.Przebywają z nią do 10 miesiąca życia.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_rys.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 124,
                Name = "Jaguarundi",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Puma yagouaroundi",
                Occurance = "Od południowego Teksasu do północnej Argentyny i Brazylii.",
                LivingEnvritonment = "Las deszczowy, cierniste zarośla, pastwiska, tereny podmokłe.",
                Food = "Gryzonie, ptaki, gady, króliki, owoce.",
                Breeding = "Po ciąży trwającej 72-75 dni rodzi się 1-4 młodych. Kocięta przychodzą na świat w gnieździe znajdującym się w gęstej roślinności lub w dziupli drzewa. Dojrzałość płciową osiągają po 1,5-2 latach.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 306,
                ImagePath = "_jaguarundi.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 125,
                Name = "Lew azjatycki",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Endangered,
                LatinSpecie = "Panthera leo persica",
                Occurance = "Rezerwat Gir w prowincji Gujarat na północnym zachodzie Indii.",
                LivingEnvritonment = "Lasy, obszary porośnięte krzewami.",
                Food = "Ssaki kopytne, bydło domowe, antylopy, gazele.",
                Breeding = "Po ciąży trwającej około 110 dni rodzi się 1-4 kociąt. Stają się całkowicie niezależne od matki w wieku około dwóch i pół roku.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 318,
                ImagePath = "_lewazjatycki.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 126,
                Name = "Jaguar",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.NearThreatened,
                LatinSpecie = "Panthera onca",
                Occurance = "Ameryka Środkowa, północna i środkowa część Ameryki Południowej.",
                LivingEnvritonment = "Brzegi rzek, obrzeża lasów, różnego rodzaju tereny podmokłe.",
                Food = "Duże i średniej wielkości ssaki: kapibary, jelenie, tapiry, pekari, a także kajmany i inne gady oraz ptaki i ryby.",
                Breeding = "Ciąża trwa około 100 dni. W miocie rodzą się 1-3 ślepe młode, którymi matka opiekuje się przez 2 lata.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 312,
                ImagePath = "_jaguar.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 127,
                Name = "Pantera chińska",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.NearThreatened,
                LatinSpecie = "Panthera pardus japonensis",
                Occurance = "Chiny.",
                LivingEnvritonment = "Nizinne lasy tropikalne, zadrzewione stepy oraz górskie lasy.",
                Food = "Ssaki różnej wielkości, ptaki, gady.",
                Breeding = "Po ciąży trwającej około 96 dni rodzi się najczęściej od 1 do 3 kociąt. Dojrzałość płciową osiągają w wieku 2-3 lat.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_panterachinska.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 128,
                Name = "Tygrys amurski",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Endangered,
                LatinSpecie = "Panthera tigris altaica",
                Occurance = "Wschodnie regiony Rosji, pogranicze rosyjsko-chińskie, w dolnym biegu rzeki Amur.",
                LivingEnvritonment = "Tajga, górskie lasy iglaste i mieszane, często w pobliżu rzek i potoków.",
                Food = "Jeleniowate, dziki, mniejsze ssaki, ptaki, gady, ryby. Poluje głównie nocą. Ocenia się, że jeden atak na dwadzieścia kończy się sukcesem.",
                Breeding = "Po 105-dniowej ciąży rodzą się 2-3 młode. Matkę opuszczają w wieku 2 lat. Samiec nie bierze udziału w wychowywaniu młodych.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 318,
                ImagePath = "_tygrysamurski.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 129,
                Name = "Pantera śnieżna",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Endangered,
                LatinSpecie = "Uncia uncia",
                Occurance = "Góry środkowej Azji do wysokości 6000 m n.p.m.",
                LivingEnvritonment = "Zamieszkuje tereny położone na znacznych wysokościach, aż do granicy wiecznego śniegu, dochodząc do wysokości nawet 6 000 m n.p.m.",
                Food = "Owce górskie, koziorożce, jelonki piżmowe, młode jaki, bażanty i świstaki, zwierzęta domowe.",
                Breeding = "Po ciąży trwającej 94-103 dni samica rodzi od 1 do 5 kociąt. Młode osiągają dojrzałość płciową w wieku 2-3 lat.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 318,
                ImagePath = "_panterasniezna.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 130,
                Name = "Żeneta północna",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Genetta genetta",
                Occurance = "Północno-zachodnia Afryka, Półwysep Pirenejski, południowo-zachodnia Francja.",
                LivingEnvritonment = "Stepy, sawanny, lasy, tereny skaliste pozbawione drzew, czasem w pobliżu ludzkich siedzib.",
                Food = "Drobne gryzonie, ptaki, owady.",
                Breeding = "Po ciąży trwającej 70-77 dni samica rodzi 1-5 młodych.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 310,
                ImagePath = "_zenetapolnocna.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 131,
                Name = "Surykatka",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Suricata suricatta",
                Occurance = "Południowa Afryka.",
                LivingEnvritonment = "Suche, otwarte obszary.",
                Food = "Owady, skorpiony, pająki, drobne kręgowce, małe węże, jaszczurki, jaja gadów i ptaków oraz bulwy roślin.",
                Breeding = "Ciąża trwa około 70 dni. W miocie rodzi się zwykle 3-7 młodych.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 302,
                ImagePath = "_surykatka.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 132,
                Name = "Wilk grzywiasty",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.NearThreatened,
                LatinSpecie = "Chrysocyon brachyurus",
                Occurance = "Ameryka Południowa: południowa Brazylia, Paragwaj, Boliwia.",
                LivingEnvritonment = "Trawiaste pampy (formacje roślinne o charakterze stepowym).",
                Food = "Gryzonie i inne niewielkie ssaki, ptaki, owoce.",
                Breeding = "Ciąża trwa około 65 dni. W miocie jest zwykle 1-7 szczeniąt.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 307,
                ImagePath = "_wilkgrzywiasty.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 133,
                Name = "Otocjon",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Otocyon megalotis",
                Occurance = "Afryka południowa i wschodnia.",
                LivingEnvritonment = "Sawanna, suche obszary trawiaste.",
                Food = "Owady – głównie termity i chrząszcze. Zdobycz lokalizowana jest słuchem, a następnie szybko odkopywana. Dietę uzupełnia owocami, jajami, gadami i ptakami.",
                Breeding = "Po ciąży trwającej około 70 dni rodzi się 1-6 szczeniąt.",
                AnimalDanger = AnimalDanger.None,
              //  MapItemId = ,
                ImagePath = "_otocjon.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 134,
                Name = "Fennek",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Vulpes zerda",
                Occurance = "Półwysep Arabski i północna Afryka.",
                LivingEnvritonment = "Obszary pustynne.",
                Food = "Małe gryzonie, ptaki, jaja, jaszczurki, owady, a także pokarm roślinny.",
                Breeding = "Ciąża trwa około 50 dni. Samica rodzi w jednym miocie 1-4 młodych. Szczenięta pozostają pod opieką matki przez około 9 miesięcy.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 310,
                ImagePath = "_fennek.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 135,
                Name = "Uchatka patagońska",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Otaria flavescens",
                Occurance = "Wybrzeże Ameryki Południowej od Peru po przylądek Horn.",
                LivingEnvritonment = "Żyją w środowisku wodnym, ale również sprawnie poruszają się po lądzie.",
                Food = "Ryby i głowonogi.",
                Breeding = "Ciąża trwa ok. 11 miesięcy, samica rodzi 1 młode, które osiąga dojrzałość płciową pomiędzy 4 i 5 rokiem życia.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 135,
                ImagePath = "_uchatkapatagonska.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 136,
                Name = "Wydra europejska",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.NearThreatened,
                LatinSpecie = "Lutra lutra",
                Occurance = "Europa, Azja, północna Afryka.",
                LivingEnvritonment = "Wybrzeża morskie, jeziora, stawy, rzeki, strumienie, bagna i torfowiska oraz kanały melioracyjne.",
                Food = "Głównie ryby, a także żaby, raki, mięczaki i owady. Sporadycznie polują na drobne ssaki i ptaki.",
                Breeding = "Dane o przebiegu ciąży są sprzeczne. Według niektórych badaczy ciąża trwa około 60 dni, inni uważają, że u wydry występuje zjawisko zahamowania rozwoju zarodka i związana z tym ciąża przedłużona, trwająca około 13 miesięcy. Wielkość miotu wynosi 2-4 młodych.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 136,
                ImagePath = "_wydra.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 137,
                Name = "Hirara",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Eira barbara",
                Occurance = "Zamieszkuje Amerykę Środkową, Meksyk i Amerykę Południową po Paragwaj i Argentynę oraz Wyspy Trynidad.",
                LivingEnvritonment = "Las tropikalny, plantacje, pola uprawne.",
                Food = "Małe ssaki i ptaki, jaja ptasie, owady, owoce, miód dzikich pszczół.",
                Breeding = "Po ciąży trwającej 63-67 dni, rodzą się 1-3 ślepe młode.",
                AnimalDanger = AnimalDanger.None,
              //  MapItemId = ,
                ImagePath = "_hirara.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 138,
                Name = "Borsuk",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Meles meles",
                Occurance = "Europa z wyjątkiem północnej Skandynawii, Azja.",
                LivingEnvritonment = "Tereny leśne w pobliżu łąk i pól, zadrzewienia śródpolne, obrzeża większych lasów.",
                Food = "Drobne gryzonie, płazy, ślimaki, dżdżownice, kłącza, bulwy, owoce, nasiona, grzyby.",
                Breeding = "U borsuków występuje zjawisko ciąży przedłużonej, rozwój zapłodnionej komórki jajowej zatrzymuje się na kilka miesięcy. Cały okres ciąży trwa około 10 miesięcy, a nawet dłużej. Młode (najczęściej 3-4) rodzą się w okresie od stycznia do kwietnia. Dojrzałość płciową uzyskują w wieku 14 miesięcy.",
                AnimalDanger = AnimalDanger.None,
              //  MapItemId = ,
                ImagePath = "_borsuk.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 139,
                Name = "Koati południowy",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Nasua nasua",
                Occurance = "Północna i środkowa część Ameryki Południowej.",
                LivingEnvritonment = "Lasy deszczowe i zadrzewienia do wysokości 2500 m n.p.m.",
                Food = "Owady, owoce, skorpiony, pająki, gryzonie, ryby, pokarm roślinny.",
                Breeding = "Ciąża trwa 77 dni; w jednym miocie rodzi się najczęściej 3-4 młodych.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 321,
                ImagePath = "_koatipoludniowy.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 140,
                Name = "Szop pracz",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Procyon lotor",
                Occurance = "Ameryka Północna i Środkowa. Introdukowany w Europie w początkach lat 30-tych XX wieku, w Polsce pojawił się w latach 80-tych.",
                LivingEnvritonment = "Zadrzewione tereny w pobliżu wody, obszary zurbanizowane.",
                Food = "Ślimaki, żaby, ryby i raki oraz orzechy, nasiona, owoce. Ma charakterystyczny zwyczaj płukania pokarmu w wodzie, stąd wywodzi się jego nazwa.",
                Breeding = "Po około 65-dniowej ciąży rodzi się   1-7 młodych. Matka karmi je mlekiem przez 2-3 miesiące. Po tym czasie młode szopy zaczynają samodzielnie poszukiwać pożywienia.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 321,
                ImagePath = "_szoppracz.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 141,
                Name = "Panda mała",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Endangered,
                LatinSpecie = "Ailurus fulgens",
                Occurance = "Północna Birma, zachodni Sichuan i Yunnan.",
                LivingEnvritonment = "Lasy liściaste i iglaste na wysokości od 2200 do 4800 m n.p.m.",
                Food = "Liście bambusa, jagody, ptasie jaja.",
                Breeding = "Pora godowa przypada na wczesną zimę. Młode (od 1 do 4) rodzą się po pięciomiesięcznej ciąży. Gniazda zakłada w dziuplach lub w szczelinach skał.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 141,
                ImagePath = "_pandamala.jpg",
                Length = "",
                Weight = "",
                Longevity = "14 lat"
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 142,
                Name = "Osioł domowy",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Equus asinus",
                Occurance = "Zwierzę użytkowane przez człowieka w wielu regionach świata.",
                LivingEnvritonment = "Zwierzę udomowione.",
                Food = "Trawa, gałęzie, kora. Posiada duże płaskie zęby przystosowane do rozrywania i żucia pokarmu.",
                Breeding = "Ciąża trwa około 12 miesięcy. Samica rodzi zwykle jedno źrebię, które zaraz po urodzeniu może podążać za matką.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 142,
                ImagePath = "_osioldomowy.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 143,
                Name = "Zebra Chapmana",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Equus burchelli chapmanni",
                Occurance = "Afryka południowa, Zimbabwe, Botswana.",
                LivingEnvritonment = "Sawanny i stepy.",
                Food = "Głównie trawy i rośliny zielne.",
                Breeding = "Po ciąży trwającej 12 miesięcy rodzi się jedno młode. Samice uzyskują dojrzałość płciową między 2 a 3 rokiem życia. Ogiery po osiągnięciu wieku około 5 lat zaczynają utrzymywać harem klaczy.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 143,
                ImagePath = "_zebrachapmana.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 144,
                Name = "Kuc szetlandzki",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.NotEvaluated,
                LatinSpecie = "Equus caballus",
                Occurance = "Rasa koni hodowana na całym świecie, pochodząca z Wysp Szetlandzkich.",
                LivingEnvritonment = "Zwierzę udomowione.",
                Food = "Kuce szetlandzkie są niewybredne w doborze pokarmu. Żywią się głównie sianem i trawą.",
                Breeding = "Ciąża trwa 338-342 dni. Zazwyczaj rodzi się 1 źrebak.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_kucszetlandzki.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 145,
                Name = "Koń Przewalskiego",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Endangered,
                LatinSpecie = "Equus przewalskii",
                Occurance = "Reintrodukowany w parkach narodowych Mongolii. Program przywrócenia tego gatunku do natury rozpoczął się w roku 1992 w Parku Narodowym Hustain Nuruu.",
                LivingEnvritonment = "Stepy.",
                Food = "Trawa i roślinność stepowa.",
                Breeding = "Po ciąży trwającej 330-350 dni rodzi się 1 młode. Klacze osiągają dojrzałość płciową w wieku 2 lat, ogiery w 3 roku życia.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 145,
                ImagePath = "_konprzewalskiego.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 146,
                Name = "Kułan",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.NearThreatened,
                LatinSpecie = "Equus hemionus kulan",
                Occurance = "Kazachstan i Turkmenistan.",
                LivingEnvritonment = "Stepy i półpustynie.",
                Food = "Trawy, roślinność stepowa, zioła, gałęzie krzewów, korzenie.",
                Breeding = "Ciąża trwa 11 miesięcy. Klacz rodzi 1 źrebię. Laktacja trwa 6-8 miesięcy.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 146,
                ImagePath = "_kulan.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 147,
                Name = "Tapir anta",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Vulnerable,
                LatinSpecie = "Tapirus terrestris",
                Occurance = "Środkowa i północna część Ameryki Południowej.",
                LivingEnvritonment = "Nizinne tropikalne lasy deszczowe.",
                Food = "Liście, rośliny wodne i bagienne, trawy, owoce.",
                Breeding = "Po ciąży trwającej 13-14 miesięcy na świat przychodzi jedno młode (bliźnięta rodzą się bardzo rzadko). Młode są charakterystycznie ubarwione – ich brązowa sierść aż do 9 miesiąca życia pokryta jest białymi pasami i plamkami. Maluchy są dzięki temu niewidoczne w gęstwinie leśnej.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 308,
                ImagePath = "_tapiranta.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 148,
                Name = "Świnia zwisłobrzucha",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.NotEvaluated,
                LatinSpecie = "Sus scrofa domestica",
                Occurance = "Rasa świń pochodząca z Azji.",
                LivingEnvritonment = "Jedna z wielu ras hodowanej również u nas świni domowej.",
                Food = "Zboże, jarzyny, otręby, płatki owsiane, zielonka.",
                Breeding = "Ciąża trwa około 115 dni. Locha w ciągu roku może dać dwa mioty liczące ponad 10 młodych w każdym.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_swiniazwislobrzucha.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 149,
                Name = "Hipopotam karłowaty",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Endangered,
                LatinSpecie = "Hexaprotodon liberiensis",
                Occurance = "Afryka zachodnia: Sierra Leone, Liberia, Wybrzeże Kości Słoniowej.",
                LivingEnvritonment = "Lasy i podmokłe tereny nad brzegami rzek.",
                Food = "Pędy roślin, kłącza, korzenie i inne części roślin.",
                Breeding = "Po ciąży trwającej około 6 miesięcy przychodzi na świat jedno młode (rzadziej bliźnięta). Niedługo po urodzeniu młode jest w pełni sprawne i podąża za matką.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 149,
                ImagePath = "_hipopotamkarlowaty.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 150,
                Name = "Wielbłąd dwugarbny",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.CriticallyEndangered,
                LatinSpecie = "Camelus bactrianus",
                Occurance = "W stanie dzikim – głównie na pustyni Gobi i na półpustyniach Chin. W formie udomowionej – rozprzestrzeniony w wielu krajach.",
                LivingEnvritonment = "Pustynie i półpustynie, suche stepy.",
                Food = "Roślinność pustynna, nawet suche pędy, nie zjadane przez inne ssaki. Zwierzę to jest bardzo odporne na brak wody.",
                Breeding = "Po ciąży trwającej około 13 miesięcy rodzi się zwykle 1 młode, które w chwili narodzin waży średnio około 35 kg.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 309,
                ImagePath = "_wielbladdwugarbny.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 151,
                Name = "Gwanako",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Lama guanicoe",
                Occurance = "Ameryka Południowa - Andy od południowego Peru do Ziemi Ognistej.",
                LivingEnvritonment = "Obszary trawiaste na wyżynach, na wysokości nawet ponad 4000 m n.p.m, sawanny, zarośla i półpustynie.",
                Food = "Trawa, liście oraz pączki drzew i krzewów.",
                Breeding = "Po ciąży trwającej około 11 miesięcy rodzi się zazwyczaj 1 młode, które wkrótce po urodzeniu podąża za matką. Dojrzałość płciową osiąga w drugim roku życia.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 309,
                ImagePath = "_gwanako.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 152,
                Name = "Alpaka",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.NotEvaluated,
                LatinSpecie = "Lama pacos",
                Occurance = "Zwierzęta udomowione. Hodowane na zboczach Andów w Ekwadorze, Boliwii, Peru i Chile.",
                LivingEnvritonment = "Górskie zbocza - spotykane na wysokościach od 4000 do 4700 m n.p.m.",
                Food = "Trawa, liście i zielone części innych roślin.",
                Breeding = "Po ciąży trwającej około 390 dni, rodzi się zazwyczaj jedno młode.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_alpaka.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 153,
                Name = "Wikunia",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Vicugna vicugna",
                Occurance = "Andy od środkowego Peru na północy po północne Chile i Argentynę na południu.",
                LivingEnvritonment = "Stepowe płaskowyża powyżej granicy lasów, na wysokości do 5500 m n.p.m.",
                Food = "Trawa, liście oraz pączki krzewów.",
                Breeding = "Po ciąży trwającej 330-350 dni rodzi się jedno młode.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 153,
                ImagePath = "_wikunie.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 154,
                Name = "Renifer",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Rangifer tarandus",
                Occurance = "Północne rejony Ameryki Północnej i Eurazji.",
                LivingEnvritonment = "Arktyczna tundra i lasotundra.",
                Food = "Porosty, mchy, trawy, liście, pączki drzew i krzewów.",
                Breeding = "Młode rodzą się na przełomie maja i czerwca, po ciąży trwającej 221-237 dni. Laktacja trwa około 6 miesięcy.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 154,
                ImagePath = "_renifer.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 155,
                Name = "Jeleń europejski",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Cervus elaphus",
                Occurance = "Eurazja (część Półwyspu Skandynawskiego, południowa i środkowa Europa, środkowa Azja, północna Afryka).",
                LivingEnvritonment = "Lasy liściaste i mieszane z bogatym podszytem, obrzeża lasu w sąsiedztwie pól, młodniki w borach sosnowych.",
                Food = "Trawy, rośliny zielne, krzewinki, młode pędy, liście drzew i krzewów, grzyby, kora drzew i krzewów, porosty, żołędzie, bukiew.",
                Breeding = "Okres godowy, tzw. rykowisko przypada jesienią. W tym czasie samce konkurują między sobą o samice, a osobniki zwycięskie gromadzą harem złożony z kilku łań. W maju i czerwcu, po ciąży trwającej średnio 235 dni przychodzą na świat  młode.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 155,
                ImagePath = "_jeleneuropejski.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 156,
                Name = "Daniel płowy",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Dama dama",
                Occurance = "Zachodnia i środkowa Europa. Introdukowany na inne kontynenty (Afryka, Ameryka Północna, Ameryka Południowa, Australia). W Polsce najliczniej występuje w zachodniej części kraju.",
                LivingEnvritonment = "Lasy liściaste i mieszane z polanami, w sąsiedztwie łąk, niższe góry, otwarte tereny trawiaste.",
                Food = "Trawy, dwuliścienne rośliny zielne, pędy drzew i krzewów, kora drzew.",
                Breeding = "Okres godowy (bekowisko) przypada na październik i listopad. Podczas rui samce gromadzą wokół siebie łanie i bronią ich przed konkurentami. Ciąża trwa 230-245 dni. Samica rodzi na początku czerwca zwykle jedno, bardzo rzadko dwa młode.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 317,
                ImagePath = "_danielplowy.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 157,
                Name = "Milu",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.ExtinctInWild,
                LatinSpecie = "Elaphurus davidianus",
                Occurance = "Reintrodukowany w Chinach, nad Morzem Żółtym.",
                LivingEnvritonment = "Pierwotny zasięg występowania tych jeleni obejmował prawdopodobnie nizinne i bagniste tereny środkowych i północnych Chin. Obecnie, od roku 1985 zamieszkuje leśne rezerwaty w Chinach (Beijing Milu Park i Dafeng Milu Natural Reserve).",
                Food = "Trawy, zielone części roślin zielnych, liście drzew i krzewów.",
                Breeding = "Okres godowy przypada na czerwiec, kończy się w sierpniu. Po ciąży trwającej 283-287 dni, w marcu lub kwietniu rodzi się jedno młode.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 157,
                ImagePath = "_milu.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 158,
                Name = "Barasinga",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Vulnerable,
                LatinSpecie = "Rucervus duvaucelii",
                Occurance = "Północne Indie.",
                LivingEnvritonment = "Podmokłe tereny trawiaste, unika zwartych lasów.",
                Food = "Trawa, liście, kora i młode pędy.",
                Breeding = "Po ciąży trwającej około 250 dni rodzi się 1 młode, które pozostaje w ukryciu przez 10-15 dni. Matka karmi je do 6 miesiąca życia.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 317,
                ImagePath = "_barasinga.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 159,
                Name = "Mundżak chiński",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Muntiacus reevesi",
                Occurance = "Południowo-wschodnie Chiny, Tajwan. Introdukowany w Anglii na początku XX wieku.",
                LivingEnvritonment = "Lasy i zarośla. Spotykany na wysokości do 3 500 m n.p.m.",
                Food = "Rośliny zielne, liście krzewów, gałązki, owoce.",
                Breeding = "Rozmnaża się w ciągu całego roku. Po ciąży trwającej około 210 dni rodzi się jedno młode, które pozostaje pod opieką matki do 4 miesiąca życia.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 159,
                ImagePath = "_mundzakchinski.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 160,
                Name = "Żyrafa Rothschilda",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Endangered,
                LatinSpecie = "Giraffa camelopardalis rothschildi",
                Occurance = "Afryka: południowy Sudan, północna Uganda, zachodnia Kenia.",
                LivingEnvritonment = "Sawanny, zarośla akacjowe.",
                Food = "Głównie liście roślin z rodzaju Acacia.",
                Breeding = "Po ciąży trwającej około 450 dni rodzi się jedno młode o wadze około 100 kg i wzroście do 2 metrów. Laktacja trwa około 12 miesięcy. Dojrzałość płciową żyrafy osiągają w wieku 4-5 lat.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 160,
                ImagePath = "_zyrafarothschilda.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 161,
                Name = "Antylopa eland",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Taurotragus oryx",
                Occurance = "Afryka równikowa i południowa.",
                LivingEnvritonment = "Zasiedla różne środowiska. Preferuje tereny otwarte. Unika gęstych zarośli i terenów podmokłych. Spotykany do wysokości 4600 m n.p.m.",
                Food = "Głównie gałęzie, pędy i liście krzewów.",
                Breeding = "Po ciąży trwającej 8-9 miesięcy rodzi się młode o wadze do 30 kg. Młoda antylopa szybko przybiera na wadze, osiągając po roku masę do 450 kg.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 161,
                ImagePath = "_eland.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 162,
                Name = "Sitatunga",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Tragelaphus spekei gratus",
                Occurance = "Afryka Środkowa.",
                LivingEnvritonment = "Podmokłe tereny i wilgotne lasy równikowe.",
                Food = "Trawy, roślinność bagienna.",
                Breeding = "Po około 8 – miesięcznej ciąży samica rodzi młode, które może z nią pozostać nawet do narodzin kolejnego potomka.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_sitatunga.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 163,
                Name = "Arui",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Vulnerable,
                LatinSpecie = "Ammotragus lervia",
                Occurance = "Północna Afryka: Maroko, Algieria, Tunezja, Libia, Sudan, Egipt.",
                LivingEnvritonment = "Góry do wysokości 4000 m n.p.m., tereny pustynne.",
                Food = "Dieta zróżnicowana: trawa, gałązki, pędy drzew i krzewów, porosty. Jest odporny na brak wody i bardzo wytrzymały.",
                Breeding = "Ruja przypada na listopad. Po ciąży trwającej 150-165 dni rodzi się 1-2 młode.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 163,
                ImagePath = "_arui.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 164,
                Name = "Takin miszmi",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.Vulnerable,
                LatinSpecie = "Budorcas taxicolor",
                Occurance = "Wschodnia część Himalajów i Wyżyny Tybetańskiej do wysokości 3500 m n.p.m.",
                LivingEnvritonment = "Skaliste obszary, skąpo porośnięte trawami i krzewami, lasy.",
                Food = "Trawy i inne rośliny,  pędy i kora drzew, krzewów.",
                Breeding = "Okres godowy przypada na sierpień i wrzesień. W marcu lub kwietniu samica rodzi zwykle jedno młode po ciąży trwającej około 210 dni.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 164,
                ImagePath = "_takin.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 165,
                Name = "Markur turkmeński",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.NearThreatened,
                LatinSpecie = "Capra falconeri heptneri",
                Occurance = "Góry Azji (południowa Rosja, Afganistan, północne Indie oraz Kaszmir).",
                LivingEnvritonment = "Tereny górskie do wysokości 3600 m n.p.m.",
                Food = "Liście drzew i krzewów, trawa, żołędzie.",
                Breeding = "Po ciąży trwającej około 170 dni rodzą się 1-2 młode, które osiągają  dojrzałość płciową po 3 latach.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 316,
                ImagePath = "_markurturkmenski.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 166,
                Name = "Koza karłowata",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.NotEvaluated,
                LatinSpecie = "Capra hircus hircus",
                Occurance = "Zwierzę udomowione około 10 tysięcy lat temu na terenie Azji Mniejszej, Mezopotamii i Egiptu.",
                LivingEnvritonment = "Hodowana przez człowieka.",
                Food = "Zielone części roślin, gałązki, trawa.",
                Breeding = "Po ciąży trwającej około 140 dni samica rodzi od 2 do 4 koźląt.",
                AnimalDanger = AnimalDanger.None,
               // MapItemId = ,
                ImagePath = "_kozakarlowata.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 167,
                Name = "Antylopa addaks",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.CriticallyEndangered,
                LatinSpecie = "Addax nasomaculatus",
                Occurance = "Środkowy i wschodni Niger, gdzie żyje populacja licząca zaledwie około 500 osobników.",
                LivingEnvritonment = "Obszary pustynne.",
                Food = "Rośliny pustynne, gałązki, pędy drzew i krzewów. Odporny na brak wody.",
                Breeding = "Po ciąży trwającej około 270 dni samica rodzi 1 młode, które karmi przez ponad 6 miesięcy.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 167,
                ImagePath = "_addaks.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 168,
                Name = "Kob śniady",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Kobus ellipsiprymnus",
                Occurance = "Południowo-wschodnia Afryka.",
                LivingEnvritonment = "Sawanny i zarośla w pobliżu wody.",
                Food = "Trawa i liście.",
                Breeding = "Ciąża trwa około 8 miesięcy. Po tym czasie rodzi się jedno młode, które początkowo przebywa w ukryciu, a od 4 tygodnia życia podąża za matką. Okres rozrodu trwa przez cały rok.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 168,
                ImagePath = "_kobsniady.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            modelBuilder.Entity<Animal>().HasData(new Animal
            {
                Id = 169,
                Name = "Kob liczi",
                Group = AnimalGroup.Mammals,
                ConservationStatus = ConservationStatus.LeastConcern,
                LatinSpecie = "Kobus leche",
                Occurance = "Afryka: wschodnia Angola, wschodnia Namibia i północna Botswana.",
                LivingEnvritonment = "Tereny bagniste, położone blisko rzek i jezior.",
                Food = "Trawa oraz rośliny bagienne i wodne.",
                Breeding = "Okres godowy przypada na porę deszczową (grudzień-marzec). Po ciąży trwającej około 8 miesięcy rodzi się jedno młode o wadze około 6 kg. Laktacja trwa do 7 miesięcy.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 169,
                ImagePath = "_kobliczi.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });
            #endregion
        }
    }
}
