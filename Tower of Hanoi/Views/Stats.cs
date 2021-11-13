using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerOfHanoi.Views
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
            output.Location = new Point(0, 0);
            output.Size = this.ClientSize;
        }

        private void Stats_Resize(object sender, EventArgs e)
        {
            output.Size = this.ClientSize;
        }
    }
}
