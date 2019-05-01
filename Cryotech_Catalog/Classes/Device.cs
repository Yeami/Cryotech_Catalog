using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
        //[Description("Electronically Mechanical")]
        //ElectronicallyMechanical
    }

    public abstract class Device : IFeatures
    {
        public int Price { get; set; }               // Цена *
        public int OverallVolume { get; set; }       // Общий объем 
        public int Weight { get; set; }              // Вес *
        public int Height { get; set; }              // Высота *
        public int Width { get; set; }               // Ширина *
        public int Depth { get; set; }               // Глубина *

        public string Name { get; set; }             // Название *
        public string Manufacturer { get; set; }     // Производитель *
        public string Color { get; set; }            // Цвет *
        public string ProducingCountry { get; set; } // Страна-производитель 

        public bool Display { get; set; }            // Дисплей 
        public bool DefrostSystem { get; set; }      // Система разморозки 
        public bool RehangingDoors { get; set; }     // Перенавешивание дверей 

        // Enums
        public InstallationMethodType InstallationMethod { get; set; } // Способ установки 
        public ControlType ControlType { get; set; }                   // Тип управления *

        // IFeatures
        public int NoiseLevel { get; set; }              // Уровень шума 
        public string Refrigerant { get; set; }          // Хладагент 
        public EnegryClassType EnegryClass { get; set; } // Класс энергопотребления 

        // Default Constructor
        public Device()
        { }

        // Main Constructor
        public Device
            (int Price, int OverallVolume, int Weight, int Height, int Width, int Depth,
            string Name, string Manufacturer, string Color, string ProducingCountry, 
            bool Display, bool DefrostSystem, bool RehangingDoors,
            InstallationMethodType InstallationMethod, ControlType ControlType,
            int NoiseLevel, string Refrigerant, EnegryClassType EnegryClass)
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

            // Enums
            this.InstallationMethod = InstallationMethod;
            this.ControlType = ControlType;

            // IFeatures
            this.NoiseLevel = NoiseLevel;
            this.Refrigerant = Refrigerant;
            this.EnegryClass = EnegryClass;
        }

        public string TitleToString(string ObjectType)
        {
            return ObjectType + " " + this.Manufacturer.ToUpper() + " " + this.Name.ToUpper();
        }

        public string DimensionsToString()
        {
            return this.Height + "x" + this.Width + "x" + this.Depth;
        }

        public string HardFeaturesToString()
        {
            return "NoiseLevel: " + this.NoiseLevel.ToString() + " dB\n" + "Refrigerant: " + this.Refrigerant + "\nEnegryClass: " + this.EnegryClass.ToString();
        }
    }
}
