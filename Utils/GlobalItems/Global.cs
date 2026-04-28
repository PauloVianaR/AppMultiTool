using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AppMultiTool.Models;
using MasterWindowsForms;

namespace AppMultiTool.Utils.GlobalItems
{
    public static class Global
    {
        public const string PyModulesPath = @"..\..\..\PyModules\";

        public static readonly string BasePath = AppDomain.CurrentDomain.BaseDirectory;
        public static readonly string MaterialPath = Path.Combine(BasePath, "Material");

        public static readonly string OAuthCredentialPath = Path.Combine(
            MaterialPath,
            "googlecredentials.json"
        );

        public static readonly string ffmpegPath = Path.Combine(
            MaterialPath,
            "ffmpeg.exe"
        );

        public static bool AllowCloseApp { get; set; } = true;
        public static InactivityMonitor InactivityMonitor { get; set; } = new();
        public static GlobalTimer GlobalTimer { get; set; } = new();
        public static InstanceForms Forms { get; set; } = new();

        public static void ResetAppQuestionMsg(string msg)
        {
            if (Master.ShowQuestionMessage(msg) == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }
    }
}
