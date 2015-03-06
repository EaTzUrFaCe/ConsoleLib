using System;

namespace ConsoleLib
{
    abstract class Widget
    {
        readonly Coord topLeftCorner;
        readonly Coord bottomRightCorner;
        readonly bool hasBorder;
        
        /// <summary>
        /// What layer of the drawing is this widget on?
        /// 
        /// 0 - lowest
        /// </summary>
        readonly int layer;
        public Widget parent { internal set; get; }

        public Widget(int x, int y, int width, int height, int layer = 0, bool hasBorder = false)
        {
            this.topLeftCorner = new Coord(x, y);
            this.bottomRightCorner = new Coord(x + width, y + height);
            this.layer = layer;
            this.hasBorder = hasBorder;
        }

        public Widget(Coord topLeftCorner, Coord bottomRightCorner, int layer = 0, bool hasBorder = false)
        {
            this.topLeftCorner = topLeftCorner;
            this.bottomRightCorner = bottomRightCorner;
            this.layer = layer;
            this.hasBorder = hasBorder;
        }

        public abstract void Draw();
    }
}
