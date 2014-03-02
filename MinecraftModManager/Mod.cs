using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinecraftModManager
{
    public class Mod
    {
        public long ID {get; set;}

        public string Name {get; set;}

        public string Author {get; set;}

        public DateTime LastUpdate {get; set;}

        public string MinecraftVersion {get; set;}

        public string DownloadURI { get; set; }

        public string ModURI { get; set; }

        public string Description {get; set;}

        public Mod()
        {

        }

    }
}
