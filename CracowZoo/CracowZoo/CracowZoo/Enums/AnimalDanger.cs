using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CracowZoo.Enums
{
    public enum AnimalDanger
    {
        [Description("Brak")]
        None,
        [Description("Srednie")]
        Medium,
        [Description("Wysokie")]
        High
    }
}
