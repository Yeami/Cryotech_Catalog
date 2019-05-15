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
    public enum InstallationMethodType
    {
        [Description("Built In")]
        BuiltIn,
        [Description("Standing Separately")]
        Separately
    }

    public enum ControlType
    {
        [Description("Mechanical")]
        Mechanical,
        [Description("Electronic")]
        Electronic
    }

    [Serializable()]
    [System.Xml.Serialization.XmlInclude(typeof(Fridge))]
    [System.Xml.Serialization.XmlInclude(typeof(Freezer))]
    public abstract class Device : IFeatures
    {
        // Int
        public int Price { get; set; }               // Цена
        public int OverallVolume { get; set; }       // Общий объем
        public int Weight { get; set; }              // Вес
        public int Height { get; set; }              // Высота
        public int Width { get; set; }               // Ширина
        public int Depth { get; set; }               // Глубина

        // String
        public string Name { get; set; }             // Название
        public string Manufacturer { get; set; }     // Производитель
        public string Color { get; set; }            // Цвет
        public string ProducingCountry { get; set; } // Страна-производитель

        // Bool
        public bool Display { get; set; }            // Дисплей
        public bool DefrostSystem { get; set; }      // Система разморозки
        public bool RehangingDoors { get; set; }     // Перенавешивание дверей

        // Image
        public byte[] DeviceImage { get; set; }

        // Enums
        public InstallationMethodType InstallationMethod { get; set; } // Способ установки
        public ControlType ControlType { get; set; }                   // Тип управления

        // IFeatures
        public int NoiseLevel { get; set; }              // Уровень шума
        public string Refrigerant { get; set; }          // Хладагент
        public EnergyClassType EnergyClass { get; set; } // Класс энергопотребления

        // Default Constructor
        public Device()
        { }

        // Main Constructor
        public Device
            (int Price, int OverallVolume, int Weight, int Height, int Width, int Depth,
            string Name, string Manufacturer, string Color, string ProducingCountry, 
            bool Display, bool DefrostSystem, bool RehangingDoors, byte[] DeviceImage,
            InstallationMethodType InstallationMethod, ControlType ControlType,
            int NoiseLevel, string Refrigerant, EnergyClassType EnergyClass)
        {
            // Int
            this.Price = Price;
            this.OverallVolume = OverallVolume;
            this.Weight = Weight;
            this.Height = Height;
            this.Width = Width;
            this.Depth = Depth;

            // String
            this.Name = Name;
            this.Manufacturer = Manufacturer;
            this.Color = Color;
            this.ProducingCountry = ProducingCountry;

            // Bool
            this.Display = Display;
            this.DefrostSystem = DefrostSystem;
            this.RehangingDoors = RehangingDoors;

            // Image
            this.DeviceImage = DeviceImage;

            // Enums
            this.InstallationMethod = InstallationMethod;
            this.ControlType = ControlType;

            // IFeatures
            this.NoiseLevel = NoiseLevel;
            this.Refrigerant = Refrigerant;
            this.EnergyClass = EnergyClass;
        }

        public abstract string HardFeaturesToString();

        public string TitleToString(string ObjectType)
        {
            return ObjectType + " " + this.Manufacturer + " " + this.Name;
        }

        public string DimensionsToString()
        {
            return this.Height + "x" + this.Width + "x" + this.Depth;
        }
    }
}
