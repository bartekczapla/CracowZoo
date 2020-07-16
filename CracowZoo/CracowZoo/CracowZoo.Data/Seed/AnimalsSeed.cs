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
                MapItemId = 2,
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
                MapItemId = 3,
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
                MapItemId = 4,
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
                MapItemId = 5,
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
                MapItemId = 6,
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
                MapItemId = 7,
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
                MapItemId = 8,
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
                MapItemId = 9,
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
                MapItemId = 10,
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
                MapItemId = 11,
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
                MapItemId = 12,
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
                MapItemId = 13,
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
                MapItemId = 14,
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
                MapItemId = 15,
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
                MapItemId = 16,
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
                MapItemId = 17,
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
                MapItemId = 18,
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
                MapItemId = 19,
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
                MapItemId = 20,
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
                MapItemId = 21,
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
                MapItemId = 22,
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
                MapItemId = 23,
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
                MapItemId = 24,
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
                MapItemId = 25,
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
                MapItemId = 26,
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
                MapItemId = 27,
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
                MapItemId = 28,
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
                MapItemId = 29,
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
                MapItemId = 30,
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
                MapItemId = 32,
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
                MapItemId = 33,
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
                MapItemId = 34,
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
                MapItemId = 35,
                ImagePath = "_perlicasepia.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
            });

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 36,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 36,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 37,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 37,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 38,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 38,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 39,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 39,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 40,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 40,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 41,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 41,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 42,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 42,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 43,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 43,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 44,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 44,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 45,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 45,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 46,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 46,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 47,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 47,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 48,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 48,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 49,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 49,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 50,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 50,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 51,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 51,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 52,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 52,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 53,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 53,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 54,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 54,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 55,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 55,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 56,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 56,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 57,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 57,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 58,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 58,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 59,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 59,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 60,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 60,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 61,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 61,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 62,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 62,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 63,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 63,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 64,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 64,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 65,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 65,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 66,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 66,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 67,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 67,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 68,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 68,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 69,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 69,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 70,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 70,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 71,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 71,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 72,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 72,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 73,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 73,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 74,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 74,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 75,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 75,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 76,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 76,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 77,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 77,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 78,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 78,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 79,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 79,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 80,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 80,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 81,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 81,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 82,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 82,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 83,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 83,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 84,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 84,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 85,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 85,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 86,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 86,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 87,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 87,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 88,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 88,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 89,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 89,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 90,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 90,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

            //modelBuilder.Entity<Animal>().HasData(new Animal
            //{
            //    Id = 91,
            //    Name = "",
            //    Group = AnimalGroup.Birds,
            //    ConservationStatus = ConservationStatus.LeastConcern,
            //    LatinSpecie = "",
            //    Occurance = "",
            //    LivingEnvritonment = "",
            //    Food = "",
            //    Breeding = "",
            //    AnimalDanger = AnimalDanger.None,
            //    MapItemId = 91,
            //    ImagePath = ".jpg",
            //    Length = "",
            //    Weight = "",
            //    Longevity = ""
            //});

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
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Petaurus breviceps",
                Occurance = "Australia, Nowa Gwinea.",
                LivingEnvritonment = "Lasy deszczowe, plantacje orzechów kokosowych, zarośla.",
                Food = "Małe bezkręgowce oraz soki roślinne i owoce.",
                Breeding = "Ciąża trwa 21 dni. Samica rodzi 2 - 3 młode.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 93,
                ImagePath = "_lotopalankamala.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Chaetophractus villosus",
                Occurance = "Argentyna, Boliwia, Chile i Urugwaj.",
                LivingEnvritonment = "Zamieszkuje łąki, lasy, sawanny, tereny rolnicze, pampy - typowe dla Ameryki Południowej środowisko o charakterze stepowym.",
                Food = "Głównie bezkręgowce, a także małe kręgowce, owoce, padlina.",
                Breeding = "Po ciąży trwającej 2 miesiące rodzą się najczęściej 2 młode.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 96,
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
                ConservationStatus = ConservationStatus.Normal,
                LatinSpecie = "Choloepus didactylus",
                Occurance = "Wenezuela, Gujana i północna Brazylia.",
                LivingEnvritonment = "Wilgotne lasy nizinne.",
                Food = "Liście, pędy roślin i owoce.",
                Breeding = "Ciąża trwa około 10 miesięcy. W miocie tylko jedno młode, które przyczepia się do włosów na piersi i brzuchu matki.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 97,
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
                ConservationStatus = ConservationStatus.Vulnerable,
                LatinSpecie = "Eulemur rubriventer",
                Occurance = "Madagaskar.",
                LivingEnvritonment = "Lasy deszczowe.",
                Food = "Owoce, pędy, bezkręgowce, drobne kręgowce.",
                Breeding = "Po ciąży trwającej 120 dni samica rodzi jedno młode, które jest noszone przez rodziców do około 35 dnia życia. Później opiekuje się nim głównie samiec. Matka karmi młode do piątego miesiąca życia.",
                AnimalDanger = AnimalDanger.None,
                MapItemId = 98,
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
                MapItemId = 99,
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
                MapItemId = 100,
                ImagePath = "_warirudy.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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
//                ImagePath = ".jpg",
//                Length = "",
//                Weight = "",
//                SocialLife = "",
//                Longevity = "",
//                Incubation = "",
//                NumberOfCubs = ""
//            });