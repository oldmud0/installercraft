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
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemImportMod = new System.Windows.Forms.MenuItem();
            this.menuItemSep1 = new System.Windows.Forms.MenuItem();
            this.menuItemClose = new System.Windows.Forms.MenuItem();
            this.menuItemModsMenu = new System.Windows.Forms.MenuItem();
            this.menuItemDeleteMod = new System.Windows.Forms.MenuItem();
            this.menuItemCheckForUpdate = new System.Windows.Forms.MenuItem();
            this.menuItemSep2 = new System.Windows.Forms.MenuItem();
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
            this.menuItemFile,
            this.menuItemModsMenu});
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemImportMod,
            this.menuItemSep1,
            this.menuItemClose});
            this.menuItemFile.Text = "File";
            // 
            // menuItemImportMod
            // 
            this.menuItemImportMod.Index = 0;
            this.menuItemImportMod.Text = "Import Mod...";
            // 
            // menuItemSep1
            // 
            this.menuItemSep1.Index = 1;
            this.menuItemSep1.Text = "-";
            // 
            // menuItemClose
            // 
            this.menuItemClose.Index = 2;
            this.menuItemClose.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.menuItemClose.Text = "Close";
            this.menuItemClose.Click += new System.EventHandler(this.menuItemClose_Click);
            // 
            // menuItemModsMenu
            // 
            this.menuItemModsMenu.Index = 1;
            this.menuItemModsMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemDeleteMod,
            this.menuItemCheckForUpdate,
            this.menuItemSep2,
            this.menuItemEnabled});
            this.menuItemModsMenu.Text = "Mod";
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
            // menuItemSep2
            // 
            this.menuItemSep2.Index = 2;
            this.menuItemSep2.Text = "-";
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
            this.objectListViewInstalledMods.FullRowSelect = true;
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
        private System.Windows.Forms.MenuItem menuItemFile;
        private System.Windows.Forms.MenuItem menuItemModsMenu;
        private BrightIdeasSoftware.ObjectListView objectListViewInstalledMods;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
        private BrightIdeasSoftware.OLVColumn olvColumnVersion;
        private System.Windows.Forms.MenuItem menuItemImportMod;
        private System.Windows.Forms.MenuItem menuItemSep1;
        private System.Windows.Forms.MenuItem menuItemClose;
        private System.Windows.Forms.MenuItem menuItemDeleteMod;
        private System.Windows.Forms.MenuItem menuItemCheckForUpdate;
        private System.Windows.Forms.MenuItem menuItemSep2;
        private System.Windows.Forms.MenuItem menuItemEnabled;
    }
}