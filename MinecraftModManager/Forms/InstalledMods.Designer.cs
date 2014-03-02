namespace MinecraftModManager
{
    partial class InstalledMods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenuInstalledMods = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItemImportMod = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItemClose = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItemDeleteMod = new System.Windows.Forms.MenuItem();
            this.menuItemCheckForUpdate = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItemEnabled = new System.Windows.Forms.MenuItem();
            this.objectListViewInstalledMods = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnVersion = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewInstalledMods)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuInstalledMods
            // 
            this.mainMenuInstalledMods.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemImportMod,
            this.menuItem4,
            this.menuItemClose});
            this.menuItem1.Text = "File";
            // 
            // menuItemImportMod
            // 
            this.menuItemImportMod.Index = 0;
            this.menuItemImportMod.Text = "Import Mod...";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "-";
            // 
            // menuItemClose
            // 
            this.menuItemClose.Index = 2;
            this.menuItemClose.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.menuItemClose.Text = "Close";
            this.menuItemClose.Click += new System.EventHandler(this.menuItemClose_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemDeleteMod,
            this.menuItemCheckForUpdate,
            this.menuItem3,
            this.menuItemEnabled});
            this.menuItem2.Text = "Mod";
            // 
            // menuItemDeleteMod
            // 
            this.menuItemDeleteMod.Index = 0;
            this.menuItemDeleteMod.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.menuItemDeleteMod.Text = "Delete";
            // 
            // menuItemCheckForUpdate
            // 
            this.menuItemCheckForUpdate.Index = 1;
            this.menuItemCheckForUpdate.Text = "Check for Update";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "-";
            // 
            // menuItemEnabled
            // 
            this.menuItemEnabled.Index = 3;
            this.menuItemEnabled.Text = "Enabled";
            this.menuItemEnabled.Click += new System.EventHandler(this.menuItemEnabled_Click);
            // 
            // objectListViewInstalledMods
            // 
            this.objectListViewInstalledMods.AllColumns.Add(this.olvColumnName);
            this.objectListViewInstalledMods.AllColumns.Add(this.olvColumnVersion);
            this.objectListViewInstalledMods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnName,
            this.olvColumnVersion});
            this.objectListViewInstalledMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListViewInstalledMods.Location = new System.Drawing.Point(0, 0);
            this.objectListViewInstalledMods.Name = "objectListViewInstalledMods";
            this.objectListViewInstalledMods.Size = new System.Drawing.Size(310, 375);
            this.objectListViewInstalledMods.TabIndex = 0;
            this.objectListViewInstalledMods.UseCompatibleStateImageBehavior = false;
            this.objectListViewInstalledMods.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnName
            // 
            this.olvColumnName.AspectName = "Name";
            this.olvColumnName.CellPadding = null;
            this.olvColumnName.IsEditable = false;
            this.olvColumnName.Text = "Name";
            this.olvColumnName.Width = 200;
            // 
            // olvColumnVersion
            // 
            this.olvColumnVersion.AspectName = "MinecraftVersion";
            this.olvColumnVersion.CellPadding = null;
            this.olvColumnVersion.FillsFreeSpace = true;
            this.olvColumnVersion.IsEditable = false;
            this.olvColumnVersion.Text = "Version";
            // 
            // InstalledMods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 375);
            this.Controls.Add(this.objectListViewInstalledMods);
            this.Icon = global::MinecraftModManager.Properties.Resources.InstallerCraft;
            this.MaximizeBox = false;
            this.Menu = this.mainMenuInstalledMods;
            this.Name = "InstalledMods";
            this.ShowInTaskbar = false;
            this.Text = "Installed Mods";
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewInstalledMods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenuInstalledMods;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private BrightIdeasSoftware.ObjectListView objectListViewInstalledMods;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
        private BrightIdeasSoftware.OLVColumn olvColumnVersion;
        private System.Windows.Forms.MenuItem menuItemImportMod;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItemClose;
        private System.Windows.Forms.MenuItem menuItemDeleteMod;
        private System.Windows.Forms.MenuItem menuItemCheckForUpdate;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItemEnabled;
    }
}