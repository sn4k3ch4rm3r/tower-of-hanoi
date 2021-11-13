using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerOfHanoi.Components
{
    public class Tower : Control
    {
        public Tower() { }
        public Color PoleColor { get; set; } = Theme.Secondary;
        public int PoleWidth { get; set; } = 20;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            SolidBrush poleBrush = new SolidBrush(PoleColor);
            e.Graphics.FillRectangle(poleBrush, new Rectangle(0, Height - PoleWidth, Width, PoleWidth));
            e.Graphics.FillPath(poleBrush, RoundedRectangle.GetPath(new Rectangle(Width/2-PoleWidth/2, 0, PoleWidth, Height), PoleWidth/2));
            foreach (Control disk in Controls)
            {
                disk.Invalidate();
            }
        }

        public bool CanDrop(Disk disk)
        {
            return Controls.Count == 0 || (Controls[Controls.Count - 1] as Disk).Level <= disk.Level;
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);
            if(Controls.Count > 0)
                (Controls[Controls.Count - 1] as Disk).Draggable = true;
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            Disk disk = e.Control as Disk;
            int count = Controls.Count;
            if (count > 1)
                (Controls[count - 2] as Disk).Draggable = false;
            disk.Location = new Point(Width / 2 - disk.Width / 2, Height - PoleWidth - (count)*disk.Height);
        }
    }
}
