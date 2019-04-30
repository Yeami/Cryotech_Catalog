using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryotech_Catalog.Classes
{
    public enum EnegryClassType
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
        EnegryClassType EnegryClass { get; set; } // Класс энергопотребления
    }
}
