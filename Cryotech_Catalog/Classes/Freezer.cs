using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryotech_Catalog.Classes
{
    public enum FreezerType
    {
        //[Description("Сhamber")]
        Сhamber,
        //[Description("Сhest")]
        Сhest
    }

    public class Freezer : Device
    {
        public int UsefulVolume { get; set; }  // Полезный объем
        public int ShelvesAmount { get; set; } // Количество полок
        public int BoxesAmount { get; set; }   // Количество ящиков

        public bool IceGenerator { get; set; } // Генератор льда
        public bool FastFreezing { get; set; } // Быстрая заморозка

        public FreezerType DeviceType { get; set; } // Тип устройства

        // Default Constructor
        public Freezer()
        { }

        // Main Constructor
        public Freezer
            (int Price, int OverallVolume, int Weight, int Height, int Width, int Depth,
            string Name, string Manufacturer, string Color, string ProducingCountry,
            bool Display, bool DefrostSystem, bool RehangingDoors,
            InstallationMethodType InstallationMethod, ControlType ControlType,
            int NoiseLevel, string Refrigerant, EnegryClassType EnegryClass,
            int UsefulVolume, int ShelvesAmount, int BoxesAmount,
            bool IceGenerator, bool FastFreezing, FreezerType DeviceType) : base

            (Price, OverallVolume, Weight, Height, Width, Depth,
            Name, Manufacturer, Color, ProducingCountry,
            Display, DefrostSystem, RehangingDoors,
            InstallationMethod, ControlType,
            NoiseLevel, Refrigerant, EnegryClass)
        {
            // Int
            this.UsefulVolume = UsefulVolume;
            this.ShelvesAmount = ShelvesAmount;
            this.BoxesAmount = BoxesAmount;

            // Bool
            this.IceGenerator = IceGenerator;
            this.FastFreezing = FastFreezing;

            // Enum
            this.DeviceType = DeviceType;
        }
    }
}
