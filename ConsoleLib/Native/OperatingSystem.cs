using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLib.Native
{
    internal class Platform
    {
        internal static bool Windows
        {
            get
            {
                return (int)Environment.OSVersion.Platform < 4;
            }
        }

        internal static bool Unix
        {
            get
            {
                return !Windows;
            }
        }
    }
}
