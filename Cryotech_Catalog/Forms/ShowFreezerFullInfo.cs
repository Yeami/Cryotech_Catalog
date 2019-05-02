using Cryotech_Catalog.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryotech_Catalog.Forms
{
    public partial class ShowFreezerFullInfo : MetroFramework.Forms.MetroForm
    {
        public ShowFreezerFullInfo(Freezer NewFreezer)
        {
            InitializeComponent();

            // Image
            FreezerPictureBox.Image = ByteArrayToImage(NewFreezer.DeviceImage);

            // Basic Info GroupBox
            NameInfoLabel.Text = NewFreezer.Name;
            ManufacturerInfoLabel.Text = NewFreezer.Manufacturer;
            PriceInfoLabel.Text = Convert.ToString(NewFreezer.Price) + " uah";
            OverallVolumeInfoLabel.Text = Convert.ToString(NewFreezer.OverallVolume) + " L";
            WeightInfoLabel.Text = Convert.ToString(NewFreezer.Weight) + " kg";
            HeightInfoLabel.Text = Convert.ToString(NewFreezer.Height) + " sm";
            WidthInfoLabel.Text = Convert.ToString(NewFreezer.Width) + " sm";
            DepthInfoLabel.Text = Convert.ToString(NewFreezer.Depth) + " sm";
            ColorInfoLabel.Text = NewFreezer.Color;
            ProducingCountryInfoLabel.Text = NewFreezer.ProducingCountry;
            FreezingPowerInfoLabel.Text = Convert.ToString(NewFreezer.FreezingPower) + " kg/24 hrs";

            // Extra Info GroupBox
            InstallationMethodInfoLabel.Text = Convert.ToString(NewFreezer.InstallationMethod);
            ControlTypeInfoLabel.Text = Convert.ToString(NewFreezer.ControlType);
            DeviceTypeInfoLabel.Text = Convert.ToString(NewFreezer.DeviceType);
            EnergyClassInfoLabel.Text = Convert.ToString(NewFreezer.EnergyClass);
            UsefulVolumeInfoLabel.Text = Convert.ToString(NewFreezer.UsefulVolume) + " L";
            ShelvesAmountInfoLabel.Text = Convert.ToString(NewFreezer.ShelvesAmount);
            BoxesAmountInfoLabel.Text = Convert.ToString(NewFreezer.BoxesAmount);
            AutoColdStorageInfoLabel.Text = Convert.ToString(NewFreezer.AutonomousColdStorage) + " hrs";
            NoiseLevelInfoLabel.Text = Convert.ToString(NewFreezer.NoiseLevel) + " dB";
            RefrigerantInfoLabel.Text = NewFreezer.Refrigerant;

            // Freezer Features Info GroupBox
            DisplayInfoLabel.Text = (NewFreezer.Display == true) ? "Yes" : "No";
            DefrostSystemInfoLabel.Text = (NewFreezer.DefrostSystem == true) ? "Yes" : "No";
            RehangingDoorsInfoLabel.Text = (NewFreezer.RehangingDoors == true) ? "Yes" : "No";
            EcoModeInfoLabel.Text = (NewFreezer.EcoMode == true) ? "Yes" : "No";
            FastFreezingInfoLabel.Text = (NewFreezer.FastFreezing == true) ? "Yes" : "No";
            IceGeneratorInfoLabel.Text = (NewFreezer.IceGenerator == true) ? "Yes" : "No";
        }

        private Image ByteArrayToImage(byte[] ByteArray)
        {
            using (var ImageMemoryStream = new MemoryStream(ByteArray))
            {
                Image Result = Image.FromStream(ImageMemoryStream);
                return Result;
            }
        }
    }
}
