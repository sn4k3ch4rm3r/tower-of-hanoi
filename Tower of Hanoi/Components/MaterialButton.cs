using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TowerOfHanoi.Components
{
    public class MaterialButton : Control
    {
        public override Color BackColor { get; set; } = Theme.Primary;
        public override Color ForeColor { get; set; } = Theme.OnPrimary;
        public int Radius { get; set; } = 40;

        private bool isHovered = false;

        public MaterialButton()
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            RectangleF rect = new RectangleF(0, 0, Width, Height);
            GraphicsPath GraphPath = RoundedRectangle.GetPath(rect, Radius);

            this.Region = new Region(GraphPath);
            if (isHovered)
            {
                e.Graphics.FillPath(new SolidBrush(Color.FromArgb(50, 0, 0, 0)), GraphPath);
            }


            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            e.Graphics.DrawString(Text.ToUpper(), Font, new SolidBrush(this.ForeColor), rect, sf);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovered = false;
            Invalidate();
        }
    }
}
