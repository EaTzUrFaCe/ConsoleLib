using System.Runtime.InteropServices;

namespace ConsoleLib
{
    [StructLayout(LayoutKind.Sequential)]
    struct Coord
    {
        public readonly short X;
        public readonly short Y;

        public Coord(short X, short Y)
        {
            this.X = X;
            this.Y = Y;
        }
        
        public Coord(int X, int Y)
        {
            this.X = (short)X;
            this.Y = (short)Y;
        }
    };
}
