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
        public int DiskCount { get; set; } = 4;
        public int StepSize { get; set; } = 30;
        public Game()
        {
            InitializeComponent();
            for (int i = 0; i < DiskCount; i++)
            {
                Disk disk = new Disk(i);
                disk.Width = tower1.Width - (i+1)*StepSize;
                disk.Height = (tower1.Height - tower1.PoleWidth) / (DiskCount + 1);
                disk.Location = new Point((i+1)*(StepSize/2), tower1.Height - tower1.PoleWidth - (i+1)*disk.Height);
                tower1.Controls.Add(disk);
            }
        }
    }
}
