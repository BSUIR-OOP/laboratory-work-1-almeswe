using System.Drawing;

namespace Geometry
{
    public class Ellipse : Shape
    {
        protected Rectangle _rect;

        public Ellipse(Size scale, Point center) =>
            this._rect = new Rectangle(center, scale);

        public Ellipse(int width, int height, Point center) =>
            this._rect = new Rectangle(center, new Size(width, height));

        public override void Draw(Graphics g) =>
            g.DrawEllipse(this._defaultPen, this._rect);
    }
}
