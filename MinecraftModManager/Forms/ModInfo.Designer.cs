namespace MinecraftModManager
{
    partial class ModInfo
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
            this.pictureBoxModIcon = new System.Windows.Forms.PictureBox();
            this.labelModName = new System.Windows.Forms.Label();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.labelModDescription = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelDownloads = new System.Windows.Forms.Label();
            this.textBoxDownloads = new System.Windows.Forms.TextBox();
            this.labelModRating = new System.Windows.Forms.Label();
            this.labelModAuthor = new System.Windows.Forms.Label();
            this.labelModVersion = new System.Windows.Forms.Label();
            this.linkLabelModLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxModIcon
            // 
            this.pictureBoxModIcon.Image = global::MinecraftModManager.Properties.Resources.mod_default;
            this.pictureBoxModIcon.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxModIcon.Name = "pictureBoxModIcon";
            this.pictureBoxModIcon.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxModIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxModIcon.TabIndex = 0;
            this.pictureBoxModIcon.TabStop = false;
            // 
            // labelModName
            // 
            this.labelModName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelModName.AutoEllipsis = true;
            this.labelModName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModName.Location = new System.Drawing.Point(82, 24);
            this.labelModName.Name = "labelModName";
            this.labelModName.Size = new System.Drawing.Size(507, 25);
            this.labelModName.TabIndex = 1;
            this.labelModName.Text = "Mod Name";
            this.labelModName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonInstall
            // 
            this.buttonInstall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInstall.Location = new System.Drawing.Point(12, 360);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(577, 44);
            this.buttonInstall.TabIndex = 2;
            this.buttonInstall.Text = "Install";
            this.buttonInstall.UseVisualStyleBackColor = true;
            // 
            // labelModDescription
            // 
            this.labelModDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelModDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelModDescription.Location = new System.Drawing.Point(13, 98);
            this.labelModDescription.Multiline = true;
            this.labelModDescription.Name = "labelModDescription";
            this.labelModDescription.ReadOnly = true;
            this.labelModDescription.Size = new System.Drawing.Size(576, 178);
            this.labelModDescription.TabIndex = 3;
            this.labelModDescription.Text = "No mod description.";
            // 
            // labelID
            // 
            this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(21, 282);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(24, 13);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "ID: ";
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxID.CausesValidation = false;
            this.textBoxID.Location = new System.Drawing.Point(51, 279);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(117, 20);
            this.textBoxID.TabIndex = 5;
            this.textBoxID.Text = "???";
            // 
            // labelDownloads
            // 
            this.labelDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDownloads.AutoSize = true;
            this.labelDownloads.Location = new System.Drawing.Point(21, 308);
            this.labelDownloads.Name = "labelDownloads";
            this.labelDownloads.Size = new System.Drawing.Size(63, 13);
            this.labelDownloads.TabIndex = 4;
            this.labelDownloads.Text = "Downloads:";
            // 
            // textBoxDownloads
            // 
            this.textBoxDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxDownloads.CausesValidation = false;
            this.textBoxDownloads.Location = new System.Drawing.Point(87, 305);
            this.textBoxDownloads.Name = "textBoxDownloads";
            this.textBoxDownloads.ReadOnly = true;
            this.textBoxDownloads.Size = new System.Drawing.Size(81, 20);
            this.textBoxDownloads.TabIndex = 5;
            this.textBoxDownloads.Text = "???";
            // 
            // labelModRating
            // 
            this.labelModRating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelModRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModRating.Location = new System.Drawing.Point(496, 51);
            this.labelModRating.Name = "labelModRating";
            this.labelModRating.Size = new System.Drawing.Size(93, 26);
            this.labelModRating.TabIndex = 6;
            this.labelModRating.Text = "? / 5";
            this.labelModRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelModAuthor
            // 
            this.labelModAuthor.AutoEllipsis = true;
            this.labelModAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModAuthor.Location = new System.Drawing.Point(82, 51);
            this.labelModAuthor.Name = "labelModAuthor";
            this.labelModAuthor.Size = new System.Drawing.Size(408, 25);
            this.labelModAuthor.TabIndex = 1;
            this.labelModAuthor.Text = "by ???";
            this.labelModAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelModVersion
            // 
            this.labelModVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelModVersion.Location = new System.Drawing.Point(441, 312);
            this.labelModVersion.Name = "labelModVersion";
            this.labelModVersion.Size = new System.Drawing.Size(148, 13);
            this.labelModVersion.TabIndex = 4;
            this.labelModVersion.Text = "Works in an unknown version";
            this.labelModVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabelModLink
            // 
            this.linkLabelModLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelModLink.AutoSize = true;
            this.linkLabelModLink.Location = new System.Drawing.Point(505, 286);
            this.linkLabelModLink.Name = "linkLabelModLink";
            this.linkLabelModLink.Size = new System.Drawing.Size(84, 13);
            this.linkLabelModLink.TabIndex = 7;
            this.linkLabelModLink.TabStop = true;
            this.linkLabelModLink.Text = "Author\'s website";
            this.linkLabelModLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabelModLink.Click += new System.EventHandler(this.linkLabelModLink_Click);
            // 
            // ModInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 416);
            this.Controls.Add(this.linkLabelModLink);
            this.Controls.Add(this.labelModRating);
            this.Controls.Add(this.textBoxDownloads);
            this.Controls.Add(this.labelModVersion);
            this.Controls.Add(this.labelDownloads);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelModDescription);
            this.Controls.Add(this.buttonInstall);
            this.Controls.Add(this.labelModAuthor);
            this.Controls.Add(this.labelModName);
            this.Controls.Add(this.pictureBoxModIcon);
            this.Icon = global::MinecraftModManager.Properties.Resources.InstallerCraft;
            this.MaximizeBox = false;
            this.Name = "ModInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Mod information";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxModIcon;
        private System.Windows.Forms.Label labelModName;
        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.TextBox labelModDescription;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelDownloads;
        private System.Windows.Forms.TextBox textBoxDownloads;
        private System.Windows.Forms.Label labelModRating;
        private System.Windows.Forms.Label labelModAuthor;
        private System.Windows.Forms.Label labelModVersion;
        private System.Windows.Forms.LinkLabel linkLabelModLink;
    }
}