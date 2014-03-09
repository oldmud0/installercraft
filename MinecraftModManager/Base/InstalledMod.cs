using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinecraftModManager
{
    class InstalledMod : Mod
    {

        public bool Enabled { get; set; }

        public void moveToTemp()
        {
            //Move the mod somewhere else
        }

        public void moveFromTemp()
        {
            //Install the mod
        }

        public void uninstall()
        {
            Enabled = false;
            //Delete the mod from filesystem
            InstalledModsList.ActiveInstalledModsList.Remove(this); //Remove the mod from the installed mods list
        }

        public void checkForUpdates()
        {
            //Check for updates to the mod. If version changed, then install the new version
        }
    }
}
