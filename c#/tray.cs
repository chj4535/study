using System;
using System.Runtime.InteropServices;

class NotTooSafeStringReverse
{
    static void Main()
    {
      IntPtr hwnd = NativeMethods.FindWindow("Shell_TrayWnd", Nothing);

    }
}
