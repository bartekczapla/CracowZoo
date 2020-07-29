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
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 306,
                Description = "Nandu posiadają doskonały wzrok, dobrze pływają i szybko biegają (mogą przekraczać prędkość 40 km/godz).",
                AnimalId = 32
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 307,
                Description = "Długie skrzydła wykorzystują do gwałtownej zmiany kierunku.",
                AnimalId = 32
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 308,
                Description = "Jest drugim po strusiu afrykańskim największym żyjącym ptakiem.",
                AnimalId = 33
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 309,
                Description = "Biega bardzo szybko, osiągając prędkość do 50 km/h. W razie zagrożenia broni się uderzając napastnika nogami. Potrafi pływać. Jest hodowany dla mięsa, oleju i skór.",
                AnimalId = 33
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 310,
                Description = "Prowadzi naziemny tryb życia, w sytuacji zagrożenia częściej ucieka pieszo niż fruwa.",
                AnimalId = 34
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 311,
                Description = "Jest wytrwałym biegaczem. Poza sezonem lęgowym tworzy stada liczące około 25 osobników. W wielu krajach jest hodowana jako ptak udomowiony dla smacznego mięsa i jaj.",
                AnimalId = 34
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 312,
                Description = "Największa perlica.",
                AnimalId = 35
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 313,
                Description = "Ze względu na to, że głowa i szyja tego ptaka pozbawione są piór perlica ta została nazwana sępią.",
                AnimalId = 35
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 314,
                Description = "Poza okresem lęgowym ptaki te łączą się w niewielkie stada.",
                AnimalId = 36
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 315,
                Description = "Uszak siwy jest najpospolitszym gatunkiem spośród wszystkich gatunków uszaków utrzymywanych przez w hodowców.",
                AnimalId = 36
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 316,
                Description = "Olśniak himalajski to narodowy ptak i symbol Nepalu.",
                AnimalId = 37
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 317,
                Description = "Jego łacińska nazwa upamiętnia Lady Mary Impey, małżonkę prezesa brytyjskiego sądu najwyższego Bengalu, sir Elijaha Impey.",
                AnimalId = 37
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 318,
                Description = "Jest to słabo poznany gatunek.",
                AnimalId = 38
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 319,
                Description = "Zawdzięcza swoją nazwę francuskiemu zoologowi Alfonsowi Milne-Edwardsowi.",
                AnimalId = 38
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 320,
                Description = "Ptak sporadycznie obserwowany na terenie Polski.",
                AnimalId = 39
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 321,
                Description = "Jest to gatunek sporadycznie obserwowany na terenie naszego kraju.",
                AnimalId = 40
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 322,
                Description = "Pod koniec XVIII wieku liczebność tego gatunku wynosiła ponad 25 tysięcy sztuk, jednak na skutek masowych polowań zmniejszyła się, osiągając w roku 1952 zaledwie 30 osobników. Dzięki hodowli w ośrodkach zamkniętych gatunek został uratowany przed zagładą.",
                AnimalId = 41
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 323,
                Description = "W Europie odnotowano przypadki pomyślnego gniazdowania łabędzi czarnych zbiegłych z niewoli. Pod względem wymagań środowiskowych jest to gatunek zbliżony do łabędzia niemego.",
                AnimalId = 42
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 324,
                Description = "Gatunek o szerokim zasięgu występowania.",
                AnimalId = 43
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 325,
                Description = "Samiec w upierzeniu godowym różni się od samicy obecnością czarnej obroży na szyi. Samica jest ponadto nieco mniejsza.",
                AnimalId = 44
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 326,
                Description = "Ptaki obu płci wyglądają podobnie, u samca pojawia się w okresie letnim czerwona, guzowata narośl u nasady dzioba.",
                AnimalId = 45
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 327,
                Description = "Hodowana jako ptak ozdobny. Z powodu oryginalnego upierzenia stała się jednym z ulubionych ptaków, utrzymywanych w parkach w wielu krajach Europy.",
                AnimalId = 46
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 328,
                Description = "Kaczka ta nazywana jest w Ameryce Północnej kaczką leśną. Jej nazwa pochodzi od stanu Karolina w USA, gdzie żyje najliczniejsza populacja. Z piór karolinki wytwarzano przynęty na pstrągi, dlatego też na przełomie XIX i XX wieku była gatunkiem zagrożonym.",
                AnimalId = 47
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 329,
                Description = "Żyje w parach lub małych stadach. U gatunku tego występuje wyraźny dymorfizm płciowy. Samce posiadają nad dziobem charakterystyczny, okrągły wyrostek, który znacznie powiększa się przed okresem lęgowym.",
                AnimalId = 48
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 330,
                Description = "W Polsce jest nielicznym ptakiem lęgowym.",
                AnimalId = 49
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 331,
                Description = "W Polsce jest nielicznym ptakiem lęgowym. Gnieździ się na Mazurach, w pozostałych rejonach kraju bardzo rzadka.",
                AnimalId = 50
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 332,
                Description = "Gatunek ten tworzy niezbyt liczne kolonie.",
                AnimalId = 51
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 333,
                Description = "Dziób flaminga jest mocno zakrzywiony. Po zanurzeniu w wodzie płaska szczęka górna znajduje się u dołu, a znacznie masywniejsza żuchwa u góry. Pompującymi ruchami gardła ptak wciąga wodę końcem dzioba i wyciska ją u jego nasady. Grzebyki rogowych blaszek na brzegach dzioba działają jak filtry, odcedzając pokarm.",
                AnimalId = 52
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 334,
                Description = "Już w sierpniu i wrześniu bociany gromadzą się w duże stada, liczące nawet około 50 osobników. Zgromadzenia te nazywane „sejmikami bocianimi” poprzedzają wędrówkę z letnich lęgowisk na zimowiska w Afryce.",
                AnimalId = 53
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 335,
                Description = "W naszym kraju jest nielicznym ptakiem lęgowym. Unika sąsiedztwa człowieka, jest dużo bardziej płochliwy od bociana białego",
                AnimalId = 54
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 336,
                Description = "Potężny krewniak naszego bociana, osiągający 150 cm wzrostu i do 9 kg masy ciała. Rozpiętość skrzydeł u tego gatunku dochodzi do 3 metrów.",
                AnimalId = 55
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 337,
                Description = "Dziób ibisa – cienki, długi i łukowato zagięty w dół jest narzędziem służącym do sondowania miękkich mułów lub wody w poszukiwaniu pożywienia.",
                AnimalId = 56
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 338,
                Description = "Gatunek rzadko eksponowany w ogrodach zoologicznych. W Polsce można go zobaczyć tylko w naszym Zoo.",
                AnimalId = 57
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 339,
                Description = "Gatunek łatwy do oznaczenia. Od innych warzęch o białym upierzeniu różni się różowymi nogami i różową skórą u nasady dzioba.",
                AnimalId = 58
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 340,
                Description = "Na początku XX wieku panowała moda na kapelusze z ozdobnymi piórami czapli nadobnych. Spowodowało to zniszczenie wielu kolonii i śmierć ptaków, od których pozyskiwano pióra.",
                AnimalId = 59
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 341,
                Description = "Dziób pelikana ma bardzo charakterystyczną budowę. Jego dolna część ma twarde brzegi, między którymi rozciąga się płat wiotkiej skóry. Kiedy ptak otwiera dziób pod wodą, skóra rozciąga się niczym wielka kieszeń, w którą pelikan łowi ryby. Może ona pomieścić około 10 litrów wody.",
                AnimalId = 60
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 342,
                Description = "Największy ptak drapieżny świata o rozpiętości skrzydeł do 3, 2 m i wadze do 15 kg.",
                AnimalId = 61
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 343,
                Description = "Regularne przychówki od tego gatunku są wielkim sukcesem hodowlanym naszego Zoo.",
                AnimalId = 61
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 344,
                Description = "Przypuszcza się, że ptak ten mógł w XIX wieku gnieździć się w Tatrach.",
                AnimalId = 62
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 345,
                Description = "W Polsce gnieździ się zaledwie około 30 par orłów przednich. Jest to gatunek objęty ścisłą ochroną. Wokół orlich gniazd obowiązuje strefa ochronna.",
                AnimalId = 63
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 346,
                Description = "Orły cesarskie żyjące w Europie są ptakami wędrownymi, zimują w Afryce i Azji. Do Polski zalatują wyjątkowo.",
                AnimalId = 64
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 347,
                Description = "Podobizna tego ptaka stanowi element godła państwowego Ugandy.",
                AnimalId = 65
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 348,
                Description = "Jest to drugi pod względem wielkości przedstawiciel rodziny żurawiowatych.",
                AnimalId = 66
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 349,
                Description = "Gatunek chętnie hodowany w domach jako ptak ozdobny. W naturze doskonale przystosowany do gorącego i suchego klimatu wnętrza kontynentu australijskiego.",
                AnimalId = 67
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 350,
                Description = "Największy z żyjących gołębi. Jest ptakiem naziemnym, w razie niebezpieczeństwa chroni się na drzewach.",
                AnimalId = 68
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 351,
                Description = "Wyróżniono 20 podgatunków lorysy górskiej, różniących się ubarwieniem.",
                AnimalId = 69
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 352,
                Description = "Żyje w stadach. Może wyrządzać znaczne szkody na plantacjach ryżu.",
                AnimalId = 70
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 353,
                Description = "Zdarzają się barwne mutacje upierzenia – osobniki pozbawione żółtego barwnika są niebieskie, a ptaki nie mające barwnika niebieskiego – żółte.",
                AnimalId = 71
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 354,
                Description = "W niewoli szybko się oswaja. Doskonale potrafi naśladować ludzką mowę.",
                AnimalId = 72
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 355,
                Description = "Żyją w małych stadach. Oswojone ararauny trzymali w swoich wioskach Inkowie. Obecnie ararauna należy do najbardziej popularnych ar w hodowlach.",
                AnimalId = 73
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 356,
                Description = "Ptaki te coraz częściej spotykane są w pobliżu siedzib ludzkich, gdzie wyrządzają szkody na plantacjach kukurydzy, w sadach owocowych i uprawach kawy.",
                AnimalId = 74
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 357,
                Description = "Papuga ta jest znana w Europie od początku XVII wieku. Trzymana w domach oswojona ara zielona jest wyjątkowo łagodna, skora do zabawy i pieszczot. Cierpliwie uczona, potrafi naśladować mowę człowieka.",
                AnimalId = 75
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 358,
                Description = "Jest gatunkiem dobrze przystosowanym do chłodnego klimatu.",
                AnimalId = 76
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 359,
                Description = "Wyhodowano kilka odmian kolorystycznych.",
                AnimalId = 76
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 360,
                Description = "W hodowli ptaki te szybko się oswajają. Są bardzo hałaśliwe.",
                AnimalId = 77
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 361,
                Description = "Amazonka jest papugą długowieczną. Niektóre osobniki potrafią znakomicie naśladować ludzką mowę.",
                AnimalId = 78
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 362,
                Description = "To największa sowa europejska. Jest monogamiczna, pary przebywają razem przez całe życie.",
                AnimalId = 79
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 363,
                Description = "W gatunku tego występuje dymorfizm płciowy – samiec jest niemal całkowicie biało ubarwiony, samica jest większa, obficie cętkowana. W Polsce bardzo rzadko obserwowana na północy kraju.",
                AnimalId = 80
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 364,
                Description = "Puszczyk jest najpospolitszą sową Palearktyki. Prowadzi najbardziej nocny tryb życia spośród wszystkich sów Europy.",
                AnimalId = 81
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 365,
                Description = "W Polsce po roku 1945 gatunek ten pojawiał się nieregularnie na terenie Puszczy Białowieskiej. Po roku 2010 stwierdzono jego lęgi na Polesiu Lubelskim.",
                AnimalId = 82
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 366,
                Description = "Nasz ogród uczestniczył w programie reintrodukcji puszczyka uralskiego, realizowanym od roku 2009 w północno-wschodnich Alpach. Celem było przywrócenie tego gatunku na obszary dawnego występowania.",
                AnimalId = 83
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 367,
                Description = "Jest największym zimorodkiem. Wydaje bardzo charakterystyczny głos przypominający ludzki śmiech.",
                AnimalId = 84
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 368,
                Description = "Ptak ten potrafi znakomicie naśladować różne dźwięki, również mowę ludzką.",
                AnimalId = 85
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 369,
                Description = "Błyszczak purpurowy jest lśniącym krewniakiem szpaka.",
                AnimalId = 86
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 370,
                Description = "Wikłacze gromadzą się w duże, hałaśliwe stada. Nazwa tego ptaka związana jest ze sposobem, w jaki buduje on swoje kunsztowne gniazdo.",
                AnimalId = 87
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 371,
                Description = "Bażant ten jest idealnym ptakiem dla początkującego hodowcy.",
                AnimalId = 88
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 372,
                Description = "Jest to narodowy ptak Indii.",
                AnimalId = 89
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 373,
                Description = "Pawie były hodowane już w czasach egipskich faraonów i Cesarstwa Rzymskiego.",
                AnimalId = 89
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 374,
                Description = "Zwyczaj gniazdowania na drzewach, charakterystyczny dla tragopanów jest niespotykany u innych przedstawicieli rodziny bażantowatych.",
                AnimalId = 90
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 375,
                Description = "Ptak obserwowany na terenie Polski.",
                AnimalId = 91
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 376,
                Description = "Zalatuje, zimuje i sporadycznie gniazduje w naszym kraju. Bernikla kanadyjska uznawana jest za jeden z najgroźniejszych gatunków obcych w Europie ze względu na rozszerzający się zasięg i zagrożenie dla rodzimych, europejskich gatunków gęsi.",
                AnimalId = 91
            });
            #endregion

            #region SSAKI 92-169

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
                Description = "Charakterystyczną cechą tego zwierzęcia jest występowanie fałdów skórnych, znajdujących się po bokach ciała pomiędzy przednimi, a tylnymi kończynami.",
                AnimalId = 93
            });

            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 403,
                Description = "Dzięki temu powstaje powierzchnia nośna, która pozwala lotopałance przemieszczać się lotem ślizgowym na odległość do około 50 metrów",
                AnimalId = 93
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 404,
                Description = "W naszym ZOO regularnie się rozmnaża.",
                AnimalId = 94
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 405,
                Description = "Poczucie bezpieczeństwa w torbie matki jest tak mocne, że w razie niebezpieczeństwa nawet już wyrośnięty, prawie dorosły osobnik szuka tam schronienia.",
                AnimalId = 94
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 406,
                Description = "Jest zwierzęciem doskonale przystosowanym do kopania podziemnych korytarzy.",
                AnimalId = 96
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 407,
                Description = "Aktywny głównie nocą.",
                AnimalId = 96
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 408,
                Description = "Jego przednie, dwupalczaste kończyny zakończone są potężnymi pazurami.",
                AnimalId = 97
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 409,
                Description = "Długie, wełniste futro leniwców żyjących na wolności porośnięte jest glonami, a pomiędzy włosami bytują ćmy i chrząszcze.",
                AnimalId = 97
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 410,
                Description = "Żyje w grupach liczących 2 do 6 osobników.",
                AnimalId = 98
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 411,
                Description = "Grupa zajmuje terytorium około 20 ha.",
                AnimalId = 98
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 412,
                Description = "Lemur katta jest jedynym lemurem prowadzącym naziemny tryb życia.",
                AnimalId = 99
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 413,
                Description = "Jak wszystkie lemury należy do małpiatek – najprymitywniejszej grupy zwierząt naczelnych.",
                AnimalId = 99
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 414,
                Description = "Jest aktywny w dzień, co jest cechą rzadko spotykaną u lemurowatych.",
                AnimalId = 99
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 415,
                Description = "Żyje w grupach liczących od 5 do 20 osobników.",
                AnimalId = 99
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 416,
                Description = "Największy spośród lemurów.",
                AnimalId = 100
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 417,
                Description = "Dawniej czczony jako zwierzę święte.",
                AnimalId = 100
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 418,
                Description = "Jest aktywny nocą.",
                AnimalId = 100
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 419,
                Description = "Żyje w grupach liczących 2 do 5 osobników.",
                AnimalId = 100
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 420,
                Description = "Prowadzą nocny tryb życia, dzień przesypiają zwinięte w kłębek.",
                AnimalId = 101
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 421,
                Description = "Żyją w luźnych stadach złożonych z 1 samca i kilku samic. Mają doskonale rozwinięty zmysł wzroku i węchu.",
                AnimalId = 101
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 422,
                Description = "Doskonale wspina się po drzewach.",
                AnimalId = 102
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 423,
                Description = "Żyje w grupach rodzinnych liczących zwykle od 8 do 10 osobników.",
                AnimalId = 102
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 424,
                Description = "Prawie całe swoje życie spędzają na drzewach.",
                AnimalId = 103
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 425,
                Description = "Prowadzą dzienny tryb życia.",
                AnimalId = 103
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 426,
                Description = "Tworzą grupy złożone z 2-8 osobników.",
                AnimalId = 103
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 427,
                Description = "Typowa rodzina składa się z rodziców i ich potomstwa.",
                AnimalId = 103
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 428,
                Description = "Prowadzi nadrzewny tryb życia.",
                AnimalId = 104
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 429,
                Description = "Jest aktywna w ciągu dnia.",
                AnimalId = 104
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 430,
                Description = "Żyje w grupach rodzinnych",
                AnimalId = 104
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 431,
                Description = "Małpka sajmiri znana jest z filmu o Pipi Lansztrung.",
                AnimalId = 105
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 432,
                Description = "Jej inna nazwa – „trupia główka” pochodzi od charakterystycznego rysunku na pysku, przypominającego ludzką czaszkę.",
                AnimalId = 105
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 433,
                Description = "Małpy te żyją w stadach liczących od kilku do kilkunastu osobników.",
                AnimalId = 106
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 434,
                Description = "Mangaby czarne porozumiewają się między sobą wykorzystując mimikę twarzy.",
                AnimalId = 106
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 435,
                Description = "Żyje w grupach rodzinnych, liczących do 20 osobników, którym przewodzi doświadczony samiec.",
                AnimalId = 107
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 436,
                Description = "Czasem kilka takich grup łączy się w duże, luźne zgrupowania.",
                AnimalId = 107
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 437,
                Description = "Gerezy prowadzą dzienny tryb życia.",
                AnimalId = 108
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 438,
                Description = "Posiadają tylko cztery palce u każdej ręki.",
                AnimalId = 108
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 439,
                Description = "Kciuk jest nieobecny, lub zastąpiony przez niewielki paliczkowy guzek, co może być formą przystosowania do sprawniejszego poruszania się po drzewach.",
                AnimalId = 108
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 440,
                Description = "Małpy te występują w dwóch odmianach barwnych – czarnej i pomarańczowej.",
                AnimalId = 109
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 441,
                Description = "Żyją w grupach złożonych z jednego samca i kilku samic z młodymi.",
                AnimalId = 109
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 442,
                Description = "Młode samce tworzą grupy kawalerskie lub wędrują samotnie.",
                AnimalId = 109
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 443,
                Description = "Doskonale wspina się i skacze.",
                AnimalId = 110
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 444,
                Description = "Porusza się na zasadzie brachiacji – ruchami wahadłowymi przenosi ciężar ciała z jednej ręki na drugą.",
                AnimalId = 110
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 445,
                Description = "Żyje w grupach rodzinnych, liczących do 6 osobników, złożonych z rodziców i młodych",
                AnimalId = 110
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 446,
                Description = "Żyje we wspólnotach składających się z kilkudziesięciu osobników, podzielonych na luźne grupy o różnej wielkości i strukturze zmieniającej się w czasie.",
                AnimalId = 111
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 447,
                Description = "Znaczny rozwój mózgu pozwala szympansom prowadzić bogate życie społeczne i umożliwia im posługiwanie się narzędziami.",
                AnimalId = 111
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 448,
                Description = "Prowadzi nadrzewny tryb życia.",
                AnimalId = 112
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 449,
                Description = "Jest aktywna w ciągu dnia.",
                AnimalId = 112
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 450,
                Description = "Jego ciało pokryte jest grubymi, szczeciniastymi włosami, które na plecach i ogonie przekształcone są w kolce.",
                AnimalId = 113
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 451,
                Description = "Zagrożony, stroszy je, odwraca się do napastnika tyłem i skutecznie broni się miotając ogonem.",
                AnimalId = 113
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 452,
                Description = "Jest aktywny nocą.",
                AnimalId = 113
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 453,
                Description = "Posługuje się echolokacją.",
                AnimalId = 114
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 454,
                Description = "Żyje w koloniach.",
                AnimalId = 114
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 455,
                Description = "Jego zmysły wzroku, słuchu i węchu są doskonale rozwinięte.",
                AnimalId = 115
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 456,
                Description = "W dawnych czasach, w Indiach i na Bliskim Wschodzie towarzyszył człowiekowi w polowaniach na zwierzynę płową.",
                AnimalId = 115
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 457,
                Description = "Po turecku słowo karakulak oznacza czarne ucho i stąd właśnie wywodzi się nazwa gatunku. Kot ten zwany jest również rysiem stepowym ze względu na obecność charakterystycznych pędzelków na końcach uszu.",
                AnimalId = 115
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 458,
                Description = "Chaus zwany kotem bagiennym, błotnym lub trzcinowym został uwieczniony obok kota nubijskiego na ścianach świątyń i papirusach przez starożytnych Egipcjan.",
                AnimalId = 116
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 459,
                Description = "Angielska nazwa tego kota, „Pallas cat”, pochodzi od nazwiska niemieckiego przyrodnika Petera Pallasa, który pierwszy opisał ten gatunek.",
                AnimalId = 117
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 460,
                Description = "Manul prowadzi nocny tryb życia.",
                AnimalId = 117
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 461,
                Description = "W ciągu dnia ukrywa się w norach innych zwierząt, małych jaskiniach i rozpadlinach skalnych.",
                AnimalId = 117
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 462,
                Description = "Żbik przypomina burego kota domowego, jest jednak od niego większy i masywniej zbudowany.",
                AnimalId = 118
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 463,
                Description = "Jest samotnikiem aktywnym nocą.",
                AnimalId = 118
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 464,
                Description = "Doskonale wspina się po drzewach.",
                AnimalId = 118
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 465,
                Description = "Prowadzi nocny tryb życia, dzień przesypia w gęstych zaroślach.",
                AnimalId = 119
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 466,
                Description = "Doskonale wspina się po drzewach i świetnie pływa.",
                AnimalId = 119
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 467,
                Description = "Gatunek samotniczy, prowadzi nocny tryb życia.",
                AnimalId = 119
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 468,
                Description = "Żyje do 15 lat.",
                AnimalId = 119
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 469,
                Description = "Niektóre plemiona Beduinów uważają kota arabskiego za zwierzę święte.",
                AnimalId = 120
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 470,
                Description = "Prowadzi nocny tryb życia, dzień przesypia w gęstych zaroślach.",
                AnimalId = 121
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 471,
                Description = "Doskonale wspina się po drzewach, dobrze pływa.",
                AnimalId = 121
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 472,
                Description = "Ma niezwykle czuły słuch.",
                AnimalId = 122
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 473,
                Description = "Prowadzi samotniczy tryb życia.",
                AnimalId = 122
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 474,
                Description = "Dobrze wspina się po drzewach i doskonale skacze. Długość skoków dochodzi do 5 m. Za wzlatującymi ptakami potrafi skoczyć do wysokości 2 m.",
                AnimalId = 123
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 475,
                Description = "Ryś jest aktywny głównie o zmroku i nocą, a w ciągu dnia śpi i odpoczywa.",
                AnimalId = 123
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 476,
                Description = "Z uwagi na podobieństwo do niektórych przedstawicieli rodziny łasicowatych nazywany jest „kotem łasicowatym”.",
                AnimalId = 124
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 477,
                Description = "Lwy azjatyckie są nieco mniejsze od swoich afrykańskich kuzynów.",
                AnimalId = 125
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 478,
                Description = "Jest świetnym pływakiem. Od lamparta odróżnia go krępa budowa ciała, krótszy ogon i obecność plamek wewnątrz rozetek na tułowiu.",
                AnimalId = 126
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 479,
                Description = "Znakomicie pływa i wspina się na drzewa.",
                AnimalId = 127
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 480,
                Description = "Tygrys amurski jest największym ze współcześnie żyjących kotów: osiąga masę do 320 kg, długość ciała do 2,5 m.",
                AnimalId = 128
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 481,
                Description = "Posiada najjaśniejsze i najdłuższe futro spośród tygrysów.",
                AnimalId = 128
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 482,
                Description = "Prowadzi samotniczy tryb życia.",
                AnimalId = 128
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 483,
                Description = "Jeden osobnik zajmuje terytorium do 1000 km2.",
                AnimalId = 128
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 484,
                Description = "Ubarwienie futra doskonale maskuje ją wśród skał i śniegu, zwiększając szansę na skuteczne polowanie.",
                AnimalId = 129
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 485,
                Description = "Jest przedstawicielem rodziny łasz. Prowadzi nocny tryb życia.",
                AnimalId = 130
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 486,
                Description = "Znakomicie wspina się na drzewa, dobrze pływa.",
                AnimalId = 130
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 487,
                Description = "Jest to przedstawiciel rodziny mangustowatych.",
                AnimalId = 131
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 488,
                Description = "Drapieżniki te żyją w grupach rodzinnych, w których panuje hierarchia.",
                AnimalId = 131
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 489,
                Description = "Nad bezpieczeństwem grupy czuwa osobnik, który wypatruje niebezpieczeństwa i na widok zagrożenia daje pobratymcom głośny sygnał do ucieczki.",
                AnimalId = 131
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 490,
                Description = "Cała kolonia znika wówczas pod ziemią w bezpiecznym systemie jam i korytarzy.",
                AnimalId = 131
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 491,
                Description = "Z uwagi na podobieństwo do lisa, Indianie nazwali go „dużym lisem”.",
                AnimalId = 132
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 492,
                Description = "Nazwa wilk grzywiasty pochodzi od charakterystycznej grzywy, którą zwierzę stroszy w chwili zaniepokojenia.",
                AnimalId = 132
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 493,
                Description = "Posiadają od 46 do 50 drobnych zębów (najwięcej spośród wszystkich ssaków).",
                AnimalId = 133
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 494,
                Description = "Żyją w parach lub grupach rodzinnych.",
                AnimalId = 133
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 495,
                Description = "Najmniejszy gatunek spośród psowatych. Wyjątkowo długie uszy służą do regulacji temperatury ciała w niekorzystnych warunkach panujących na pustyni oraz znakomicie wspomagają lokalizację zdobyczy. Posiada owłosione podeszwy, umożliwiające poruszanie się po rozgrzanym piasku.",
                AnimalId = 134
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 496,
                Description = "Uchatki są najsprawniej poruszającymi się na lądzie płetwonogimi. Posiadają niewielkie małżowiny uszne, od obecności których pochodzi nazwa zwierzęcia.",
                AnimalId = 135
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 497,
                Description = "Inna nazwa – lew morski uzasadniona jest charakterystycznym, grzmiącym rykiem wydawanym przez samce i grzywą, porastającą ich grzbiet i kark.Pod wodą uchatki przebywają zwykle około 5 minut, nurkują na głębokość do 100 metrów.",
                AnimalId = 135
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 498,
                Description = "Drapieżniki te mają dobrze rozwinięty zmysł wzroku, słuchu i węchu.",
                AnimalId = 136
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 499,
                Description = "Są samotnikami, za wyjątkiem samic wychowujących młode",
                AnimalId = 136
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 500,
                Description = "Przedstawiciel rodziny łasicowatych.",
                AnimalId = 137
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 501,
                Description = "Prowadzi nocny tryb życia.",
                AnimalId = 137
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 502,
                Description = "Znakomicie porusza się wśród gałęzi drzew.",
                AnimalId = 137
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 503,
                Description = "Borsuki żyją w grupach rodzinnych, których członkowie są blisko spokrewnieni.",
                AnimalId = 138
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 504,
                Description = "Każda grupa zamieszkuje terytorium, w obrębie którego znajdują się nory i wydeptane ścieżki, uczęszczane przez te zwierzęta.",
                AnimalId = 138
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 505,
                Description = "Jest to przedstawiciel rodziny szopowatych. Cechą charakterystyczną tego gatunku jest prążkowany ogon.",
                AnimalId = 139
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 506,
                Description = "Grupy liczące zwykle 5-50 osobników złożone są z samic i ich młodych. Samce dołączają do grupy w okresie godowym.",
                AnimalId = 139
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 507,
                Description = "Aktywny w dzień.",
                AnimalId = 139
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 508,
                Description = "Aktywny nocą, dzień spędza w kryjówkach.",
                AnimalId = 140
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 509,
                Description = "Dobrze wspina się na drzewa, bardzo dobrze pływa.",
                AnimalId = 140
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 510,
                Description = "Poza okresem godowym żyje samotnie.",
                AnimalId = 140
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 511,
                Description = "Jedyny przedstawiciel rodziny pandowatych.",
                AnimalId = 141
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 512,
                Description = "Żyje w małych grupach rodzinnych.",
                AnimalId = 141
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 513,
                Description = "Naturalnym wrogiem tego zwierzęcia jest pantera śnieżna.",
                AnimalId = 141
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 514,
                Description = "Osioł został udomowiony już w starożytnym Egipcie.",
                AnimalId = 142
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 515,
                Description = "Jest bardzo wytrzymały i mało wymagający. Ceniony jako zwierzę juczne, pociągowe i wierzchowe.",
                AnimalId = 142
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 516,
                Description = "Pochodzi od dzikiego osła, żyjącego w północnej Afryce.",
                AnimalId = 142
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 517,
                Description = "W niebezpieczeństwie zebra ratuje się ucieczką rozwijając prędkość do 65 km/h.",
                AnimalId = 143
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 518,
                Description = "Naturalnymi wrogami zebr są lwy, lamparty, gepardy i hieny.",
                AnimalId = 143
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 519,
                Description = "Zwierzę to zostało nazwane zebrą Chapmana na cześć przyrodnika Jamesa Chapmana.",
                AnimalId = 143
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 520,
                Description = "W Anglii wykorzystywano je do pracy w kopalniach węgla.",
                AnimalId = 144
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 521,
                Description = "Obecnie służą dzieciom do jazdy wierzchem, ciągną małe bryczki, są także użytkowane jako zwierzęta juczne.",
                AnimalId = 144
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 522,
                Description = "Konie Przewalskiego to dzicy przodkowie konia domowego. Po raz ostatni obserwowano je na wolności na pograniczu Mongolii i Chin w roku 1968. Zanim wyginęły w naturze, odłowiono wiele osobników i umieszczono w ogrodach zoologicznych na świecie. Dzięki programowi reintrodukcji prowadzonemu w Mongolii, konie te powróciły na wolność.",
                AnimalId = 145
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 523,
                Description = "Jest to przedstawiciel rodziny koniowatych, blisko spokrewniony z kiangiem i onagerem. Posiada cechy typowe dla koni i osłów.",
                AnimalId = 146
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 524,
                Description = "Górna warga wraz z nosem tworzą krótką, silnie umięśnioną trąbę.",
                AnimalId = 147
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 525,
                Description = "Są świetnie przystosowane do pokonywania gęstych zarośli – mają gładką skórę, szczeciniastą sierść, klinowatą głowę i mocno umięśnione nogi.",
                AnimalId = 147
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 526,
                Description = "Tapir uważany jest przez wielu przyrodników za „żywą skamielinę”, ponieważ prawie nie różni się od swoich przodków występujących licznie na ziemi w środkowym trzeciorzędzie.",
                AnimalId = 147
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 527,
                Description = "Świnkę tą nazwano zwisłobrzuchą ze względu na fakt, że brzuch zwierzęcia niemal dotyka ziemi. Inaczej świnia ta nazywana jest wietnamską",
                AnimalId = 148
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 528,
                Description = "Hipopotam karłowaty pomimo niewielkich rozmiarów posiada groźną broń – duże kły, którymi może zadawać bardzo głębokie rany.",
                AnimalId = 149
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 529,
                Description = "Prowadzi nocny tryb życia przebywając w ciągu dnia w ukryciu w pobliżu wody. Żyje samotnie, z wyjątkiem okresu rui i opieki nad młodym.",
                AnimalId = 149
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 530,
                Description = "Jest wykorzystywany jako zwierzę juczne i wierzchowe, rzadziej użytkowany jako siła pociągowa, dostarcza także mleka, mięsa, wełny i skóry.",
                AnimalId = 150
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 531,
                Description = "Wielbłąd dwugarbny porusza się inochodem – to znaczy, że nogi jednej strony ciała poruszają się jednocześnie.",
                AnimalId = 150
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 532,
                Description = "Żyje w stadach, liczących do około 30 osobników, prowadzonych przez samca.",
                AnimalId = 151
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 533,
                Description = "Alpaki hodowane są dla wełny oraz dla mięsa, które jest uważane przez andyjskich mieszkańców za przysmak.Z wełny tego zwierzęcia produkuje się koce, poncza i dobrej jakości odzież.",
                AnimalId = 152
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 534,
                Description = "Tworzy haremowe grupy rodzinne złożone z 6-19 osobników (samca i samic z młodymi).",
                AnimalId = 153
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 535,
                Description = "Wikunie są aktywne w ciągu dnia.",
                AnimalId = 153
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 536,
                Description = "Mają niezwykle duże serce, którego masa jest o około 50% większa niż u innych ssaków tej samej wielkości, co jest przystosowaniem do przebywania na dużych wysokościach. Ich wełna o doskonałej jakości była powodem intensywnych polowań na te zwierzęta.",
                AnimalId = 153
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 537,
                Description = "Charakterystyczną cechą reniferów jest obecność poroża u osobników obu płci.",
                AnimalId = 154
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 538,
                Description = "Jest ono półkoliście zakrzywione, zakończone rozgałęzieniami, nieco mniejsze u samic. Renifery odbywają dalekie wędrówki, nawet na odległość do 2000 km.",
                AnimalId = 154
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 539,
                Description = "Jelenie są aktywne wczesnym rankiem i wieczorem.",
                AnimalId = 155
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 540,
                Description = "Są zwierzętami stadnymi. Ich naturalnym wrogiem jest wilk, niedźwiedź i ryś.",
                AnimalId = 155
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 541,
                Description = "W Polsce daniel był od średniowiecza hodowany w parkach i menażeriach jako zwierzę ozdobne.",
                AnimalId = 156
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 542,
                Description = "Jeleń ten został odkryty przez francuskiego misjonarza ojca Armanda Davida. Według chińskich opisów łączy w sobie cechy jelenia, krowy i osła.",
                AnimalId = 157
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 543,
                Description = "Opisano go jako nowy gatunek w roku 1866 we Francji. W następnych latach sprowadzono te zwierzęta do Europy.",
                AnimalId = 157
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 544,
                Description = "Aktywny rano i wieczorem, dzień spędza w ukryciu.",
                AnimalId = 158
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 545,
                Description = "Naturalnym wrogiem osobników dorosłych jest tygrys bengalski, młodych również szakal.",
                AnimalId = 158
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 546,
                Description = "Jest jednym z najmniejszych przedstawicieli rodziny jeleniowatych.",
                AnimalId = 159
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 547,
                Description = "Żyje do 13 lat. W sytuacji zagrożenia podnosi ogon i wydaje donośny odgłos przypominający szczekanie.",
                AnimalId = 159
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 548,
                Description = "Szyja żyrafy zawiera tylko 7 kręgów szyjnych, tak jak u większości ssaków.",
                AnimalId = 160
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 549,
                Description = "Naukowcy wyróżnili 9 podgatunków żyraf, zamieszkujących różne rejony Afryki i różniących są głównie układem, kolorem i wielkością plam na skórze. Porusza się inochodem.",
                AnimalId = 160
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 550,
                Description = "Samce żyrafy Rothschilda osiągają najwyższy wzrost spośród wszystkich podgatunków żyraf.",
                AnimalId = 160
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 551,
                Description = "Samiec osiąga wagę około 1000 kg.",
                AnimalId = 161
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 552,
                Description = "Jest to jedna z największych antylop. Podejmowano próby udomowienia tego gatunku.",
                AnimalId = 161
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 553,
                Description = "Charakterystyczną cechą gatunku jest wyraźnie zaznaczony dymorfizm płciowy. Samce są większe od samic, tylko one posiadają rogi, różnią się także ubarwieniem.",
                AnimalId = 162
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 554,
                Description = "Antylopy te prowadzą osiadły tryb życia.",
                AnimalId = 162
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 555,
                Description = "Są doskonałymi pływakami.",
                AnimalId = 162
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 556,
                Description = "Żyje w stadach.",
                AnimalId = 163
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 557,
                Description = "Bardzo zwinnie porusza się po skalistym terenie.",
                AnimalId = 163
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 558,
                Description = "Przy dużej dostępności pokarmu aktywny jedynie wieczorem i o świcie. W okresach niedostatku pożywienia żeruje również w ciągu dnia.",
                AnimalId = 164
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 559,
                Description = "Jest spokrewniony z wołem piżmowym.",
                AnimalId = 164
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 560,
                Description = "Jest gatunkiem doskonale przystosowanym do wspinania się po skałach.",
                AnimalId = 165
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 561,
                Description = "Jego naturalnym wrogiem jest pantera śnieżna.",
                AnimalId = 165
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 562,
                Description = "Koza karłowata jest hodowana dla mleka, mięsa, jako zwierzę juczne.",
                AnimalId = 166
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 563,
                Description = "Jest to jedna z najmniejszych ras kóz.",
                AnimalId = 166
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 564,
                Description = "Żyje w stadach liczących 5-20 osobników.",
                AnimalId = 167
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 565,
                Description = "Jest aktywna rano, nocą i wieczorem, chroni się w ten sposób przed wysoką temperaturą dnia.",
                AnimalId = 167
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 566,
                Description = "Żyje w stadach złożonych z kilkunastu osobników.",
                AnimalId = 168
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 567,
                Description = "W razie zagrożenia ratuje się ucieczką do wody.",
                AnimalId = 168
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 568,
                Description = "Zagrożona na lądzie ucieka do wody, dlatego też często nazywana jest kobem wodnym.",
                AnimalId = 169
            });
            modelBuilder.Entity<AnimalTidbit>().HasData(new AnimalTidbit
            {
                Id = 569,
                Description = "Świetnie pływa.",
                AnimalId = 169
            });
            #endregion
        }
    }
}

