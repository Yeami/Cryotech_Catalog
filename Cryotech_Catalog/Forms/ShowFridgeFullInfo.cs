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

namespace Cryotech_Catalog
{
    public partial class ShowFridgeFullInfo : MetroFramework.Forms.MetroForm
    {
        public ShowFridgeFullInfo(Fridge NewFridge)
        {
            InitializeComponent();

            // Image
            FridgePictureBox.Image = ByteArrayToImage(NewFridge.DeviceImage);

            // Basic Info GroupBox
            ManufacturerInfoLabel.Text = NewFridge.Manufacturer;
            NameInfoLabel.Text = NewFridge.Name;
            PriceInfoLabel.Text = Convert.ToString(NewFridge.Price) + " uah";
            OverallVolumeInfoLabel.Text = Convert.ToString(NewFridge.OverallVolume) + " L";
            WeightInfoLabel.Text = Convert.ToString(NewFridge.Weight) + " kg";
            HeightInfoLabel.Text = Convert.ToString(NewFridge.Height) + " sm";
            WidthInfoLabel.Text = Convert.ToString(NewFridge.Width) + " sm";
            DepthInfoLabel.Text = Convert.ToString(NewFridge.Depth) + " sm";
            ColorInfoLabel.Text = NewFridge.Color;
            ProducingCountryInfoLabel.Text = NewFridge.ProducingCountry;

            // Extra Info GroupBox
            CompressorTypeInfoLabel.Text = Convert.ToString(NewFridge.CompressorType);
            CompressorsAmountInfoLabel.Text = Convert.ToString(NewFridge.CompressorsAmount);
            InstallationMethodInfoLabel.Text = Convert.ToString(NewFridge.InstallationMethod);
            DeviceTypeInfoLabel.Text = Convert.ToString(NewFridge.DeviceType);
            ControlTypeInfoLabel.Text = Convert.ToString(NewFridge.ControlType);
            FridgeUsefulVolumeInfoLabel.Text = Convert.ToString(NewFridge.FridgeUsefulVolume) + " L";
            FreezerUsefulVolumeInfoLabel.Text = Convert.ToString(NewFridge.FreezerUsefulVolume) + " L";
            EnergyClassInfoLabel.Text = Convert.ToString(NewFridge.EnergyClass);
            NoiseLevelInfoLabel.Text = Convert.ToString(NewFridge.NoiseLevel);
            RefrigerantInfoLabel.Text = NewFridge.Refrigerant;

            // Fridge Features Info GroupBox
            DisplayInfoLabel.Text = (NewFridge.Display == true) ? "Yes" : "No";
            MiniBarInfoLabel.Text = (NewFridge.MiniBar == true) ? "Yes" : "No";
            FreshnessZoneInfoLabel.Text = (NewFridge.FreshnessZone == true) ? "Yes" : "No";
            DefrostSystemInfoLabel.Text = (NewFridge.DefrostSystem == true) ? "Yes" : "No";
            FreezerLocationInfoLabel.Text = Convert.ToString(NewFridge.FreezerLocation);
            RehangingDoorsInfoLabel.Text = (NewFridge.RehangingDoors == true) ? "Yes" : "No";
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
