using MinecraftModManager.Properties;
using MinecraftModManager;
namespace MinecraftModManager
{
    partial class Main
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.modsObjectListView = new BrightIdeasSoftware.ObjectListView();
            this.modNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.modAuthorColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.modRatingColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.modDownloadsColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.File = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.Mods = new System.Windows.Forms.MenuItem();
            this.Tools = new System.Windows.Forms.MenuItem();
            this.menuItemRefresh = new System.Windows.Forms.MenuItem();
            this.menuItemToggleAero = new System.Windows.Forms.MenuItem();
            this.Help = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItemReportBug = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.cueTextBox1 = new MinecraftModManager.CueTextBox();
            this.textBoxSearch = new MinecraftModManager.CueTextBox();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modsObjectListView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.modsObjectListView);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(610, 209);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 26);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(610, 256);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(610, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(200, 16);
            // 
            // modsObjectListView
            // 
            this.modsObjectListView.AllColumns.Add(this.modNameColumn);
            this.modsObjectListView.AllColumns.Add(this.modAuthorColumn);
            this.modsObjectListView.AllColumns.Add(this.modRatingColumn);
            this.modsObjectListView.AllColumns.Add(this.modDownloadsColumn);
            this.modsObjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.modNameColumn,
            this.modAuthorColumn,
            this.modRatingColumn,
            this.modDownloadsColumn});
            this.modsObjectListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modsObjectListView.FullRowSelect = true;
            this.modsObjectListView.Location = new System.Drawing.Point(0, 0);
            this.modsObjectListView.MultiSelect = false;
            this.modsObjectListView.Name = "modsObjectListView";
            this.modsObjectListView.OwnerDraw = true;
            this.modsObjectListView.Size = new System.Drawing.Size(610, 209);
            this.modsObjectListView.TabIndex = 0;
            this.modsObjectListView.UseCompatibleStateImageBehavior = false;
            this.modsObjectListView.View = System.Windows.Forms.View.Details;
            this.modsObjectListView.DoubleClick += new System.EventHandler(this.modsObjectListView_DoubleClick);
            // 
            // modNameColumn
            // 
            this.modNameColumn.AspectName = "Name";
            this.modNameColumn.CellPadding = null;
            this.modNameColumn.FillsFreeSpace = true;
            this.modNameColumn.Text = "Name";
            this.modNameColumn.Width = 286;
            // 
            // modAuthorColumn
            // 
            this.modAuthorColumn.AspectName = "Author";
            this.modAuthorColumn.CellPadding = null;
            this.modAuthorColumn.Text = "Author";
            this.modAuthorColumn.Width = 139;
            // 
            // modRatingColumn
            // 
            this.modRatingColumn.AspectName = "Rating";
            this.modRatingColumn.CellPadding = null;
            this.modRatingColumn.Text = "Rating";
            this.modRatingColumn.Width = 90;
            // 
            // modDownloadsColumn
            // 
            this.modDownloadsColumn.AspectName = "Downloads";
            this.modDownloadsColumn.CellPadding = null;
            this.modDownloadsColumn.Text = "Downloads";
            this.modDownloadsColumn.Width = 78;
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.File,
            this.Mods,
            this.Tools,
            this.Help});
            // 
            // File
            // 
            this.File.Index = 0;
            this.File.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3,
            this.menuItemExit});
            this.File.Text = "File";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.menuItem1.Text = "New Mod Profile...";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.menuItem2.Text = "Load Mod Profile...";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "-";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 3;
            this.menuItemExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // Mods
            // 
            this.Mods.Index = 1;
            this.Mods.Text = "Mods";
            this.Mods.Click += new System.EventHandler(this.Mods_Click);
            // 
            // Tools
            // 
            this.Tools.Index = 2;
            this.Tools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemRefresh,
            this.menuItemToggleAero});
            this.Tools.Text = "Tools";
            // 
            // menuItemRefresh
            // 
            this.menuItemRefresh.Index = 0;
            this.menuItemRefresh.Shortcut = System.Windows.Forms.Shortcut.F5;
            this.menuItemRefresh.Text = "Refresh";
            this.menuItemRefresh.Click += new System.EventHandler(this.menuItemRefresh_Click);
            // 
            // menuItemToggleAero
            // 
            this.menuItemToggleAero.Index = 1;
            this.menuItemToggleAero.Text = "Windows Aero sucks";
            this.menuItemToggleAero.Click += new System.EventHandler(this.menuItemToggleAero_Click);
            // 
            // Help
            // 
            this.Help.Index = 3;
            this.Help.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem8,
            this.menuItem9,
            this.menuItem10,
            this.menuItemReportBug,
            this.menuItem12,
            this.menuItem13,
            this.menuItemAbout});
            this.Help.Text = "Help";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 0;
            this.menuItem8.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.menuItem8.Text = "Help";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 1;
            this.menuItem9.Text = "-";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 2;
            this.menuItem10.Text = "Check for Updates";
            // 
            // menuItemReportBug
            // 
            this.menuItemReportBug.Index = 3;
            this.menuItemReportBug.Text = "Report a Bug...";
            this.menuItemReportBug.Click += new System.EventHandler(this.menuItemReportBug_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 4;
            this.menuItem12.Text = "-";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 5;
            this.menuItem13.Text = "Visit Website";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Index = 6;
            this.menuItemAbout.Text = "About";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // cueTextBox1
            // 
            this.cueTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cueTextBox1.Cue = "Search";
            this.cueTextBox1.Location = new System.Drawing.Point(0, 3);
            this.cueTextBox1.Name = "cueTextBox1";
            this.cueTextBox1.Size = new System.Drawing.Size(610, 20);
            this.cueTextBox1.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Cue = null;
            this.textBoxSearch.Location = new System.Drawing.Point(0, 0);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(610, 20);
            this.textBoxSearch.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 282);
            this.Controls.Add(this.cueTextBox1);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = global::MinecraftModManager.Properties.Resources.InstallerCraft;
            this.Menu = this.mainMenu;
            this.Name = "Main";
            this.Text = "Minecraft Mod Manager";
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modsObjectListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem File;
        private System.Windows.Forms.MenuItem Mods;
        private System.Windows.Forms.MenuItem Tools;
        private System.Windows.Forms.MenuItem Help;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItemExit;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItemReportBug;
        private System.Windows.Forms.MenuItem menuItemRefresh;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem menuItemAbout;
        private BrightIdeasSoftware.ObjectListView modsObjectListView;
        private BrightIdeasSoftware.OLVColumn modNameColumn;
        private BrightIdeasSoftware.OLVColumn modAuthorColumn;
        private BrightIdeasSoftware.OLVColumn modRatingColumn;
        private BrightIdeasSoftware.OLVColumn modDownloadsColumn;
        private MinecraftModManager.CueTextBox textBoxSearch;
        private CueTextBox cueTextBox1;
        private System.Windows.Forms.MenuItem menuItemToggleAero;
    }
}

