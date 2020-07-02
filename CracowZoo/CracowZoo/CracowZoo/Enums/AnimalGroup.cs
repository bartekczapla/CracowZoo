using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CracowZoo.Enums
{
    public enum AnimalGroup
    {
        [Description("Bezkręgowce")]
        Invertebrates,
        [Description("Ryby")]
        Fish,
        [Description("Płazy")]
        Amphibians,
        [Description("Gady")]
        Reptiles,
        [Description("Ptaki")]
        Birds,
        [Description("Ssaki")]
        Mammals
    }
}
