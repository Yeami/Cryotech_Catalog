using Cryotech_Catalog.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryotech_Catalog
{
    public partial class CryotechMainForm : MetroFramework.Forms.MetroForm
    {
        List<Device> Devices = new List<Device>();

        public CryotechMainForm()
        {
            InitializeComponent();
        }

        private void AddFridgeTile_Click(object sender, EventArgs e)
        {
            Fridge NewFridge = new Fridge();

            using (AddNewFridge AddFridgeForm = new AddNewFridge(NewFridge))
            {
                if (AddFridgeForm.ShowDialog() == DialogResult.OK)
                {
                    Devices.Add(NewFridge);
                    MessageBox.Show("Fridge Added Successfully");

                    FridgeTemplate FridgeUserControl = new FridgeTemplate(NewFridge);
                    DeviceViewPanel.Controls.Add(FridgeUserControl);
                }
            }
        }

        private void AddFreezerTile_Click(object sender, EventArgs e)
        {
            Freezer NewFreezer = new Freezer();

            using (AddNewFreezer AddFreezerForm = new AddNewFreezer(NewFreezer))
            {
                if (AddFreezerForm.ShowDialog() == DialogResult.OK)
                {
                    Devices.Add(NewFreezer);
                    MessageBox.Show("Freezer Added Successfully");
                }
            }
        }

        private void SaveDataTile_Click(object sender, EventArgs e)
        {

        }
    }
}
