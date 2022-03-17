using System.Drawing;

namespace Geometry
{
    public sealed class Triangle : Polygon
    {
        public Triangle(Point left, Point center, Point right)
            : base(left, center, right) { }

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
            : this(new Point(x1, y1), new Point(x2, y2), new Point(x3, y3)) { }
    }
}