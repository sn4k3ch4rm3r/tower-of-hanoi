using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TowerOfHanoi.Components;

namespace TowerOfHanoi.Views
{
    public partial class Game : Form
    {
        private const int GOAL_INDEX = 1;
        public int DiskCount { get; set; } = 4;
        public int StepSize { get; set; } = 35;
        private DateTime startTime;
        public TimeSpan Time { get; private set; }

        private Timer timer;

        private Tower[] towers;
        public Game()
        {
            InitializeComponent();
            BackColor = Theme.Background;

            towers = new Tower[3];
            for (int i = 0; i < 3; i++)
            {
                Tower tower = new Tower();

                tower.Size = new Size((int)Math.Ceiling(ClientSize.Width/3f), (ClientSize.Height*2)/3);
                tower.Location = new Point(i*tower.Size.Width, ClientSize.Height - tower.Size.Height);

                tower.DragEnter += tower_DragEnter;
                tower.DragDrop += tower_DragDrop;
                tower.AllowDrop = true;

                Controls.Add(tower);
                towers[i] = tower;
            }
            for (int i = 0; i < DiskCount; i++)
            {
                Tower tower = towers[0];
                Disk disk = new Disk(i);
                disk.Width = tower.Width - (i+1)*StepSize;
                disk.Height = (tower.Height - tower.PoleWidth) / (DiskCount + 1);
                if (i != DiskCount - 1) { 
                    disk.Draggable = false;
                }
                disk.MouseDown += disk_MouseDown;
                tower.Controls.Add(disk);
            }

            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Clock_Tick;
            timer.Enabled = true;
            startTime = DateTime.Now;
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = DateTime.Now - startTime;
            clock.Text = $"{delta.Minutes.ToString().PadLeft(2, '0')}:{delta.Seconds.ToString().PadLeft(2, '0')}.{delta.Milliseconds/100}";
            clock.Location = new Point(ClientSize.Width / 2 - clock.Width / 2, 50);
        }

        private void disk_MouseDown(object sender, MouseEventArgs e)
        {
            Disk obj = sender as Disk;
            if (obj.Draggable)
            {
                obj.DoDragDrop(obj, DragDropEffects.Move);
            }
        }

        private void tower_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if ((sender as Tower).CanDrop(e.Data.GetData(typeof(Disk)) as Disk))
                e.Effect = DragDropEffects.Move;
        }

        private void tower_DragDrop(object sender, DragEventArgs e)
        {
            Disk disk = e.Data.GetData(typeof(Disk)) as Disk;
            (sender as Tower).Controls.Add(disk);
            if(towers[GOAL_INDEX].Controls.Count == DiskCount)
            {
                Time = startTime - DateTime.Now;
                timer.Stop();
                MessageBox.Show("Sikeres megoldás!");
                this.Close();
            }
        }
    }
}
