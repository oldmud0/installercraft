using System;
using System.Windows.Forms;

namespace MinecraftModManager
{
    public partial class InstalledMods : Form
    {
        public InstalledMods()
        {
            InitializeComponent();
        }

        private void menuItemEnabled_Click(object sender, EventArgs e)
        {
            InstalledMod mod = (InstalledMod)this.objectListViewInstalledMods.SelectedObject;
            if (mod == null) return;

            menuItemEnabled.Checked = !menuItemEnabled.Checked;
            mod.Enabled = menuItemEnabled.Checked;
            if (mod.Enabled) mod.moveFromTemp();
            else mod.moveToTemp();
        }

        private void menuItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
