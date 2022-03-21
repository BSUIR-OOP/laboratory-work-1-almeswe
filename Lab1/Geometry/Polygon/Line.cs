using System.Drawing;

namespace Geometry
{
    public sealed class Line : Polygon
    {
        public Line(Point start, Point end)
            : base(start, end) { }

        public Line(int x1, int y1, int x2, int y2)
            : this(new Point(x1, y1), new Point(x2, y2)) { }

        public override void Draw(Graphics g) =>
            g.DrawLine(this._defaultPen,
                this._points[0], this._points[1]);
    }
}