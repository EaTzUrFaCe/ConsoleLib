using System;

namespace ConsoleLib
{
    class Line:Widget
    {
        private enum Direction { HORIZONTAL, VERTICAL }



        public Line(int x, int y, int width, int height, int layer = 0, bool hasBorder = false)
            : base(x, y, width, height, layer, hasBorder)
        {
            if ((height == 1 && width == 1)||(height != 1 && width != 1))
            {

            }
        }

        public Line(Coord topLeftCorner, Coord bottomRightCorner, int layer = 0, bool hasBorder = false)
            : base(topLeftCorner, bottomRightCorner, layer, hasBorder)
        {
        }

        public override void Draw()
        {

        }
    }
}
