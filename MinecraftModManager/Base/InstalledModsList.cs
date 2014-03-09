using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace MinecraftModManager
{
    class InstalledModsList
    {
        public static List<InstalledMod> ActiveInstalledModsList = new List<InstalledMod>();

        public static void importModsList(string path)
        {

        }

        public static void clearAllMods()
        {

            foreach (InstalledMod mod in ActiveInstalledModsList) {
                mod.uninstall();
            }

        }
    }
}
