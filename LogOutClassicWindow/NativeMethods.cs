using System;
using System.Runtime.InteropServices;

namespace LogOutClassicWindow
{
    // Enums have been shorted to the only ones that are important
    internal class NativeMethods
    {
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool ExitWindowsEx(ExitWindows uFlags, ShutdownReason dwReason);

        [Flags]
        internal enum ExitWindows : uint
        {
            LogOff = 0x00,
        }

        [Flags]
        internal enum ShutdownReason : uint
        {
            MinorOther = 0x00000000,
        }
    }
}
