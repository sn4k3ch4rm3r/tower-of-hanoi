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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            CenterButtons();
        }

        private void CenterButtons()
        {
            int padding = 5;
            btn_login.Location = new Point(this.ClientSize.Width / 2 - btn_login.Width / 2, this.ClientSize.Height / 2 - btn_login.Height / 2 - btn_login.Height - padding);
            btn_play.Location = new Point(this.ClientSize.Width / 2 - btn_play.Width / 2, this.ClientSize.Height / 2 - btn_play.Height / 2);
            btn_stats.Location = new Point(this.ClientSize.Width / 2 - btn_stats.Width / 2, this.ClientSize.Height / 2 - btn_stats.Height / 2 + btn_stats.Height + padding);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CenterButtons();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            Form gameForm = new Game();
            gameForm.FormClosed += GameForm_FormClosed;
            gameForm.Show();
            this.Hide();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
