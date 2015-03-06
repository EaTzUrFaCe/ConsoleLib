using System;
using System.IO;
using System.Runtime.InteropServices;

using ConsoleLib;

using Microsoft.Win32.SafeHandles;

namespace ConsoleLib.Native
{
    /// <summary>
    /// Encapsulation Class for all calls to Native API
    /// </summary>
    internal static class Win32
    {
        #region NativeMethods

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern SafeFileHandle CreateFile(string fileName, [MarshalAs(UnmanagedType.U4)] uint fileAccess, [MarshalAs(UnmanagedType.U4)] uint fileShare, IntPtr securityAttributes, [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition, [MarshalAs(UnmanagedType.U4)] int flags, IntPtr template);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteConsoleOutputCharacter(SafeFileHandle hConsoleOutput, string lpCharacter, int nLength, Coord dwWriteCoord, ref int lpumberOfCharsWritten);        

        #endregion

        internal static void Draw(int x, int y, char renderingChar)
        {
            SafeFileHandle consoleHandle = CreateFile("CONOUT$", 0x40000000, 2, IntPtr.Zero, (FileMode)3, 0, IntPtr.Zero);
            int n = 0;
            WriteConsoleOutputCharacter(consoleHandle, renderingChar.ToString(), 1, new Coord((short)x, (short)y), ref n);
        }
    }
}
