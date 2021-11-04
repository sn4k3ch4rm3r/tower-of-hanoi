using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerOfHanoi.Components
{
    class Disk : Control
    {
        public int Level { get; set; } = 0;
        public override Cursor Cursor { get; set; } = Cursors.SizeAll;

        private bool isHovered = false;

        public Disk() { }
        public Disk(int level)
        {
            Level = level;
            BackColor = Theme.DiskColors[level];
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = RoundedRectangle.GetPath(new Rectangle(0, 0, Width, Height), 20);
            Region = new Region(path);
            if (isHovered)
            {
                e.Graphics.FillPath(new SolidBrush(Color.FromArgb(50, 0, 255, 0)), path);
            }
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
