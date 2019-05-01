using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
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
        // Int
        public int UsefulVolume { get; set; }  // Полезный объем
        public int ShelvesAmount { get; set; } // Количество полок
        public int BoxesAmount { get; set; }   // Количество ящиков

        // Bool
        public bool IceGenerator { get; set; } // Генератор льда
        public bool FastFreezing { get; set; } // Быстрая заморозка

        // Enum
        public FreezerType DeviceType { get; set; } // Тип устройства

        // Default Constructor
        public Freezer()
        { }

        // Main Constructor
        public Freezer
            (int Price, int OverallVolume, int Weight, int Height, int Width, int Depth,
            string Name, string Manufacturer, string Color, string ProducingCountry,
            bool Display, bool DefrostSystem, bool RehangingDoors, byte[] DeviceImage,
            InstallationMethodType InstallationMethod, ControlType ControlType,
            int NoiseLevel, string Refrigerant, EnegryClassType EnegryClass,
            int UsefulVolume, int ShelvesAmount, int BoxesAmount,
            bool IceGenerator, bool FastFreezing, FreezerType DeviceType) : base

            (Price, OverallVolume, Weight, Height, Width, Depth,
            Name, Manufacturer, Color, ProducingCountry,
            Display, DefrostSystem, RehangingDoors, DeviceImage,
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
