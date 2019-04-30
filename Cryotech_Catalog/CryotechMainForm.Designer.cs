namespace Cryotech_Catalog
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
            this.DeviceTabControl = new MetroFramework.Controls.MetroTabControl();
            this.FridgeTabPage = new System.Windows.Forms.TabPage();
            this.FreezerTabPage = new System.Windows.Forms.TabPage();
            this.AddFreezerTile = new MetroFramework.Controls.MetroTile();
            this.AddFridgeTile = new MetroFramework.Controls.MetroTile();
            this.SaveDataTile = new MetroFramework.Controls.MetroTile();
            this.DeviceViewPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DeviceTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeviceTabControl
            // 
            this.DeviceTabControl.Controls.Add(this.FridgeTabPage);
            this.DeviceTabControl.Controls.Add(this.FreezerTabPage);
            this.DeviceTabControl.Location = new System.Drawing.Point(23, 63);
            this.DeviceTabControl.Name = "DeviceTabControl";
            this.DeviceTabControl.SelectedIndex = 1;
            this.DeviceTabControl.Size = new System.Drawing.Size(272, 564);
            this.DeviceTabControl.TabIndex = 0;
            this.DeviceTabControl.UseSelectable = true;
            // 
            // FridgeTabPage
            // 
            this.FridgeTabPage.Location = new System.Drawing.Point(4, 38);
            this.FridgeTabPage.Name = "FridgeTabPage";
            this.FridgeTabPage.Size = new System.Drawing.Size(264, 522);
            this.FridgeTabPage.TabIndex = 0;
            this.FridgeTabPage.Text = "Refrigerators";
            // 
            // FreezerTabPage
            // 
            this.FreezerTabPage.Location = new System.Drawing.Point(4, 38);
            this.FreezerTabPage.Name = "FreezerTabPage";
            this.FreezerTabPage.Size = new System.Drawing.Size(264, 522);
            this.FreezerTabPage.TabIndex = 1;
            this.FreezerTabPage.Text = "Freezers";
            // 
            // AddFreezerTile
            // 
            this.AddFreezerTile.ActiveControl = null;
            this.AddFreezerTile.Location = new System.Drawing.Point(553, 52);
            this.AddFreezerTile.Name = "AddFreezerTile";
            this.AddFreezerTile.Size = new System.Drawing.Size(205, 43);
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
            this.AddFridgeTile.Location = new System.Drawing.Point(342, 52);
            this.AddFridgeTile.Name = "AddFridgeTile";
            this.AddFridgeTile.Size = new System.Drawing.Size(205, 43);
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
            this.SaveDataTile.Location = new System.Drawing.Point(764, 52);
            this.SaveDataTile.Name = "SaveDataTile";
            this.SaveDataTile.Size = new System.Drawing.Size(205, 43);
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
            this.DeviceViewPanel.Location = new System.Drawing.Point(342, 102);
            this.DeviceViewPanel.Name = "DeviceViewPanel";
            this.DeviceViewPanel.Size = new System.Drawing.Size(835, 521);
            this.DeviceViewPanel.TabIndex = 8;
            this.DeviceViewPanel.WrapContents = false;
            // 
            // CryotechMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.DeviceViewPanel);
            this.Controls.Add(this.SaveDataTile);
            this.Controls.Add(this.AddFridgeTile);
            this.Controls.Add(this.AddFreezerTile);
            this.Controls.Add(this.DeviceTabControl);
            this.MaximizeBox = false;
            this.Name = "CryotechMainForm";
            this.Text = "Cryotech Catalog";
            this.DeviceTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl DeviceTabControl;
        private System.Windows.Forms.TabPage FridgeTabPage;
        private System.Windows.Forms.TabPage FreezerTabPage;
        private MetroFramework.Controls.MetroTile AddFreezerTile;
        private MetroFramework.Controls.MetroTile AddFridgeTile;
        private MetroFramework.Controls.MetroTile SaveDataTile;
        private System.Windows.Forms.FlowLayoutPanel DeviceViewPanel;
    }
}

