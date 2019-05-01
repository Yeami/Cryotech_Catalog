using Cryotech_Catalog.Classes;
using Cryotech_Catalog.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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
                    DisplayFridgeDevice(NewFridge);
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
            XmlSerializer formatter = new XmlSerializer(typeof(List<Device>));

            using (FileStream fs = new FileStream("Data.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Devices);
            }
        }

        private void CryotechMainForm_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("Data.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Device>));

                Devices = (List<Device>)formatter.Deserialize(fs);

                foreach (var NewDevice in Devices)
                {
                    if (NewDevice.GetType() == typeof(Fridge))
                    {
                        Fridge NewFridge = (Fridge)Convert.ChangeType(NewDevice, typeof(Fridge));
                        DisplayFridgeDevice(NewFridge);
                    }
                    else if (NewDevice.GetType() == typeof(Freezer))
                    {
                        Freezer NewFreezer = (Freezer)Convert.ChangeType(NewDevice, typeof(Freezer));
                    }
                }
            }
        }

        private void DisplayFridgeDevice(Fridge NewFridge)
        {
            FridgeTemplate FridgeUserControl = new FridgeTemplate(NewFridge);
            DeviceViewPanel.Controls.Add(FridgeUserControl);
        }

        private void DisplayFreezerDevice(Freezer NewFreezer)
        {
            FreezerTemplate FreezerUserControl = new FreezerTemplate(NewFreezer);
            DeviceViewPanel.Controls.Add(FreezerUserControl);
        }
    }
}
