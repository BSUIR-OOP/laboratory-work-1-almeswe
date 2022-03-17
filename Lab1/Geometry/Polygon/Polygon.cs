using System;
using System.Drawing;

namespace Geometry
{
    public class Polygon : Shape
    {
        protected Point[] _points;

        public Polygon(params Point[] points) =>
            this._points = points;

        public override void Draw(Graphics g)
        {
            if (this._points.Length <= 0)
                throw new ArgumentException();
            g.DrawPolygon(this._defaultPen, this._points);
        }
    }
}