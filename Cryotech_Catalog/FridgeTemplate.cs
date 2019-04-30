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

namespace Cryotech_Catalog
{
    public partial class FridgeTemplate : UserControl
    {
        public FridgeTemplate(Fridge NewFridge)
        {
            InitializeComponent();

            TitleLabel.Text = NewFridge.TitleToString();
            ColorInfoLabel.Text = NewFridge.Color;
            FridgeUsefulVolumeInfoLabel.Text = Convert.ToString(NewFridge.FridgeUsefulVolume) + " L";
            FreezerUsefulVolumeInfoLabel.Text = Convert.ToString(NewFridge.FreezerUsefulVolume) + " L";
            FridgeTypeInfoLabel.Text = Convert.ToString(NewFridge.DeviceType);
            CompressorsAmountInfoLabel.Text = Convert.ToString(NewFridge.CompressorsAmount);
            ControlTypeInfoLabel.Text = Convert.ToString(NewFridge.ControlType);
            DimensionsInfoLabel.Text = NewFridge.DimensionsToString() + " sm";
            WeightInfoLabel.Text = Convert.ToString(NewFridge.Weight) + " kg";
            PriceLabel.Text = Convert.ToString(NewFridge.Price) + " uah";
            PriceLabel.ForeColor = System.Drawing.Color.Red;
        }
    }
}
