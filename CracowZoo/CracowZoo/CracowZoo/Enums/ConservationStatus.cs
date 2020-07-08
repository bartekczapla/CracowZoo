using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CracowZoo.Enums
{
    public enum ConservationStatus
    {
        [Description("Zanikły")]
        NotEvaluated,
        [Description("Niezagrożony")]
        Normal,
        [Description("Na razie niezagrożony")]
        LeastConcern,
        [Description("Bliski zagrożenia")]
        NearThreatened,
        [Description("Narażony na wyginięcie")]
        Vulnerable,
        [Description("Silnie zagrożony")]
        Endangered,
        [Description("Skrajnie zagrożony")]
        CriticallyEndangered,
        [Description("Zanikły")]
        ExtinctInWild,
        [Description("Wymarły")]
        Extinct,
        [Description("Brak danych")]
        Unknown
    }

    // https://pl.wikipedia.org/wiki/Polska_czerwona_ksi%C4%99ga_zwierz%C4%85t
}
