using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMultiTool.Utils.GlobalItems
{
    public static class AppDataManager
    {
        public static string BasePath =>
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "AppMultiTool"
            );

        public static string ConfigPath => Path.Combine(BasePath, "AppSettings.config");

        public static string PlaylistsPath => Path.Combine(BasePath, "Playlists");

        public static void Initialize()
        {
            Directory.CreateDirectory(BasePath);
            Directory.CreateDirectory(PlaylistsPath);

            if (!File.Exists(ConfigPath))
            {
                string sourceConfig = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "AppSettings.config"
                );

                if (File.Exists(sourceConfig))
                    File.Copy(sourceConfig, ConfigPath);
            }
        }
    }
}
