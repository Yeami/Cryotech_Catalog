using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cryotech_Catalog.Classes;
using System.IO;

namespace Cryotech_Catalog.Forms
{
    public partial class FreezerTemplate : UserControl
    {
        Freezer NewFreezer;

        int HardFeaturesLabelStatus = 0;

        public FreezerTemplate(Freezer NewEmptyFreezer)
        {
            InitializeComponent();

            NewFreezer = NewEmptyFreezer;

            TitleLabel.Text = NewFreezer.TitleToString("Freezer");

            ColorInfoLabel.Text = NewFreezer.Color;
            OverallVolumeInfoLabel.Text = Convert.ToString(NewFreezer.OverallVolume) + " L";
            ControlTypeInfoLabel.Text = Convert.ToString(NewFreezer.ControlType);
            DisplayInfoLabel.Text = (NewFreezer.Display == true) ? "Yes" : "No";
            DefrostSystemInfoLabel.Text = (NewFreezer.DefrostSystem == true) ? "Yes" : "No";
            DimensionsInfoLabel.Text = NewFreezer.DimensionsToString() + " sm";
            WeightInfoLabel.Text = Convert.ToString(NewFreezer.Weight) + " kg";
            ProducingCountryInfoLabel.Text = NewFreezer.ProducingCountry;
            PriceLabel.Text = Convert.ToString(NewFreezer.Price) + " UAH";
            PriceLabel.ForeColor = Color.Red;
            SmallFreezerPictureBox.Image = ByteArrayToImage(NewFreezer.DeviceImage);

            HardFeaturesInfoLabel.Text = "";
        }

        private void ShowHardFeaturesLabel_Click(object sender, EventArgs e)
        {
            if (HardFeaturesLabelStatus == 0)
            {
                ShowHardFeaturesLabel.Text = "Hide Hard Features";
                HardFeaturesInfoLabel.Text = NewFreezer.HardFeaturesToString();
                HardFeaturesLabelStatus = 1;
            }
            else if (HardFeaturesLabelStatus == 1)
            {
                ShowHardFeaturesLabel.Text = "Show Hard Features";
                HardFeaturesInfoLabel.Text = "";
                HardFeaturesLabelStatus = 0;
            }
        }

        private void TitleLabel_DoubleClick(object sender, EventArgs e)
        {
            ShowFreezerFullInfo FreezerInfoForm = new ShowFreezerFullInfo(NewFreezer);
            FreezerInfoForm.Show();
        }

        private Image ByteArrayToImage(byte[] ByteArray)
        {
            using (var ImageMemoryStream = new MemoryStream(ByteArray))
            {
                Image Result = Image.FromStream(ImageMemoryStream);
                return Result;
            }
        }

        private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            TitleLabel.ForeColor = Color.Violet;
        }

        private void TitleLabel_MouseLeave(object sender, EventArgs e)
        {
            TitleLabel.ForeColor = Color.DeepSkyBlue;
        }

        private void ShowHardFeaturesLabel_MouseMove(object sender, MouseEventArgs e)
        {
            ShowHardFeaturesLabel.ForeColor = Color.DeepSkyBlue;
        }

        private void ShowHardFeaturesLabel_MouseLeave(object sender, EventArgs e)
        {
            ShowHardFeaturesLabel.ForeColor = Color.Black;
        }
    }
}
