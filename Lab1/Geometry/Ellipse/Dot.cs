using System.Drawing;

namespace Geometry
{
    public sealed class Dot : Circle
    {
        public Dot(Point point) 
            : base(1, point) { }

        public Dot(int x, int y)
            : this(new Point(x, y)) { }
    }
}
