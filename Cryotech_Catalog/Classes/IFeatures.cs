using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryotech_Catalog.Classes
{
    public enum EnergyClassType
    {
        [Description("A")]
        A,
        [Description("A+")]
        APlus,
        [Description("A++")]
        ATwoPluses,
        [Description("A+++")]
        AThreePluses,
        [Description("A++++")]
        AFourPluses
    }

    interface IFeatures
    {
        int NoiseLevel { get; set; }              // Уровень шума
        string Refrigerant { get; set; }          // Хладагент
        EnergyClassType EnergyClass { get; set; } // Класс энергопотребления

        string HardFeaturesToString();
    }
}
