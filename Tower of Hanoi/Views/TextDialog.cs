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
    public partial class TextDialog : Form
    {
        private double _value = 0;
        public double Value { get => _value; private set => value = _value; }
        
        public TextDialog()
        {
            InitializeComponent();
        }

        private void done()
        {
            double.TryParse(textBox1.Text, out _value);
            this.Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            done();
        }

        private void TextDialog_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                done();
            }
        }
    }
}
