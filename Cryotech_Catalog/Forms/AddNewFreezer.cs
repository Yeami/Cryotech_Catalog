using Cryotech_Catalog.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            NewFreezer.Manufacturer = ManufacturerTextBox.Text.ToUpper();
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

        // TextBoxes Validating
        private void ManufacturerTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex ManufacturerRegexFormat = new Regex("^[A-Za-z]+$");
            if (!ManufacturerRegexFormat.IsMatch(ManufacturerTextBox.Text))
            {
                e.Cancel = true;
                MetroFramework.MetroMessageBox.Show(this, "\nThis field should contain only letters of the English alphabet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NameTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex NameRegexFormat = new Regex("^[A-Za-z0-9]+$");
            if (!NameRegexFormat.IsMatch(NameTextBox.Text))
            {
                e.Cancel = true;
                MetroFramework.MetroMessageBox.Show(this, "\nThis field should contain only numbers or letters of the English alphabet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PriceTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex PriceRegexFormat = new Regex("^([1-9][0-9]*)$");
            if (!PriceRegexFormat.IsMatch(PriceTextBox.Text))
            {
                e.Cancel = true;
                MetroFramework.MetroMessageBox.Show(this, "\nThis field should contain only numbers and don't starts from zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OverallVolumeTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex OverallVolumeRegexFormat = new Regex("^([1-9][0-9]*)$");
            if (!OverallVolumeRegexFormat.IsMatch(OverallVolumeTextBox.Text))
            {
                e.Cancel = true;
                MetroFramework.MetroMessageBox.Show(this, "\nThis field should contain only numbers and don't starts from zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void WeightTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex WeightRegexFormat = new Regex("^([1-9][0-9]*)$");
            if (!WeightRegexFormat.IsMatch(WeightTextBox.Text))
            {
                e.Cancel = true;
                MetroFramework.MetroMessageBox.Show(this, "\nThis field should contain only numbers and don't starts from zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HeightTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex HeightRegexFormat = new Regex("^([1-9][0-9]*)$");
            if (!HeightRegexFormat.IsMatch(HeightTextBox.Text))
            {
                e.Cancel = true;
                MetroFramework.MetroMessageBox.Show(this, "\nThis field should contain only numbers and don't starts from zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void WidthTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex WidthRegexFormat = new Regex("^([1-9][0-9]*)$");
            if (!WidthRegexFormat.IsMatch(WidthTextBox.Text))
            {
                e.Cancel = true;
                MetroFramework.MetroMessageBox.Show(this, "\nThis field should contain only numbers and don't starts from zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DepthTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex DepthRegexFormat = new Regex("^([1-9][0-9]*)$");
            if (!DepthRegexFormat.IsMatch(DepthTextBox.Text))
            {
                e.Cancel = true;
                MetroFramework.MetroMessageBox.Show(this, "\nThis field should contain only numbers and don't starts from zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ColorTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex ColorRegexFormat = new Regex("^[A-Za-z]+$");
            if (!ColorRegexFormat.IsMatch(ColorTextBox.Text))
            {
                e.Cancel = true;
                MetroFramework.MetroMessageBox.Show(this, "\nThis field should contain only letters of the English alphabet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ProducingCountryTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex ProducingCountryRegexFormat = new Regex("^[A-Za-z]+$");
            if (!ProducingCountryRegexFormat.IsMatch(ProducingCountryTextBox.Text))
            {
                e.Cancel = true;
                MetroFramework.MetroMessageBox.Show(this, "\nThis field should contain only letters of the English alphabet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UsefulVolumeTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex UsefulVolumeRegexFormat = new Regex("^([1-9][0-9]*)$");
            if (!UsefulVolumeRegexFormat.IsMatch(UsefulVolumeTextBox.Text))
            {
                e.Cancel = true;
                MetroFramework.MetroMessageBox.Show(this, "\nThis field should contain only numbers and don't starts from zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NoiseLevelTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex NoiseLevelRegexFormat = new Regex("^([1-9][0-9]*)$");
            if (!NoiseLevelRegexFormat.IsMatch(NoiseLevelTextBox.Text))
            {
                e.Cancel = true;
                MetroFramework.MetroMessageBox.Show(this, "\nThis field should contain only numbers and don't starts from zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RefrigerantTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex RefrigerantRegexFormat = new Regex("^[A-Za-z0-9]+$");
            if (!RefrigerantRegexFormat.IsMatch(RefrigerantTextBox.Text))
            {
                e.Cancel = true;
                MetroFramework.MetroMessageBox.Show(this, "\nThis field should contain only numbers or letters of the English alphabet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FreezingPowerTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex FreezingPowerRegexFormat = new Regex("^([1-9][0-9]*)$");
            if (!FreezingPowerRegexFormat.IsMatch(FreezingPowerTextBox.Text))
            {
                e.Cancel = true;
                MetroFramework.MetroMessageBox.Show(this, "\nThis field should contain only numbers and don't starts from zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AutoColdStorageTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex AutoColdStorageRegexFormat = new Regex("^([1-9][0-9]*)$");
            if (!AutoColdStorageRegexFormat.IsMatch(AutoColdStorageTextBox.Text))
            {
                e.Cancel = true;
                MetroFramework.MetroMessageBox.Show(this, "\nThis field should contain only numbers and don't starts from zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ShelvesAmountTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex ShelvesAmountRegexFormat = new Regex("^([1-9][0-9]*)$");
            if (!ShelvesAmountRegexFormat.IsMatch(ShelvesAmountTextBox.Text))
            {
                e.Cancel = true;
                MetroFramework.MetroMessageBox.Show(this, "\nThis field should contain only numbers and don't starts from zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BoxesAmountTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex BoxesAmountRegexFormat = new Regex("^([1-9][0-9]*)$");
            if (!BoxesAmountRegexFormat.IsMatch(BoxesAmountTextBox.Text))
            {
                e.Cancel = true;
                MetroFramework.MetroMessageBox.Show(this, "\nThis field should contain only numbers and don't starts from zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}