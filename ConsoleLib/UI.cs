using System;
using ConsoleLib.Native;

namespace ConsoleLib
{
    internal static class UI
    {
        internal static void Draw(int x, int y, char renderingChar)
        {
            if (Platform.Windows)
            {
                Win32.Draw(x, y, renderingChar);
            }
            else if (Platform.Unix)
            {
                throw new PlatformNotSupportedException("This Platform is not supported yet.");
            }
        }
    }
}
