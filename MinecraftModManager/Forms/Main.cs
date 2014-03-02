using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BrightIdeasSoftware;
using MinecraftModManager.Properties;

namespace MinecraftModManager
{
    public partial class Main : Form
    {
        public Main()
        {
            ImageList ratingIcons = new ImageList();
            ratingIcons.Images.Add("norating", Resources.star_outlined_alt);
            ratingIcons.Images.Add("star", Resources.star_alt);


            InitializeComponent();
            getMainPage();
        }

        #region ObjectListView methods

        public void getMainPage()
        {
            this.toolStripStatusLabel.Text = "Getting front page...";
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            //Making groups...
            this.modNameColumn.GroupFormatter = delegate(OLVGroup row, GroupingParameters j) {
                row.TitleImage = Resources.book;
            };

            this.modNameColumn.GroupKeyGetter = delegate(object row) {
                ModDatabaseItem item = (ModDatabaseItem)row;
                return item.Tags.Exists(x => x == "featured") ? "Featured" : "Hot";
            };

            

            //Downloads column
            this.modDownloadsColumn.AspectToStringConverter = delegate(object row) {
                long downloads = (long)row;


                if (downloads >= 1000000) return String.Format("{0:#,##0.#}" + "m", ((double)downloads / 1000000));
                else if (downloads >= 1000) return String.Format("{0:#,##0.#}" + "k", ((double)downloads / 1000));
                else return String.Format("{0}", downloads);
            };

            //Rating column
            this.modRatingColumn.Renderer = new ImageRenderer();
            this.modRatingColumn.AspectGetter = delegate(object row) {
                ModDatabaseItem item = (ModDatabaseItem)row;
                List<Image> imageList = new List<Image>();

                byte starsUsed = 1;
                //Adds filled-in stars to the list
                for (; starsUsed <= item.Rating; starsUsed++) {
                    imageList.Add(Resources.star);
                }
                //Fills in the rest with outlined stars
                while (starsUsed <= 5) {
                    imageList.Add(Resources.star_empty);
                    starsUsed++;
                }
                return imageList;
            };

            this.modsObjectListView.SetObjects(ModDatabaseItem.getList());

            this.Cursor = Cursors.Default;
            this.Enabled = true;
            this.toolStripStatusLabel.Text = "Ready";
        }

        #endregion

        #region Events

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Help_Click(object sender, EventArgs e)
        {
            ///TODO
            System.Diagnostics.Process.Start("http://mods.clockworks.net/help");
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItemRefresh_Click(object sender, EventArgs e)
        {
            getMainPage();
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                //TODO: search function
            }
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            Form about = new About();
            about.ShowDialog();
        }


        #endregion

        private void menuItemToggleAero_Click(object sender, EventArgs e)
        {
            menuItemToggleAero.Checked = !menuItemToggleAero.Checked;

            if (menuItemToggleAero.Checked) Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
            else Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.ClientAndNonClientAreasEnabled;
        }

        private void modsObjectListView_DoubleClick(object sender, EventArgs e)
        {
            if(this.modsObjectListView.SelectedObject != null)
            new ModInfo((ModDatabaseItem)this.modsObjectListView.SelectedObject).ShowDialog();
        }

        private void Mods_Click(object sender, EventArgs e)
        {
            new InstalledMods().Show();
        }

        private void menuItemReportBug_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.github.com/oldmud0/installercraft/issues/");
        }


    }
}
