using FeebasBot.Classes;
using System;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FeebasBot
{
    public class getpixel
    {
        IntPtr otpHandle = win32.FindWindow("otPokemon", "otPokemon");
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowDC(IntPtr window);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern uint GetPixel(IntPtr dc, int x, int y);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr window, IntPtr dc);
        public static uint GetColorAt(IntPtr Handle, int x, int y)
        {
            /*IntPtr otpHandle = win32.FindWindow("otPokemon", "otPokemon");
            IntPtr desk = otpHandle;
            IntPtr dc = otpHandle;
            int a = (int)GetPixel(dc, x, y);
            ReleaseDC(desk, dc);
            return Color.FromArgb(255, (a >> 0) & 0xff, (a >> 8) & 0xff, (a >> 16) & 0xff);
            */
            int border_thickness = win32.GetSystemMetrics(win32.SystemMetric.SM_CYCAPTION);
            IntPtr hdc = GetWindowDC(Handle);
            Setting.offset = 8;
            uint pixel = GetPixel(hdc, x, y+Setting.offset);//experimentar
            //Cursor.Position = new System.Drawing.Point(x, y);
            ReleaseDC(Handle, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF), (int)(pixel & 0x0000FF00) >> 8, (int)(pixel & 0x00FF0000) >> 16);
            return pixel;
        }
        public static uint GetColorAtBattle(IntPtr Handle, int x, int y)
        {
            int border_thickness = win32.GetSystemMetrics(win32.SystemMetric.SM_CYCAPTION);
            IntPtr hdc = GetWindowDC(Handle);
            uint pixel = GetPixel(hdc, x, y - border_thickness);
            ReleaseDC(Handle, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF), (int)(pixel & 0x0000FF00) >> 8, (int)(pixel & 0x00FF0000) >> 16);
            return pixel;
        }
        public static string GrabPixel(int x, int y)
        {
            IntPtr Handle = win32.FindWindow(null, Setting.GameName);
            return Convert.ToString(getpixel.GetColorAt(Handle, x, y)); 
        }
    }
}
