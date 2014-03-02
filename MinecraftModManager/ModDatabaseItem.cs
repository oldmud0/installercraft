using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using MinecraftModManager.Properties;

namespace MinecraftModManager
{
    public class ModDatabaseItem : Mod
    {
        public long Downloads { get; set; }

        public byte Rating { get; set; }

        public void setRatingFromFloatingPoint(double rating)
        {
            Rating = (byte)rating;
        }

        //In megabytes.
        public double Size { get; set; }

        public List<String> Tags { get; set; }

        public ModDatabaseItem()
            : base()
        {

        }

        internal static List<ModDatabaseItem> getList()
        {
            List<ModDatabaseItem> modList = new List<ModDatabaseItem>();
            modList.Add(new ModDatabaseItem() { 
                Author = "longbyte1",
                Downloads = 33123,
                ID = 1,
                LastUpdate = new DateTime(2013,11,20),
                DownloadURI = "http://localhost",
                ModURI = "about:blank",
                MinecraftVersion = "1.7.2",
                Name = "Cool Stuff Mod! [PLANES] [GUNS] [MORE]",
                Rating = 3,
                Size = 33,
                Tags = new List<string> { "featured", "cool", "planes" } 
            });
            modList.Add(new ModDatabaseItem() { 
                Author = "Foxfire",
                Downloads = 450244,
                ID = 2,
                LastUpdate = new DateTime(2013,7,15),
                DownloadURI = "http://localhost",
                ModURI = "about:blank",
                MinecraftVersion = "1.7.2",
                Name = "Voxel Mod",
                Rating = 5,
                Size = 33,
                Tags = new List<String> { "hot", "wolves", "electronics" }
            });
            modList.Add(new ModDatabaseItem() {
                Author = "cpw",
                Downloads = 107491,
                ID = 3,
                LastUpdate = new DateTime(2014, 2, 5),
                DownloadURI = "http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.7.2-10.12.0.1024/forge-1.7.2-10.12.0.1024-userdev.jar",
                ModURI = "http://www.minecraftforge.net/forum/index.php",
                MinecraftVersion = "1.7.2",
                Name = "Minecraft Forge",
                Rating = 5,
                Size = 33,
                Tags = new List<String> { "hot", "wolves", "electronics" }
            });
            modList.Add(new ModDatabaseItem() {
                Author = "dan200",
                Downloads = 1361285,
                ID = 3,
                LastUpdate = new DateTime(2013, 12, 09),
                DownloadURI = "http://www.curseforge.com/media/files/758/858/ComputerCraft1.58.zip",
                ModURI = "http://www.computercraft.info/",
                MinecraftVersion = "1.6.4",
                Name = "ComputerCraft",
                Rating = 4,
                Size = 1.1,
                Tags = new List<String> { "hot", "wolves", "electronics" },
                Description = 
                "ComputerCraft is a modification for Minecraft that’s all about computer programming. It allows you to build in-game Computers and Turtles, and write programs for them using the Lua programming language. " + 
                "The addition of programming to Minecraft opens up a wide variety of new possibilities for automation and creativity. If you’ve never programmed before, it also serves as excellent way to learn a real world skill in a fun, familiar environment.\n" + 
                "• Requires Minecraft Forge"
            });
            return modList;
        }
    }
}
