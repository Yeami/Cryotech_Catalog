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

        List<Device> FilteredDevices = new List<Device>();

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
                    MetroFramework.MetroMessageBox.Show(this, "Ok", "Fridge Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MetroFramework.MetroMessageBox.Show(this, "Ok", "Freezer Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayFreezerDevice(NewFreezer);
                }
            }
        }

        private void SaveDataTile_Click(object sender, EventArgs e)
        {
            XmlSerializer DeviceSerializer = new XmlSerializer(typeof(List<Device>));

            using (FileStream DeviceFileStream = new FileStream("Data.xml", FileMode.OpenOrCreate))
            {
                DeviceSerializer.Serialize(DeviceFileStream, Devices);
            }
            MetroFramework.MetroMessageBox.Show(this, "Ok", "Data Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CryotechMainForm_Load(object sender, EventArgs e)
        {
            XmlSerializer DeviceDeserializer = new XmlSerializer(typeof(List<Device>));

            using (FileStream DeviceFileStream = new FileStream("Data.xml", FileMode.OpenOrCreate))
            {
                try
                {
                    Devices = (List<Device>)DeviceDeserializer.Deserialize(DeviceFileStream);
                    DisplayDevices(Devices);
                }
                catch (Exception)
                {
                    Devices.Clear();
                }
            }
        }

        private void DisplayDevices(List<Device> Devices)
        {
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
                    DisplayFreezerDevice(NewFreezer);
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

        private void FiltersApplyButton_Click(object sender, EventArgs e)
        {
            if ((DeviceTypeCheckedListBox.CheckedItems.Count != 0) ||
                (ManufactorerCheckedListBox.CheckedItems.Count != 0) ||
                (ColorCheckedListBox.CheckedItems.Count != 0) ||
                (!String.IsNullOrEmpty(PriceFromTextBox.Text)) ||
                (!String.IsNullOrEmpty(PriceToTextBox.Text)))
            {
                // Clear the Filtered Devices Lists
                FilteredDevices.Clear();

                // Clear View Panel
                DeviceViewPanel.Controls.Clear();

                // Display Filtered Devices
                ApplyFilters();
                FilteredDevices = FilteredDevices.Distinct().ToList();
                DisplayDevices(FilteredDevices);
            }
            else
            {
                // Clear View Panel
                DeviceViewPanel.Controls.Clear();

                // Display All Devices
                DisplayDevices(Devices);
            }
        }

        private void ApplyFilters()
        {
            // Manufactorer Filter
            if (ManufactorerCheckedListBox.CheckedItems.Count != 0)
            {
                FilteredDevices = ManufactorerFilter();
            }

            // Color Filter
            if (ColorCheckedListBox.CheckedItems.Count != 0)
            {
                FilteredDevices = ColorFilter();
            }

            // DeviceType Filter
            if (DeviceTypeCheckedListBox.CheckedItems.Count != 0)
            {
                FilteredDevices = DeviceTypeFilter();
            }

            // Price Filter
            if ((!String.IsNullOrEmpty(PriceFromTextBox.Text)) || (!String.IsNullOrEmpty(PriceToTextBox.Text)))
            {
                FilteredDevices = PriceFilter();
            }
        }

        // Manufactorer Display Data Function
        private List<Device> ManufactorerFilter()
        {
            List<Device> ManufactorerDevices = new List<Device>();

            foreach (string ManufactorerItem in ManufactorerCheckedListBox.CheckedItems)
            {
                foreach (var DeviceItem in Devices)
                {
                    if (ManufactorerItem == DeviceItem.Manufacturer.ToUpper())
                    {
                        ManufactorerDevices.Add(DeviceItem);
                    }
                }
            }

            return ManufactorerDevices;
        }

        // Color Display Data Function
        private List<Device> ColorFilter()
        {
            List<Device> ColorDevices = new List<Device>();

            foreach (string ColorItem in ColorCheckedListBox.CheckedItems)
            {
                if (FilteredDevices.Count != 0)
                {
                    foreach (var DeviceItem in FilteredDevices)
                    {
                        ColorItemCheck(ColorDevices, ColorItem, DeviceItem);
                    }
                }
                else
                {
                    foreach (var DeviceItem in Devices)
                    {
                        ColorItemCheck(ColorDevices, ColorItem, DeviceItem);
                    }
                }
            }

            return ColorDevices;
        }

        private void ColorItemCheck(List<Device> ColorDevices, string ColorItem, Device DeviceItem)
        {
            if (ColorItem == DeviceItem.Color)
            {
                ColorDevices.Add(DeviceItem);
            }
        }

        // DeviceType Display Data Function
        private List<Device> DeviceTypeFilter()
        {
            List<Device> TypeDevices = new List<Device>();

            foreach (string CheckedListBoxItem in DeviceTypeCheckedListBox.CheckedItems)
            {
                if (FilteredDevices.Count != 0)
                {
                    foreach (var DeviceItem in FilteredDevices)
                    {
                        DeviceTypeItemCheck(TypeDevices, CheckedListBoxItem, DeviceItem);
                    }
                }
                else
                {
                    foreach (var DeviceItem in Devices)
                    {
                        DeviceTypeItemCheck(TypeDevices, CheckedListBoxItem, DeviceItem);
                    }
                }
            }

            return TypeDevices;
        }

        private void DeviceTypeItemCheck(List<Device> TypeDevices, string CheckedListBoxItem, Device DeviceItem)
        {
            if (CheckedListBoxItem == "Fridge")
            {
                if (DeviceItem.GetType() == typeof(Fridge))
                {
                    Fridge NewFridge = (Fridge)Convert.ChangeType(DeviceItem, typeof(Fridge));
                    TypeDevices.Add(NewFridge);
                }
            }
            else if (CheckedListBoxItem == "Freezer")
            {
                if (DeviceItem.GetType() == typeof(Freezer))
                {
                    Freezer NewFreezer = (Freezer)Convert.ChangeType(DeviceItem, typeof(Freezer));
                    TypeDevices.Add(NewFreezer);
                }
            }
        }

        // Price Display Data Function
        private List<Device> PriceFilter()
        {
            List<Device> PriceDevices = new List<Device>();

            int PriceFrom = 0;
            int PriceTo = 0;

            if (!String.IsNullOrEmpty(PriceFromTextBox.Text))
            {
                PriceFrom = Convert.ToInt32(PriceFromTextBox.Text);
            }

            if (!String.IsNullOrEmpty(PriceToTextBox.Text))
            {
                PriceTo = Convert.ToInt32(PriceToTextBox.Text);
            }

            if (FilteredDevices.Count != 0)
            {
                foreach (var DeviceItem in FilteredDevices)
                {
                    PriceItemCheck(PriceDevices, DeviceItem, PriceFrom, PriceTo);
                }
            }
            else
            {
                foreach (var DeviceItem in Devices)
                {
                    PriceItemCheck(PriceDevices, DeviceItem, PriceFrom, PriceTo);
                }
            }

            return PriceDevices;
        }

        private void PriceItemCheck(List<Device> PriceDevices, Device DeviceItem, int PriceFrom, int PriceTo)
        {
            if ((!String.IsNullOrEmpty(PriceFromTextBox.Text)) && (!String.IsNullOrEmpty(PriceToTextBox.Text)))
            {
                if ((DeviceItem.Price >= PriceFrom) && (DeviceItem.Price <= PriceTo))
                {
                    PriceDevices.Add(DeviceItem);
                }
            }
            else if ((!String.IsNullOrEmpty(PriceFromTextBox.Text)) && (String.IsNullOrEmpty(PriceToTextBox.Text)))
            {
                if (DeviceItem.Price >= PriceFrom)
                {
                    PriceDevices.Add(DeviceItem);
                }
            }
            else if ((!String.IsNullOrEmpty(PriceToTextBox.Text)) && (String.IsNullOrEmpty(PriceFromTextBox.Text)))
            {
                if (DeviceItem.Price <= PriceTo)
                {
                    PriceDevices.Add(DeviceItem);
                }
            }
        }
    }
}
