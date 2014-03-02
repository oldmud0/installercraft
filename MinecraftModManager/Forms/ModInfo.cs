using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MinecraftModManager
{
    public partial class ModInfo : Form
    {
        private ModDatabaseItem mod;

        public ModInfo()
        {
            InitializeComponent();
        }

        public ModInfo(ModDatabaseItem mod)
        {
            this.mod = mod;
            InitializeComponent();
            SetModInfo();

        }

        private void SetModInfo()
        {
            labelModName.Text = mod.Name;
            labelModAuthor.Text = "by " + mod.Author;
            textBoxID.Text = mod.ID.ToString();
            labelModDescription.Text = mod.Description != null ? mod.Description : "No mod description.";
            labelModRating.Text = mod.Rating.ToString() + " / 5";
            labelModVersion.Text = "Works in " + mod.MinecraftVersion;
            textBoxDownloads.Text = mod.Downloads.ToString();
        }

        private void linkLabelModLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(mod.ModURI);
        }
    }
}
