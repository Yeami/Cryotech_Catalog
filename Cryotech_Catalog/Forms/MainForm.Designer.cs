﻿namespace Cryotech_Catalog
{
    partial class CryotechMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CryotechMainForm));
            this.AddFreezerTile = new MetroFramework.Controls.MetroTile();
            this.AddFridgeTile = new MetroFramework.Controls.MetroTile();
            this.SaveDataTile = new MetroFramework.Controls.MetroTile();
            this.DeviceViewPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DeviceFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.ColorCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.FilterColorLabel = new MetroFramework.Controls.MetroLabel();
            this.PriceToTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PriceFromTextBox = new MetroFramework.Controls.MetroTextBox();
            this.FilterPriceDashLabel = new MetroFramework.Controls.MetroLabel();
            this.FilterPriceLabel = new MetroFramework.Controls.MetroLabel();
            this.ManufactorerCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.FilterManufacturerLabel = new MetroFramework.Controls.MetroLabel();
            this.FilterDeviceTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.DeviceTypeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.FilterPanelLabel = new MetroFramework.Controls.MetroLabel();
            this.FiltersApplyButton = new MetroFramework.Controls.MetroButton();
            this.DeviceTotalNumberLabel = new MetroFramework.Controls.MetroLabel();
            this.DeviceTotalNumberInfoLabel = new MetroFramework.Controls.MetroLabel();
            this.DisplayedDevicesInfoLabel = new MetroFramework.Controls.MetroLabel();
            this.DisplayedDevicesLabel = new MetroFramework.Controls.MetroLabel();
            this.FiltersUpdateButton = new MetroFramework.Controls.MetroButton();
            this.DeviceFilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddFreezerTile
            // 
            this.AddFreezerTile.ActiveControl = null;
            this.AddFreezerTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFreezerTile.Location = new System.Drawing.Point(544, 52);
            this.AddFreezerTile.Name = "AddFreezerTile";
            this.AddFreezerTile.Size = new System.Drawing.Size(204, 43);
            this.AddFreezerTile.TabIndex = 3;
            this.AddFreezerTile.Text = "Add Freezer";
            this.AddFreezerTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddFreezerTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AddFreezerTile.UseSelectable = true;
            this.AddFreezerTile.Click += new System.EventHandler(this.AddFreezerTile_Click);
            // 
            // AddFridgeTile
            // 
            this.AddFridgeTile.ActiveControl = null;
            this.AddFridgeTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFridgeTile.Location = new System.Drawing.Point(334, 52);
            this.AddFridgeTile.Name = "AddFridgeTile";
            this.AddFridgeTile.Size = new System.Drawing.Size(204, 43);
            this.AddFridgeTile.TabIndex = 4;
            this.AddFridgeTile.Text = "Add Fridge";
            this.AddFridgeTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddFridgeTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AddFridgeTile.UseSelectable = true;
            this.AddFridgeTile.Click += new System.EventHandler(this.AddFridgeTile_Click);
            // 
            // SaveDataTile
            // 
            this.SaveDataTile.ActiveControl = null;
            this.SaveDataTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveDataTile.Location = new System.Drawing.Point(754, 52);
            this.SaveDataTile.Name = "SaveDataTile";
            this.SaveDataTile.Size = new System.Drawing.Size(204, 43);
            this.SaveDataTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.SaveDataTile.TabIndex = 5;
            this.SaveDataTile.Text = "Save Data";
            this.SaveDataTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveDataTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.SaveDataTile.UseSelectable = true;
            this.SaveDataTile.Click += new System.EventHandler(this.SaveDataTile_Click);
            // 
            // DeviceViewPanel
            // 
            this.DeviceViewPanel.AutoScroll = true;
            this.DeviceViewPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.DeviceViewPanel.Location = new System.Drawing.Point(331, 102);
            this.DeviceViewPanel.Name = "DeviceViewPanel";
            this.DeviceViewPanel.Size = new System.Drawing.Size(885, 521);
            this.DeviceViewPanel.TabIndex = 8;
            this.DeviceViewPanel.WrapContents = false;
            // 
            // DeviceFilterGroupBox
            // 
            this.DeviceFilterGroupBox.Controls.Add(this.ColorCheckedListBox);
            this.DeviceFilterGroupBox.Controls.Add(this.FilterColorLabel);
            this.DeviceFilterGroupBox.Controls.Add(this.PriceToTextBox);
            this.DeviceFilterGroupBox.Controls.Add(this.PriceFromTextBox);
            this.DeviceFilterGroupBox.Controls.Add(this.FilterPriceDashLabel);
            this.DeviceFilterGroupBox.Controls.Add(this.FilterPriceLabel);
            this.DeviceFilterGroupBox.Controls.Add(this.ManufactorerCheckedListBox);
            this.DeviceFilterGroupBox.Controls.Add(this.FilterManufacturerLabel);
            this.DeviceFilterGroupBox.Controls.Add(this.FilterDeviceTypeLabel);
            this.DeviceFilterGroupBox.Controls.Add(this.DeviceTypeCheckedListBox);
            this.DeviceFilterGroupBox.Location = new System.Drawing.Point(24, 132);
            this.DeviceFilterGroupBox.Name = "DeviceFilterGroupBox";
            this.DeviceFilterGroupBox.Size = new System.Drawing.Size(267, 493);
            this.DeviceFilterGroupBox.TabIndex = 10;
            this.DeviceFilterGroupBox.TabStop = false;
            // 
            // ColorCheckedListBox
            // 
            this.ColorCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ColorCheckedListBox.CheckOnClick = true;
            this.ColorCheckedListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorCheckedListBox.ForeColor = System.Drawing.Color.Black;
            this.ColorCheckedListBox.FormattingEnabled = true;
            this.ColorCheckedListBox.Location = new System.Drawing.Point(5, 357);
            this.ColorCheckedListBox.Name = "ColorCheckedListBox";
            this.ColorCheckedListBox.Size = new System.Drawing.Size(255, 112);
            this.ColorCheckedListBox.TabIndex = 104;
            // 
            // FilterColorLabel
            // 
            this.FilterColorLabel.AutoSize = true;
            this.FilterColorLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.FilterColorLabel.Location = new System.Drawing.Point(8, 329);
            this.FilterColorLabel.Name = "FilterColorLabel";
            this.FilterColorLabel.Size = new System.Drawing.Size(58, 25);
            this.FilterColorLabel.TabIndex = 103;
            this.FilterColorLabel.Text = "Color:";
            // 
            // PriceToTextBox
            // 
            // 
            // 
            // 
            this.PriceToTextBox.CustomButton.Image = null;
            this.PriceToTextBox.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.PriceToTextBox.CustomButton.Name = "";
            this.PriceToTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PriceToTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PriceToTextBox.CustomButton.TabIndex = 1;
            this.PriceToTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PriceToTextBox.CustomButton.UseSelectable = true;
            this.PriceToTextBox.CustomButton.Visible = false;
            this.PriceToTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PriceToTextBox.Lines = new string[0];
            this.PriceToTextBox.Location = new System.Drawing.Point(147, 138);
            this.PriceToTextBox.MaxLength = 32767;
            this.PriceToTextBox.Name = "PriceToTextBox";
            this.PriceToTextBox.PasswordChar = '\0';
            this.PriceToTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PriceToTextBox.SelectedText = "";
            this.PriceToTextBox.SelectionLength = 0;
            this.PriceToTextBox.SelectionStart = 0;
            this.PriceToTextBox.ShortcutsEnabled = true;
            this.PriceToTextBox.Size = new System.Drawing.Size(115, 23);
            this.PriceToTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.PriceToTextBox.TabIndex = 102;
            this.PriceToTextBox.UseSelectable = true;
            this.PriceToTextBox.UseStyleColors = true;
            this.PriceToTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PriceToTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PriceToTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PriceToTextBox_Validating);
            // 
            // PriceFromTextBox
            // 
            // 
            // 
            // 
            this.PriceFromTextBox.CustomButton.Image = null;
            this.PriceFromTextBox.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.PriceFromTextBox.CustomButton.Name = "";
            this.PriceFromTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PriceFromTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PriceFromTextBox.CustomButton.TabIndex = 1;
            this.PriceFromTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PriceFromTextBox.CustomButton.UseSelectable = true;
            this.PriceFromTextBox.CustomButton.Visible = false;
            this.PriceFromTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PriceFromTextBox.Lines = new string[0];
            this.PriceFromTextBox.Location = new System.Drawing.Point(6, 138);
            this.PriceFromTextBox.MaxLength = 32767;
            this.PriceFromTextBox.Name = "PriceFromTextBox";
            this.PriceFromTextBox.PasswordChar = '\0';
            this.PriceFromTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PriceFromTextBox.SelectedText = "";
            this.PriceFromTextBox.SelectionLength = 0;
            this.PriceFromTextBox.SelectionStart = 0;
            this.PriceFromTextBox.ShortcutsEnabled = true;
            this.PriceFromTextBox.Size = new System.Drawing.Size(115, 23);
            this.PriceFromTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.PriceFromTextBox.TabIndex = 101;
            this.PriceFromTextBox.UseSelectable = true;
            this.PriceFromTextBox.UseStyleColors = true;
            this.PriceFromTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PriceFromTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PriceFromTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PriceFromTextBox_Validating);
            // 
            // FilterPriceDashLabel
            // 
            this.FilterPriceDashLabel.AutoSize = true;
            this.FilterPriceDashLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.FilterPriceDashLabel.Location = new System.Drawing.Point(120, 136);
            this.FilterPriceDashLabel.Name = "FilterPriceDashLabel";
            this.FilterPriceDashLabel.Size = new System.Drawing.Size(29, 25);
            this.FilterPriceDashLabel.TabIndex = 100;
            this.FilterPriceDashLabel.Text = " - ";
            // 
            // FilterPriceLabel
            // 
            this.FilterPriceLabel.AutoSize = true;
            this.FilterPriceLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.FilterPriceLabel.Location = new System.Drawing.Point(5, 111);
            this.FilterPriceLabel.Name = "FilterPriceLabel";
            this.FilterPriceLabel.Size = new System.Drawing.Size(53, 25);
            this.FilterPriceLabel.TabIndex = 15;
            this.FilterPriceLabel.Text = "Price:";
            // 
            // ManufactorerCheckedListBox
            // 
            this.ManufactorerCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ManufactorerCheckedListBox.CheckOnClick = true;
            this.ManufactorerCheckedListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufactorerCheckedListBox.ForeColor = System.Drawing.Color.Black;
            this.ManufactorerCheckedListBox.FormattingEnabled = true;
            this.ManufactorerCheckedListBox.Location = new System.Drawing.Point(5, 209);
            this.ManufactorerCheckedListBox.Name = "ManufactorerCheckedListBox";
            this.ManufactorerCheckedListBox.Size = new System.Drawing.Size(255, 112);
            this.ManufactorerCheckedListBox.TabIndex = 14;
            // 
            // FilterManufacturerLabel
            // 
            this.FilterManufacturerLabel.AutoSize = true;
            this.FilterManufacturerLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.FilterManufacturerLabel.Location = new System.Drawing.Point(5, 181);
            this.FilterManufacturerLabel.Name = "FilterManufacturerLabel";
            this.FilterManufacturerLabel.Size = new System.Drawing.Size(119, 25);
            this.FilterManufacturerLabel.TabIndex = 13;
            this.FilterManufacturerLabel.Text = "Manufacturer:";
            // 
            // FilterDeviceTypeLabel
            // 
            this.FilterDeviceTypeLabel.AutoSize = true;
            this.FilterDeviceTypeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.FilterDeviceTypeLabel.Location = new System.Drawing.Point(6, 14);
            this.FilterDeviceTypeLabel.Name = "FilterDeviceTypeLabel";
            this.FilterDeviceTypeLabel.Size = new System.Drawing.Size(105, 25);
            this.FilterDeviceTypeLabel.TabIndex = 12;
            this.FilterDeviceTypeLabel.Text = "Device Type:";
            // 
            // DeviceTypeCheckedListBox
            // 
            this.DeviceTypeCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeviceTypeCheckedListBox.CheckOnClick = true;
            this.DeviceTypeCheckedListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceTypeCheckedListBox.ForeColor = System.Drawing.Color.Black;
            this.DeviceTypeCheckedListBox.FormattingEnabled = true;
            this.DeviceTypeCheckedListBox.Items.AddRange(new object[] {
            "Fridge",
            "Freezer"});
            this.DeviceTypeCheckedListBox.Location = new System.Drawing.Point(6, 42);
            this.DeviceTypeCheckedListBox.Name = "DeviceTypeCheckedListBox";
            this.DeviceTypeCheckedListBox.Size = new System.Drawing.Size(255, 56);
            this.DeviceTypeCheckedListBox.TabIndex = 0;
            // 
            // FilterPanelLabel
            // 
            this.FilterPanelLabel.AutoSize = true;
            this.FilterPanelLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.FilterPanelLabel.Location = new System.Drawing.Point(23, 70);
            this.FilterPanelLabel.Name = "FilterPanelLabel";
            this.FilterPanelLabel.Size = new System.Drawing.Size(153, 25);
            this.FilterPanelLabel.TabIndex = 11;
            this.FilterPanelLabel.Text = "Device Filter Panel:";
            // 
            // FiltersApplyButton
            // 
            this.FiltersApplyButton.Location = new System.Drawing.Point(161, 103);
            this.FiltersApplyButton.Name = "FiltersApplyButton";
            this.FiltersApplyButton.Size = new System.Drawing.Size(130, 23);
            this.FiltersApplyButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FiltersApplyButton.TabIndex = 12;
            this.FiltersApplyButton.Text = "Apply";
            this.FiltersApplyButton.UseSelectable = true;
            this.FiltersApplyButton.UseStyleColors = true;
            this.FiltersApplyButton.Click += new System.EventHandler(this.FiltersApplyButton_Click);
            // 
            // DeviceTotalNumberLabel
            // 
            this.DeviceTotalNumberLabel.AutoSize = true;
            this.DeviceTotalNumberLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.DeviceTotalNumberLabel.Location = new System.Drawing.Point(965, 45);
            this.DeviceTotalNumberLabel.Name = "DeviceTotalNumberLabel";
            this.DeviceTotalNumberLabel.Size = new System.Drawing.Size(132, 25);
            this.DeviceTotalNumberLabel.TabIndex = 13;
            this.DeviceTotalNumberLabel.Text = "Devices in Base:";
            // 
            // DeviceTotalNumberInfoLabel
            // 
            this.DeviceTotalNumberInfoLabel.AutoSize = true;
            this.DeviceTotalNumberInfoLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.DeviceTotalNumberInfoLabel.Location = new System.Drawing.Point(1103, 45);
            this.DeviceTotalNumberInfoLabel.Name = "DeviceTotalNumberInfoLabel";
            this.DeviceTotalNumberInfoLabel.Size = new System.Drawing.Size(41, 25);
            this.DeviceTotalNumberInfoLabel.TabIndex = 14;
            this.DeviceTotalNumberInfoLabel.Text = "Info";
            // 
            // DisplayedDevicesInfoLabel
            // 
            this.DisplayedDevicesInfoLabel.AutoSize = true;
            this.DisplayedDevicesInfoLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.DisplayedDevicesInfoLabel.Location = new System.Drawing.Point(1122, 70);
            this.DisplayedDevicesInfoLabel.Name = "DisplayedDevicesInfoLabel";
            this.DisplayedDevicesInfoLabel.Size = new System.Drawing.Size(41, 25);
            this.DisplayedDevicesInfoLabel.TabIndex = 16;
            this.DisplayedDevicesInfoLabel.Text = "Info";
            // 
            // DisplayedDevicesLabel
            // 
            this.DisplayedDevicesLabel.AutoSize = true;
            this.DisplayedDevicesLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.DisplayedDevicesLabel.Location = new System.Drawing.Point(965, 70);
            this.DisplayedDevicesLabel.Name = "DisplayedDevicesLabel";
            this.DisplayedDevicesLabel.Size = new System.Drawing.Size(151, 25);
            this.DisplayedDevicesLabel.TabIndex = 15;
            this.DisplayedDevicesLabel.Text = "Displayed Devices:";
            // 
            // FiltersUpdateButton
            // 
            this.FiltersUpdateButton.Location = new System.Drawing.Point(25, 103);
            this.FiltersUpdateButton.Name = "FiltersUpdateButton";
            this.FiltersUpdateButton.Size = new System.Drawing.Size(130, 23);
            this.FiltersUpdateButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FiltersUpdateButton.TabIndex = 17;
            this.FiltersUpdateButton.Text = "Update";
            this.FiltersUpdateButton.UseSelectable = true;
            this.FiltersUpdateButton.UseStyleColors = true;
            this.FiltersUpdateButton.Click += new System.EventHandler(this.FiltersUpdateButton_Click);
            // 
            // CryotechMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 650);
            this.Controls.Add(this.FiltersUpdateButton);
            this.Controls.Add(this.DisplayedDevicesInfoLabel);
            this.Controls.Add(this.DisplayedDevicesLabel);
            this.Controls.Add(this.DeviceTotalNumberInfoLabel);
            this.Controls.Add(this.DeviceTotalNumberLabel);
            this.Controls.Add(this.FiltersApplyButton);
            this.Controls.Add(this.FilterPanelLabel);
            this.Controls.Add(this.DeviceFilterGroupBox);
            this.Controls.Add(this.DeviceViewPanel);
            this.Controls.Add(this.SaveDataTile);
            this.Controls.Add(this.AddFridgeTile);
            this.Controls.Add(this.AddFreezerTile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CryotechMainForm";
            this.Resizable = false;
            this.Text = "Cryotech Catalog";
            this.Load += new System.EventHandler(this.CryotechMainForm_Load);
            this.DeviceFilterGroupBox.ResumeLayout(false);
            this.DeviceFilterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile AddFreezerTile;
        private MetroFramework.Controls.MetroTile AddFridgeTile;
        private MetroFramework.Controls.MetroTile SaveDataTile;
        private System.Windows.Forms.FlowLayoutPanel DeviceViewPanel;
        private System.Windows.Forms.GroupBox DeviceFilterGroupBox;
        private System.Windows.Forms.CheckedListBox DeviceTypeCheckedListBox;
        private MetroFramework.Controls.MetroLabel FilterPanelLabel;
        private System.Windows.Forms.CheckedListBox ManufactorerCheckedListBox;
        private MetroFramework.Controls.MetroLabel FilterManufacturerLabel;
        private MetroFramework.Controls.MetroLabel FilterDeviceTypeLabel;
        private MetroFramework.Controls.MetroLabel FilterPriceLabel;
        private MetroFramework.Controls.MetroTextBox PriceToTextBox;
        private MetroFramework.Controls.MetroTextBox PriceFromTextBox;
        private MetroFramework.Controls.MetroLabel FilterPriceDashLabel;
        private System.Windows.Forms.CheckedListBox ColorCheckedListBox;
        private MetroFramework.Controls.MetroLabel FilterColorLabel;
        private MetroFramework.Controls.MetroButton FiltersApplyButton;
        private MetroFramework.Controls.MetroLabel DeviceTotalNumberLabel;
        private MetroFramework.Controls.MetroLabel DeviceTotalNumberInfoLabel;
        private MetroFramework.Controls.MetroLabel DisplayedDevicesInfoLabel;
        private MetroFramework.Controls.MetroLabel DisplayedDevicesLabel;
        private MetroFramework.Controls.MetroButton FiltersUpdateButton;
    }
}

