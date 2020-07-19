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
                MapItemId = 36,
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
                MapItemId = 37,
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
                MapItemId = 38,
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
                MapItemId = 39,
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
                MapItemId = 40,
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
                MapItemId = 41,
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
                MapItemId = 42,
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
                MapItemId = 43,
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
                MapItemId = 44,
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
                MapItemId = 45,
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
                MapItemId = 46,
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
                MapItemId = 47,
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
                MapItemId = 48,
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
                MapItemId = 49,
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
                MapItemId = 50,
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
                MapItemId = 53,
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
                MapItemId = 54,
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
                MapItemId = 55,
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
                MapItemId = 56,
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
                MapItemId = 57,
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
                MapItemId = 58,
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
                MapItemId = 59,
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
                MapItemId = 60,
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
                MapItemId = 61,
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
                MapItemId = 62,
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
                MapItemId = 63,
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
                MapItemId = 64,
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
                MapItemId = 65,
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
                MapItemId = 67,
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
                MapItemId = 68,
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
                MapItemId = 69,
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
                MapItemId = 70,
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
                MapItemId = 71,
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
                MapItemId = 72,
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
                MapItemId = 73,
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
                MapItemId = 74,
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
                MapItemId = 75,
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
                MapItemId = 76,
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
                MapItemId = 77,
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
                MapItemId = 78,
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
                MapItemId = 79,
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
                MapItemId = 80,
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
                MapItemId = 81,
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
                MapItemId = 82,
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
                MapItemId = 83,
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
                MapItemId = 84,
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
                MapItemId = 85,
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
                MapItemId = 86,
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
                MapItemId = 87,
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
                MapItemId = 88,
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
                MapItemId = 89,
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
                MapItemId = 90,
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
                MapItemId = 91,
                ImagePath = "_berniklakanadyjska.jpg",
                Length = "",
                Weight = "",
                Longevity = ""
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