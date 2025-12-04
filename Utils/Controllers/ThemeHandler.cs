using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AppMultiTool.Utils.GlobalItems;

namespace AppMultiTool.Utils.Controllers
{
    public static class ThemeHandler
    {
        private readonly static Color darkColor = Color.FromArgb(20, 20, 20);

        private readonly static List<Color> ColorsWhiteList =
        [
            Color.Black,
            Color.White,
            SystemColors.Control,
            SystemColors.ControlText,
            SystemColors.WindowText,
            SystemColors.Window,
            SystemColors.WindowFrame
        ];

        public static void ApplyWhiteTheme(List<object> controls)
        {
            foreach (var item in controls)
            {
                if (item is Control control)
                {
                    control.ForeColor = ColorInWhiteList(control.ForeColor) ? Color.Black : control.ForeColor;
                    control.BackColor = ColorInWhiteList(control.BackColor) ? Color.White : control.BackColor;
                }
                else if (item is ToolStripItem tsmi)
                {
                    tsmi.ForeColor = ColorInWhiteList(tsmi.ForeColor) ? Color.Black : tsmi.ForeColor;
                    tsmi.BackColor = ColorInWhiteList(tsmi.BackColor) ? Color.White : tsmi.BackColor;
                }
            }
        }

        public static void ApplyDarkTheme(List<object> controls)
        {
            foreach (var item in controls)
            {
                if (item is Control control)
                {
                    control.ForeColor = ColorInWhiteList(control.ForeColor) ? Color.White : control.ForeColor;
                    control.BackColor = ColorInWhiteList(control.BackColor) ? darkColor : control.BackColor;
                }
                else if (item is ToolStripItem tsmi)
                {
                    tsmi.ForeColor = ColorInWhiteList(tsmi.ForeColor) ? Color.White : tsmi.ForeColor;
                    tsmi.BackColor = ColorInWhiteList(tsmi.BackColor) ? darkColor : tsmi.BackColor;
                }
            }
        }

        public static void ApplyTheme(List<object> controls, ThemeType type)
        {
            switch (type)
            {
                case ThemeType.White:
                    ApplyWhiteTheme(controls);
                    break;
                case ThemeType.Dark:
                    ApplyDarkTheme(controls);
                    break;
                default:
                    ApplyWhiteTheme(controls);
                    break;
            }
        }

        public static void ApplyWallPaper(List<Form> forms, WallPaper wpp) => forms.ForEach(form => ApplyWallPaper(form, wpp));

        public static void ApplyWallPaper(Form form, WallPaper wpp)
        {
            switch (wpp)
            {
                case WallPaper.None:
                    form.BackgroundImage = null;
                    break;
                case WallPaper.YellowHighTech:
                    form.BackgroundImage = Image.FromFile(Path.Combine(Global.MaterialPath, "wpp1.png"));
                    break;
                case WallPaper.Mandala:
                    form.BackgroundImage = Image.FromFile(Path.Combine(Global.MaterialPath, "wpp2.png"));
                    break;
                case WallPaper.BlueCircle:
                    form.BackgroundImage = Image.FromFile(Path.Combine(Global.MaterialPath, "wpp3.png"));
                    break;
            }

            form.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private static bool ColorInWhiteList(Color controlColor)
        {
            foreach (Color color in ColorsWhiteList)
            {
                if (color == controlColor)
                    return true;
            }

            return false;
        }
    }

    public enum ThemeType
    {
        None,
        White,
        Dark
    }

    public enum WallPaper
    {
        None,
        YellowHighTech,
        Mandala,
        BlueCircle
    }
}
