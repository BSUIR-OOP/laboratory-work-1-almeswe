using System.Drawing;

namespace Geometry
{
    public class Rect : Polygon
    {
        public Rect(Rectangle rect)
            : this(rect.Location, rect.Size) { }

        public Rect(Point point, Size size)
            : this(point, size.Width, size.Height) { }

        public Rect(Point point, int width, int height)
            : base(point, new Point(point.X + width, point.Y),
                  new Point(point.X + width, point.Y + height),
                    new Point(point.X, point.Y + height)) { }
    }
}