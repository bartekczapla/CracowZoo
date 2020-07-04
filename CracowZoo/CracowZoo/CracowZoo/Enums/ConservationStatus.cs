using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CracowZoo.Enums
{
    public enum ConservationStatus
    {
        [Description("Gatunki zanikłe")]
        NotEvaluated,
        [Description("Gatunek niezagrożony")]
        Normal,
        [Description("Gatunek na razie niezagrożony")]
        LeastConcern,
        [Description("Gatunek bliski zagrożenia")]
        NearThreatened,
        [Description("Gatunek narażony na wyginięcie")]
        Vulnerable,
        [Description("Gatunkek silnie zagrożony")]
        Endangered,
        [Description("Gatunek skrajnie zagrożony")]
        CriticallyEndangered,
        [Description("Gatunek zanikły")]
        ExtinctInWild,
        [Description("Gatunek wymarły")]
        Extinct,
        [Description("Brak danych")]
        Unknown
    }

    // https://pl.wikipedia.org/wiki/Polska_czerwona_ksi%C4%99ga_zwierz%C4%85t
}
