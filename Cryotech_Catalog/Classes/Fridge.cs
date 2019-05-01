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
    public enum FridgeType
    {
        [Description("Side-By-Side")]
        SideBySide,
        [Description("Single Сhamber")]
        SingleСhamber,
        [Description("Multichamber")]
        MultiChamber,
        [Description("Multidoor")]
        MultiDoor
    }

    public enum CompressorType
    {
        [Description("Usual")]
        Usual,
        [Description("Inverter")]
        Inverter,
        [Description("Linear")]
        Linear,
        [Description("Rotary")]
        Rotary
    }

    public enum FreezerLocationType
    {
        [Description("Upper")]
        Upper,
        [Description("Lower")]
        Lower,
        [Description("At the side")]
        AtTheSide,
        [Description("Missing")]
        Missing
    }

    public class Fridge : Device
    {
        // Int
        public int CompressorsAmount { get; set; }          // Количество компрессоров 
        public int FridgeUsefulVolume { get; set; }         // Полезный объем холодильной камеры 
        public int FreezerUsefulVolume { get; set; }        // Полезный объем морозильной камеры 

        // Bool
        public bool FreshnessZone { get; set; }             // Зона свежести
        public bool MiniBar { get; set; }                   // Мини-бар

        // Enum
        public FridgeType DeviceType { get; set; }               // Тип устройства 
        public CompressorType CompressorType { get; set; }       // Тип компрессора
        public FreezerLocationType FreezerLocation { get; set; } // Расположение морозильной камеры

        // Default Constructor
        public Fridge()
        { }

        // Main Constructor
        public Fridge
            (int Price, int OverallVolume, int Weight, int Height, int Width, int Depth,
            string Name, string Manufacturer, string Color, string ProducingCountry,
            bool Display, bool DefrostSystem, bool RehangingDoors, byte[] DeviceImage,
            InstallationMethodType InstallationMethod, ControlType ControlType,
            int NoiseLevel, string Refrigerant, EnegryClassType EnegryClass,
            int CompressorsAmount, int FridgeUsefulVolume, int FreezerUsefulVolume,
            bool FreshnessZone, bool MiniBar,
            FreezerLocationType FreezerLocation, CompressorType CompressorType, FridgeType DeviceType) : base
            
            (Price, OverallVolume, Weight, Height, Width, Depth,
            Name, Manufacturer, Color, ProducingCountry,
            Display, DefrostSystem, RehangingDoors, DeviceImage,
            InstallationMethod, ControlType,
            NoiseLevel, Refrigerant, EnegryClass)
        {
            // Int
            this.CompressorsAmount = CompressorsAmount;
            this.FridgeUsefulVolume = FridgeUsefulVolume;
            this.FreezerUsefulVolume = FreezerUsefulVolume;

            // Bool
            this.FreshnessZone = FreshnessZone;
            this.MiniBar = MiniBar;

            // Enums
            this.DeviceType = DeviceType;
            this.CompressorType = CompressorType;
            this.FreezerLocation = FreezerLocation;
        }

    }
}
