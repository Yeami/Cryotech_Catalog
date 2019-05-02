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
    public partial class AddNewFreezer : MetroFramework.Forms.MetroForm
    {
        Freezer NewFreezer;

        Image UploadedImage;

        public AddNewFreezer(Freezer NewEmptyFreezer)
        {
            InitializeComponent();

            NewFreezer = NewEmptyFreezer;

            CurrentPictureInfoLabel.Text = "";

            // Show the info from enums in ComboBoxes
            ShowComboBoxes();
        }

        private void SaveNewFreezerTile_Click(object sender, EventArgs e)
        {
            // Basic Info GroupBox
            NewFreezer.Manufacturer = ManufacturerTextBox.Text;
            NewFreezer.Name = NameTextBox.Text;
            NewFreezer.Price = Convert.ToInt32(PriceTextBox.Text);
            NewFreezer.OverallVolume = Convert.ToInt32(OverallVolumeTextBox.Text);
            NewFreezer.Weight = Convert.ToInt32(WeightTextBox.Text);
            NewFreezer.Height = Convert.ToInt32(HeightTextBox.Text);
            NewFreezer.Width = Convert.ToInt32(WidthTextBox.Text);
            NewFreezer.Depth = Convert.ToInt32(DepthTextBox.Text);
            NewFreezer.Color = ColorTextBox.Text;
            NewFreezer.ProducingCountry = ProducingCountryTextBox.Text;
            NewFreezer.UsefulVolume = Convert.ToInt32(UsefulVolumeTextBox.Text);

            // Extra Info GroupBox
            NewFreezer.InstallationMethod = (InstallationMethodType)Enum.Parse(typeof(InstallationMethodType), InstallationMethodComboBox.GetItemText(InstallationMethodComboBox.SelectedValue));
            NewFreezer.EnergyClass = (EnergyClassType)Enum.Parse(typeof(EnergyClassType), EnergyClassComboBox.GetItemText(EnergyClassComboBox.SelectedValue));
            NewFreezer.DeviceType = (FreezerType)Enum.Parse(typeof(FreezerType), DeviceTypeComboBox.GetItemText(DeviceTypeComboBox.SelectedValue));
            NewFreezer.ControlType = (ControlType)Enum.Parse(typeof(ControlType), ControlTypeComboBox.GetItemText(ControlTypeComboBox.SelectedValue));
            NewFreezer.FreezingPower = Convert.ToInt32(FreezingPowerTextBox.Text);
            NewFreezer.AutonomousColdStorage = Convert.ToInt32(AutoColdStorageTextBox.Text);
            NewFreezer.ShelvesAmount = Convert.ToInt32(ShelvesAmountTextBox.Text);
            NewFreezer.BoxesAmount = Convert.ToInt32(BoxesAmountTextBox.Text);
            NewFreezer.NoiseLevel = Convert.ToInt32(NoiseLevelTextBox.Text);
            NewFreezer.Refrigerant = RefrigerantTextBox.Text;

            // Freezer Features Info GroupBox
            NewFreezer.Display = DisplayYesRadioButton.Checked ? true : false;
            NewFreezer.DefrostSystem = DefrostSystemYesRadioButton.Checked ? true : false;
            NewFreezer.RehangingDoors = RehangingDoorsYesRadioButton.Checked ? true : false;
            NewFreezer.IceGenerator = IceGeneratorYesRadioButton.Checked ? true : false;
            NewFreezer.FastFreezing = FastFreezingYesRadioButton.Checked ? true : false;
            NewFreezer.EcoMode = EcoModeYesRadioButton.Checked ? true : false;

            // Fridge Image
            NewFreezer.DeviceImage = ImageToByteArray(UploadedImage);

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
            using (var ByteMemoryStream = new MemoryStream())
            {
                UploadedImage.Save(ByteMemoryStream, UploadedImage.RawFormat);
                return ByteMemoryStream.ToArray();
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
            EnergyClassComboBox.DataSource = Enum.GetValues(typeof(EnergyClassType))
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
            DeviceTypeComboBox.DataSource = Enum.GetValues(typeof(FreezerType))
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
        }
    }
}