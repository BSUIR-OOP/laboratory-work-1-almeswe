using System.Drawing;

namespace Geometry
{
    public sealed class Square : Rect
    {
        public Square(Point point, int side) 
            : base(point, side, side) { }
    }
}