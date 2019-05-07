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

        List<Device> ManufactorerDevices = new List<Device>();
        List<Device> ColorDevices = new List<Device>();
        List<Device> TypeDevices = new List<Device>();
        List<Device> PriceDevices = new List<Device>();

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
                ManufactorerDevices.Clear();
                ColorDevices.Clear();
                TypeDevices.Clear();
                PriceDevices.Clear();
                // Clear View Panel
                DeviceViewPanel.Controls.Clear();
                // Display Filtered Devices
                ApplyFilters();
                FilteredDevices = FilteredDevices.Distinct().ToList();
                DisplayDevices(FilteredDevices);
            }
            else
            {
                DeviceViewPanel.Controls.Clear();
                DisplayDevices(Devices);
            }
        }

        private void ApplyFilters()
        {
            // Manufactorer && Color Filters
            if ((ManufactorerCheckedListBox.CheckedItems.Count != 0) && (ColorCheckedListBox.CheckedItems.Count != 0))
            {
                ManufactorerFilter();
                ColorFilter();

                IEnumerable<Device> FilteredResult = ManufactorerDevices.Intersect(ColorDevices);
                FilteredDevices = FilteredResult.ToList();
            }

            // Manufactorer Filter
            if ((ManufactorerCheckedListBox.CheckedItems.Count != 0) && (ColorCheckedListBox.CheckedItems.Count == 0))
            {
                ManufactorerFilter();
                FilteredDevices = ManufactorerDevices;
            }

            // Color Filter
            if ((ColorCheckedListBox.CheckedItems.Count != 0) && (ManufactorerCheckedListBox.CheckedItems.Count == 0))
            {
                ColorFilter();
                FilteredDevices = ColorDevices;
            }

            // DeviceType Filter
            if (DeviceTypeCheckedListBox.CheckedItems.Count != 0)
            {
                DeviceTypeFilter();
                FilteredDevices = TypeDevices;
            }

            if ((!String.IsNullOrEmpty(PriceFromTextBox.Text)) && (!String.IsNullOrEmpty(PriceToTextBox.Text)))
            {
                int PriceFrom = Convert.ToInt32(PriceFromTextBox.Text);
                int PriceTo = Convert.ToInt32(PriceToTextBox.Text);

                if (FilteredDevices.Count != 0)
                {
                    foreach (var DeviceItem in FilteredDevices)
                    {
                        if ((DeviceItem.Price >= PriceFrom) && (DeviceItem.Price <= PriceTo))
                        {
                            PriceDevices.Add(DeviceItem);
                        }
                    }
                }
                else
                {
                    foreach (var DeviceItem in Devices)
                    {
                        if ((DeviceItem.Price >= PriceFrom) && (DeviceItem.Price <= PriceTo))
                        {
                            PriceDevices.Add(DeviceItem);
                        }
                    }
                }
                FilteredDevices = PriceDevices;
            }
            if ((!String.IsNullOrEmpty(PriceFromTextBox.Text)) && (String.IsNullOrEmpty(PriceToTextBox.Text)))
            {
                int PriceFrom = Convert.ToInt32(PriceFromTextBox.Text);

                if (FilteredDevices.Count != 0)
                {
                    foreach (var DeviceItem in FilteredDevices)
                    {
                        if (DeviceItem.Price >= PriceFrom)
                        {
                            PriceDevices.Add(DeviceItem);
                        }
                    }
                }
                else
                {
                    foreach (var DeviceItem in Devices)
                    {
                        if (DeviceItem.Price >= PriceFrom)
                        {
                            PriceDevices.Add(DeviceItem);
                        }
                    }
                }
                FilteredDevices = PriceDevices;
            }
            if ((!String.IsNullOrEmpty(PriceToTextBox.Text)) && (String.IsNullOrEmpty(PriceFromTextBox.Text)))
            {
                int PriceTo = Convert.ToInt32(PriceToTextBox.Text);

                if (FilteredDevices.Count != 0)
                {
                    foreach (var DeviceItem in FilteredDevices)
                    {
                        if (DeviceItem.Price <= PriceTo)
                        {
                            PriceDevices.Add(DeviceItem);
                        }
                    }
                }
                else
                {
                    foreach (var DeviceItem in Devices)
                    {
                        if (DeviceItem.Price <= PriceTo)
                        {
                            PriceDevices.Add(DeviceItem);
                        }
                    }
                }
                FilteredDevices = PriceDevices;
            }
        }

        private void ManufactorerFilter()
        {
            foreach (string ManufactorerItem in ManufactorerCheckedListBox.CheckedItems)
            {
                foreach (var Device in Devices)
                {
                    if (ManufactorerItem == Device.Manufacturer.ToUpper())
                    {
                        ManufactorerDevices.Add(Device);
                    }
                }
            }
        }

        private void ColorFilter()
        {
            foreach (string ColorItem in ColorCheckedListBox.CheckedItems)
            {
                foreach (var Device in Devices)
                {
                    if (ColorItem == Device.Color)
                    {
                        ColorDevices.Add(Device);
                    }
                }
            }
        }

        private void DeviceTypeFilter()
        {
            if (FilteredDevices.Count != 0)
            {
                foreach (string CheckedListBoxItem in DeviceTypeCheckedListBox.CheckedItems)
                {
                    if (CheckedListBoxItem == "Fridge")
                    {
                        foreach (var DeviceItem in FilteredDevices)
                        {
                            if (DeviceItem.GetType() == typeof(Fridge))
                            {
                                Fridge NewFridge = (Fridge)Convert.ChangeType(DeviceItem, typeof(Fridge));
                                TypeDevices.Add(NewFridge);
                            }
                        }
                    }
                    else if (CheckedListBoxItem == "Freezer")
                    {
                        foreach (var DeviceItem in FilteredDevices)
                        {
                            if (DeviceItem.GetType() == typeof(Freezer))
                            {
                                Freezer NewFreezer = (Freezer)Convert.ChangeType(DeviceItem, typeof(Freezer));
                                TypeDevices.Add(NewFreezer);
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (string CheckedListBoxItem in DeviceTypeCheckedListBox.CheckedItems)
                {
                    if (CheckedListBoxItem == "Fridge")
                    {
                        foreach (var DeviceItem in Devices)
                        {
                            if (DeviceItem.GetType() == typeof(Fridge))
                            {
                                Fridge NewFridge = (Fridge)Convert.ChangeType(DeviceItem, typeof(Fridge));
                                TypeDevices.Add(NewFridge);
                            }
                        }
                    }
                    else if (CheckedListBoxItem == "Freezer")
                    {
                        foreach (var DeviceItem in Devices)
                        {
                            if (DeviceItem.GetType() == typeof(Freezer))
                            {
                                Freezer NewFreezer = (Freezer)Convert.ChangeType(DeviceItem, typeof(Freezer));
                                TypeDevices.Add(NewFreezer);
                            }
                        }
                    }
                }
            }
        }
    }
}
