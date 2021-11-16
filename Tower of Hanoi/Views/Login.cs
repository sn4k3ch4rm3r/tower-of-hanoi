using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TowerOfHanoi.Data;

namespace TowerOfHanoi.Views
{
    public partial class Login : Form
    {
        public User UserData { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (tbx_name.Text.Trim() == "" || tbx_name.Text.Contains(';'))
            {
                MessageBox.Show("Hibás név!");
                return;
            }
            UserData = new User(tbx_name.Text.Trim(), (int)num_age.Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
