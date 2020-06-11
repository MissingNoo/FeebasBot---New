using FeebasBot.Classes;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace FeebasBot
{
    public class win32
    {
        public const int PROCESS_WM_READ = 0x0010;

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern Int32 ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress,[In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesRead);


        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, IntPtr dwExtraInfo);
        // Get a handle to an application window.
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
            string lpWindowName);
        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
        public static int MakeLParam(int x, int y) => (y << 16) | (x & 0xFFFF);

        public const int WM_LBUTTONDOWN = 0x201;
        public const int WM_LBUTTONUP = 0x202;
        public const int WM_RBUTTONUP = 0x0205;
        public const int WM_RBUTTONDOWN = 0x0204;
        public const int WM_MOUSEMOVE = 0x0200;
        public const int MK_LBUTTON = 0x0001;
        public const int MK_RBUTTON = 0x0002;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "BlockInput")]
        [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
        public static extern bool BlockInput([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool fBlockIt);

        public static void FreezeMouse()
        {
            BlockInput(true);
        }

        public static void ThawMouse()
        {
            BlockInput(false);
        }

        [Flags]
        public enum MouseEventFlags
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }
        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(SystemMetric smIndex);
        public enum SystemMetric
        {
            SM_CXSCREEN = 0,  // 0x00
            SM_CYSCREEN = 1,  // 0x01
            SM_CXVSCROLL = 2,  // 0x02
            SM_CYHSCROLL = 3,  // 0x03
            SM_CYCAPTION = 4,
        }
        
        private static IntPtr CreateLParam(int LoWord, int HiWord)
        {
            return (IntPtr)((HiWord << 16) | (LoWord & 0xffff));
        }
        public static void LeftClickOld(IntPtr handle, int x, int y)
        {
            SetForegroundWindow(handle);
            Cursor.Position = new System.Drawing.Point(x, y);
            Thread.Sleep(150);
            mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, CreateLParam(x, y));
            mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, CreateLParam(x, y));
            //Thread.Sleep(200);
            //ThawMouse();
            //SendMessage(handle, WM_LBUTTONDOWN, 0x00000001, CreateLParam(x, y));
            //SendMessage(handle, WM_LBUTTONUP, 0x00000000, CreateLParam(x, y));
        }
        public static void LeftClick(int x, int y)
        {
            if (Setting.click == false && Setting.clicklock == false)
            {
                Setting.click = true;
                IntPtr hWindow = win32.FindWindow(null, Setting.GameName);
                int border_thickness = GetSystemMetrics(SystemMetric.SM_CYCAPTION);
                PostMessage(hWindow, WM_MOUSEMOVE, 0, MakeLParam(x, y - border_thickness));
                PostMessage(hWindow, WM_LBUTTONDOWN, MK_LBUTTON, MakeLParam(x, y - border_thickness));
                PostMessage(hWindow, WM_MOUSEMOVE, MK_LBUTTON, MakeLParam(x, y - border_thickness));
                PostMessage(hWindow, WM_LBUTTONUP, 0, MakeLParam(x, y - border_thickness));
                //Cursor.Position = new System.Drawing.Point(x, y - border_thickness);
                Setting.click = false;
            }
        }
        public static void LeftClickLocked(int x, int y)
        {
            Setting.click = true;
            IntPtr hWindow = win32.FindWindow(null, Setting.GameName);
            int border_thickness = GetSystemMetrics(SystemMetric.SM_CYCAPTION);
            PostMessage(hWindow, WM_MOUSEMOVE, 0, MakeLParam(x, y - border_thickness));
            PostMessage(hWindow, WM_LBUTTONDOWN, MK_LBUTTON, MakeLParam(x, y - border_thickness));
            PostMessage(hWindow, WM_MOUSEMOVE, MK_LBUTTON, MakeLParam(x, y - border_thickness));
            PostMessage(hWindow, WM_LBUTTONUP, 0, MakeLParam(x, y - border_thickness));
            //Cursor.Position = new System.Drawing.Point(x, y - border_thickness);
            Setting.click = false;
        }
        public static void MoveMouse(int x, int y)
        {
            IntPtr hWindow = win32.FindWindow(null, Setting.GameName);
            int border_thickness = GetSystemMetrics(SystemMetric.SM_CYCAPTION);
            PostMessage(hWindow, WM_MOUSEMOVE, 0, MakeLParam(x, y - border_thickness));
            PostMessage(hWindow, WM_MOUSEMOVE, MK_LBUTTON, MakeLParam(x, y - border_thickness));
            //Cursor.Position = new System.Drawing.Point(x, y - border_thickness);
        }
        public static void RightClick(int x, int y)
        {
            if (Setting.click == false && Setting.clicklock == false)
            {
                Setting.click = true;
                IntPtr hWindow = win32.FindWindow(null, Setting.GameName);
                int border_thickness = GetSystemMetrics(SystemMetric.SM_CYCAPTION);
                PostMessage(hWindow, WM_MOUSEMOVE, 0, MakeLParam(x, y - border_thickness));
                PostMessage(hWindow, WM_RBUTTONDOWN, MK_RBUTTON, MakeLParam(x, y - border_thickness));
                PostMessage(hWindow, WM_MOUSEMOVE, MK_RBUTTON, MakeLParam(x, y - border_thickness));
                PostMessage(hWindow, WM_RBUTTONUP, 0, MakeLParam(x, y - border_thickness));
                Setting.click = false;
            }
        }
        public static void RightClickLocked(int x, int y)
        {
            Setting.click = true;
            IntPtr hWindow = win32.FindWindow(null, Setting.GameName);
            int border_thickness = GetSystemMetrics(SystemMetric.SM_CYCAPTION);
            PostMessage(hWindow, WM_MOUSEMOVE, 0, MakeLParam(x, y - border_thickness));
            PostMessage(hWindow, WM_RBUTTONDOWN, MK_RBUTTON, MakeLParam(x, y - border_thickness));
            PostMessage(hWindow, WM_MOUSEMOVE, MK_RBUTTON, MakeLParam(x, y - border_thickness));
            PostMessage(hWindow, WM_RBUTTONUP, 0, MakeLParam(x, y - border_thickness));
            Setting.click = false;
        }
        public static void RightClickOld(IntPtr handle, int x, int y)
        {
            SetForegroundWindow(handle);
            Cursor.Position = new System.Drawing.Point(x, y);
            Thread.Sleep(250);
            mouse_event((int)(MouseEventFlags.RIGHTDOWN), 0, 0, 0, CreateLParam(x, y));
            mouse_event((int)(MouseEventFlags.RIGHTUP), 0, 0, 0, CreateLParam(x, y));
            //ThawMouse();
            //SendMessage(handle, WM_LBUTTONDOWN, 0x00000001, CreateLParam(x, y));
            //SendMessage(handle, WM_LBUTTONUP, 0x00000000, CreateLParam(x, y));
        }
        [DllImport("user32.dll")]
        public static extern bool SetWindowText(IntPtr hWnd, string text);
        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        const uint WM_KEYDOWN = 0x0100;
        const uint WM_KEYUP = 0x0101;
        public static void SendKeys(Keys vk_key)
        {
            IntPtr otpHandle = win32.FindWindow(null, Setting.GameName);
            PostMessage(otpHandle, WM_KEYDOWN, (IntPtr)vk_key, IntPtr.Zero);
            PostMessage(otpHandle, WM_KEYUP, (IntPtr)vk_key, IntPtr.Zero);
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("User32.dll")]
        public static extern void ReleaseDC(IntPtr hwnd, IntPtr dc);
    }
}
