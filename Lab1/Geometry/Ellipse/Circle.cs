using System.Drawing;

namespace Geometry
{
    public class Circle : Ellipse
    {
        public Circle(int radius, Point center) 
            : base(radius, radius, center) { }

        public Circle(int radius, int x, int y) 
            : this(radius, new Point(x, y)) { }
    }
}
