using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace AppMultiTool.Utils.Controllers
{
    public static class MachineController
    {
        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const uint MOUSEEVENTF_RIGHTUP = 0x10;
        private const uint MOUSEEVENTF_WHEEL = 0x0800;
        private const int WHEEL_DELTA = 120;
        private const int KEYEVENTF_KEYDOWN = 0x0000;
        private const int KEYEVENTF_KEYUP = 0x0002;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, nuint dwExtraInfo);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, nuint dwExtraInfo);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(uint dwFlags, int dx, int dy, uint cButtons, uint dwExtraInfo);

        public static void MouseClick(MouseClickType type)
        {
            MouseClickDown(type);
            MouseClickUp(type);
        }

        public static void MouseClickPosition(Point position)
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, position.X, position.Y, 0, 0);
        }

        public static void MouseClickDown(MouseClickType type)
        {
            uint mouseConst = type == MouseClickType.LeftClick ? MOUSEEVENTF_LEFTDOWN : MOUSEEVENTF_RIGHTDOWN;
            mouse_event(mouseConst, 0, 0, 0, nuint.Zero);
        }

        public static void MouseClickUp(MouseClickType type)
        {
            uint mouseConst = type == MouseClickType.LeftClick ? MOUSEEVENTF_LEFTUP : MOUSEEVENTF_RIGHTUP;
            mouse_event(mouseConst, 0, 0, 0, nuint.Zero);
        }

        public static void ScrollScreen(Direction dir)
        {
            int direction = dir == Direction.Up ? 1 : -1;
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, (uint)(direction * WHEEL_DELTA), nuint.Zero);
        }

        public static void PressKey(Keys key)
        {
            keybd_event((byte)key, 0, KEYEVENTF_KEYDOWN, nuint.Zero);
            keybd_event((byte)key, 0, KEYEVENTF_KEYUP, nuint.Zero);
        }

        public static void PressControlPlusKey(Keys key)
        {
            keybd_event((byte)Keys.LControlKey, 0, KEYEVENTF_KEYDOWN, nuint.Zero);

            keybd_event((byte)key, 0, KEYEVENTF_KEYDOWN, nuint.Zero);
            keybd_event((byte)key, 0, KEYEVENTF_KEYUP, nuint.Zero);

            keybd_event((byte)Keys.LControlKey, 0, KEYEVENTF_KEYUP, nuint.Zero);
        }
    }

    public enum MouseClickType
    {
        LeftClick,
        RightClick
    }
}
