using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Tower_of_Hanoi.Components
{
    public class MaterialButton : Control
    {
        public override Color BackColor { get; set; } = Color.Blue;
        public MaterialButton()
        {

        }

        public static GraphicsPath CreateRoundRect(int x, int y, int w, int h, int r)
        {
            int r2 = r * 2;

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

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            //e.Graphics.FillRectangle(new SolidBrush(BackColor), 0, 0, Width, Height);
            Graphics gfx = e.Graphics;
            GraphicsPath gfxPath = CreateRoundRect(0, 0, Width, Height, 100);
            Region region = new Region(gfxPath);

            SmoothingMode originalAliasing = gfx.SmoothingMode;
            gfx.SmoothingMode = SmoothingMode.HighQuality;
            gfx.FillPath(new SolidBrush(BackColor), gfxPath);
            //gfx.DrawPath(new Pen(fillColor), gfxPath);
            gfx.SetClip(region, CombineMode.Replace);
            gfx.SmoothingMode = originalAliasing;
        }
    }
}
