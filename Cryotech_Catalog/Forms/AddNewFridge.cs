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
    public partial class AddNewFridge : MetroFramework.Forms.MetroForm
    {
        Fridge NewFridge;

        Image UploadedImage;

        public AddNewFridge(Fridge NewEmptyFridge)
        {
            InitializeComponent();

            NewFridge = NewEmptyFridge;

            CurrentPictureInfoLabel.Text = "";

            // Show the info from enums in ComboBoxes
            ShowComboBoxes();
        }

        private void SaveNewFridgeTile_Click(object sender, EventArgs e)
        {
            // Basic Info GroupBox
            NewFridge.Manufacturer = ManufacturerTextBox.Text;
            NewFridge.Name = NameTextBox.Text;
            NewFridge.Price = Convert.ToInt32(PriceTextBox.Text);
            NewFridge.OverallVolume = Convert.ToInt32(OverallVolumeTextBox.Text);
            NewFridge.Weight = Convert.ToInt32(WeightTextBox.Text);
            NewFridge.Height = Convert.ToInt32(HeightTextBox.Text);
            NewFridge.Width = Convert.ToInt32(WidthTextBox.Text);
            NewFridge.Depth = Convert.ToInt32(DepthTextBox.Text);
            NewFridge.Color = ColorTextBox.Text;
            NewFridge.ProducingCountry = ProducingCountryTextBox.Text;

            // Extra Info GroupBox
            NewFridge.InstallationMethod = (InstallationMethodType)Enum.Parse(typeof(InstallationMethodType), InstallationMethodComboBox.GetItemText(InstallationMethodComboBox.SelectedValue));
            NewFridge.ControlType = (ControlType)Enum.Parse(typeof(ControlType), ControlTypeComboBox.GetItemText(ControlTypeComboBox.SelectedValue));
            NewFridge.EnegryClass = (EnegryClassType)Enum.Parse(typeof(EnegryClassType), EnergyClassComboBox.GetItemText(EnergyClassComboBox.SelectedValue));
            NewFridge.NoiseLevel = Convert.ToInt32(NoiseLevelTextBox.Text);
            NewFridge.Refrigerant = RefrigerantTextBox.Text;

            NewFridge.Display = DisplayYesRadioButton.Checked ? true : false;
            NewFridge.DefrostSystem = DefrostSystemYesRadioButton.Checked ? true : false;
            NewFridge.RehangingDoors = RehangingDoorsYesRadioButton.Checked ? true : false;

            // Fridge Info GroupBox
            NewFridge.DeviceType = (FridgeType)Enum.Parse(typeof(FridgeType), DeviceTypeComboBox.GetItemText(DeviceTypeComboBox.SelectedValue));
            NewFridge.CompressorType = (CompressorType)Enum.Parse(typeof(CompressorType), CompressorTypeComboBox.GetItemText(CompressorTypeComboBox.SelectedValue));
            NewFridge.FreezerLocation = (FreezerLocationType)Enum.Parse(typeof(FreezerLocationType), FreezerLocationComboBox.GetItemText(FreezerLocationComboBox.SelectedValue));
            NewFridge.CompressorsAmount = Convert.ToInt32(CompressorsAmountTextBox.Text);
            NewFridge.FridgeUsefulVolume = Convert.ToInt32(FridgeUsefulVolumeTextBox.Text);
            NewFridge.FreezerUsefulVolume = Convert.ToInt32(FreezerUsefulVolumeTextBox.Text);

            NewFridge.FreshnessZone = FreshnessZoneYesRadioButton.Checked ? true : false;
            NewFridge.MiniBar = MiniBarYesRadioButton.Checked ? true : false;

            // Fridge Image
            NewFridge.DeviceImage = ImageToByteArray(UploadedImage);

            this.DialogResult = DialogResult.OK;
        }

        private void UploadPictureButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                string PictureLocation = Dialog.FileName;

                CurrentPictureInfoLabel.Text = Path.GetFileName(PictureLocation);
                UploadedImage = Image.FromFile(PictureLocation);
            }

        }

        private byte[] ImageToByteArray(Image UploadedImage)
        {
            using (var ms = new MemoryStream())
            {
                UploadedImage.Save(ms, UploadedImage.RawFormat);
                return ms.ToArray();
            }
        }

        private void ShowComboBoxes()
        {
            // InstallationMethod ComboBox
            InstallationMethodComboBox.DataSource = Enum.GetValues(typeof(InstallationMethodType))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            InstallationMethodComboBox.DisplayMember = "Description";
            InstallationMethodComboBox.ValueMember = "value";

            // ControlType ComboBox
            ControlTypeComboBox.DataSource = Enum.GetValues(typeof(ControlType))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            ControlTypeComboBox.DisplayMember = "Description";
            ControlTypeComboBox.ValueMember = "value";

            // EnergyClass ComboBox
            EnergyClassComboBox.DataSource = Enum.GetValues(typeof(EnegryClassType))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            EnergyClassComboBox.DisplayMember = "Description";
            EnergyClassComboBox.ValueMember = "value";

            // DeviceType ComboBox
            DeviceTypeComboBox.DataSource = Enum.GetValues(typeof(FridgeType))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            DeviceTypeComboBox.DisplayMember = "Description";
            DeviceTypeComboBox.ValueMember = "value";

            // CompressorType ComboBox
            CompressorTypeComboBox.DataSource = Enum.GetValues(typeof(CompressorType))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            CompressorTypeComboBox.DisplayMember = "Description";
            CompressorTypeComboBox.ValueMember = "value";

            // FreezerLocation ComboBox
            FreezerLocationComboBox.DataSource = Enum.GetValues(typeof(FreezerLocationType))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            FreezerLocationComboBox.DisplayMember = "Description";
            FreezerLocationComboBox.ValueMember = "value";
        }
    }
}
