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

        }

        private void ShowHardFeaturesLabel_Click(object sender, EventArgs e)
        {
            if (HardFeaturesLabelStatus == 0)
            {

            }
            else if (HardFeaturesLabelStatus == 1)
            {

            }
        }

        private void TitleLabel_DoubleClick(object sender, EventArgs e)
        {
            //ShowFridgeFullInfo FridgeInfoForm = new ShowFridgeFullInfo(NewFridge);
            //FridgeInfoForm.Show();
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
    }
}
