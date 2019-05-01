using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cryotech_Catalog.Classes
{
    public enum FreezerType
    {
        [Description("Сhamber")]
        Сhamber,
        [Description("Сhest")]
        Сhest
    }

    public class Freezer : Device
    {
        // Int
        public int UsefulVolume { get; set; }          // Полезный объем 
        public int ShelvesAmount { get; set; }         // Количество полок
        public int BoxesAmount { get; set; }           // Количество ящиков
        public int AutonomousColdStorage { get; set; } // Автономное сохранение холода
        public int FreezingPower { get; set; }         // Мощность заморозки

        // Bool
        public bool IceGenerator { get; set; } // Генератор льда
        public bool FastFreezing { get; set; } // Быстрая заморозка
        public bool EcoMode { get; set; }      // Эко режим

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
            int NoiseLevel, string Refrigerant, EnergyClassType EnergyClass,
            int UsefulVolume, int ShelvesAmount, int BoxesAmount, 
            int AutonomousColdStorage, int FreezingPower,
            bool IceGenerator, bool FastFreezing, bool EcoMode, FreezerType DeviceType) : base

            (Price, OverallVolume, Weight, Height, Width, Depth,
            Name, Manufacturer, Color, ProducingCountry,
            Display, DefrostSystem, RehangingDoors, DeviceImage,
            InstallationMethod, ControlType,
            NoiseLevel, Refrigerant, EnergyClass)
        {
            // Int
            this.UsefulVolume = UsefulVolume;
            this.ShelvesAmount = ShelvesAmount;
            this.BoxesAmount = BoxesAmount;
            this.AutonomousColdStorage = AutonomousColdStorage;
            this.FreezingPower = FreezingPower;

            // Bool
            this.IceGenerator = IceGenerator;
            this.FastFreezing = FastFreezing;
            this.EcoMode = EcoMode;

            // Enum
            this.DeviceType = DeviceType;
        }

        public override string HardFeaturesToString()
        {
            string NoiseLevel = "NoiseLevel: " + this.NoiseLevel.ToString() + " dB";
            string Refrigerant = "\nRefrigerant: " + this.Refrigerant.ToString();
            string EnergyClass = "\nEnegry Class: " + this.EnergyClass.ToString();
            string FreezingPower = "\nFreezing Power: " + this.FreezingPower.ToString() + " kg/24 hrs";
            string AutoColdStorage = "\nAuto Cold Storage: " + this.AutonomousColdStorage.ToString() + " hrs";

            return NoiseLevel + Refrigerant + EnergyClass + FreezingPower + AutoColdStorage;
        }
    }
}
