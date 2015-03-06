using System;
using System.Collections.Generic;

namespace ConsoleLib
{
    class Container:Widget
    {
        internal List<Widget> children;

        public Container(int x, int y, int width, int height, int layer = 0, bool hasBorder = false)
            : base(x, y, width, height, layer, hasBorder)
        {
            this.children = new List<Widget>();
        }

        public Container(Coord topLeftCorner, Coord bottomRightCorner, int layer = 0, bool hasBorder = false)
            : base(topLeftCorner, bottomRightCorner, layer, hasBorder)
        {
            this.children = new List<Widget>();
        }

        public override void Draw()
        {

        }

        public void AddChild(Widget child)
        {
            children.Add(child);
        }
    }
}
