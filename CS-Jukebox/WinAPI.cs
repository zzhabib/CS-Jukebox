using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CS_Jukebox
{
    public static class WinAPI
    {
        //Used to get Handle for Foreground Window
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr GetForegroundWindow();

        //Used to get ID of any Window
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);
        public delegate bool WindowEnumProc(IntPtr hwnd, IntPtr lparam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumChildWindows(IntPtr hwnd, WindowEnumProc callback, IntPtr lParam);
        private static Process _realProcess;

        public static string GetActiveProcess()
        {
            string app = "";
            var foregroundProcess = Process.GetProcessById(GetWindowProcessId(GetforegroundWindow()));
            if (foregroundProcess.ProcessName == "ApplicationFrameHost")
            {
                foregroundProcess = GetRealProcess(foregroundProcess);
            }
            if (foregroundProcess != null)
            {
                app = foregroundProcess.ProcessName;
            }
            return app;
        }

        private static int GetWindowProcessId(IntPtr hwnd)
        {
            int pid;
            GetWindowThreadProcessId(hwnd, out pid);
            return pid;
        }

        private static IntPtr GetforegroundWindow()
        {
            return GetForegroundWindow();
        }

        private static Process GetRealProcess(Process foregroundProcess)
        {
            EnumChildWindows(foregroundProcess.MainWindowHandle, ChildWindowCallback, IntPtr.Zero);
            return _realProcess;
        }

        private static bool ChildWindowCallback(IntPtr hwnd, IntPtr lparam)
        {
            var process = Process.GetProcessById(GetWindowProcessId(hwnd));
            if (process.ProcessName != "ApplicationFrameHost")
            {
                _realProcess = process;
            }
            return true;
        }
    }
}
