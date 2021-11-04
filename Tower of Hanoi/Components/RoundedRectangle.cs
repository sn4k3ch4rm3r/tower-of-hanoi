using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Components
{
    public class RoundedRectangle
    {
        public static GraphicsPath GetPath(RectangleF rect, int radius)
        {
			int r2 = radius * 2;
			float x = rect.X;
			float y = rect.Y;
			float w = rect.Width;
			float h = rect.Height;

			GraphicsPath p = new GraphicsPath();
			p.AddArc(x, y, r2, r2, 180, 90);
			//p.AddLine(x + r, y, x + w - r, y);
			p.AddArc(x + w - r2, y, r2, r2, 270, 90);
			//p.AddLine(x + w, y + r, x + w, y + h - r);
			p.AddArc(x + w - r2, y + h - r2, r2, r2, 0, 90);
			//p.AddLine(x + r, y + h, x + w - r, y + h);
			p.AddArc(x, y + h - r2, r2, r2, 90, 90);
			p.CloseFigure();
			return p;
		}
    }
}
