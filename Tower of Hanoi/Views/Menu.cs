using System;
using System.Drawing;
using System.Windows.Forms;
using TowerOfHanoi.Components;
using TowerOfHanoi.Data;

namespace TowerOfHanoi.Views
{
    public partial class Menu : Form
    {
        private bool isLoggedIn = false;
        private User user;

        public Menu()
        {
            InitializeComponent();
            CenterButtons();
            this.BackColor = Theme.Background;
        }

        private void CenterButtons()
        {
            int padding = 10;
            btn_login.Location = new Point(this.ClientSize.Width / 2 - btn_login.Width / 2, this.ClientSize.Height / 2 - btn_login.Height / 2 - btn_login.Height - padding);
            btn_play.Location = new Point(this.ClientSize.Width / 2 - btn_play.Width / 2, this.ClientSize.Height / 2 - btn_play.Height / 2);
            btn_stats.Location = new Point(this.ClientSize.Width / 2 - btn_stats.Width / 2, this.ClientSize.Height / 2 - btn_stats.Height / 2 + btn_stats.Height + padding);
            label1.Location = new Point(this.ClientSize.Width / 2 - label1.Width / 2, this.ClientSize.Height / 2 - label1.Height / 2 - 2 * btn_login.Height - padding);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CenterButtons();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Nincs bejelentkezve!");
                return;
            }
            Form gameForm = new Game();
            gameForm.FormClosed += FormClosedHandler;
            gameForm.Show();
            this.Hide();
        }

        private void FormClosedHandler(object sender, FormClosedEventArgs e)
        {
            this.Show();
            if(sender.GetType() == typeof(Game))
            {
                Game game = sender as Game;
                DataHandler.Write(user, game.Time);
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
            {
                btn_login.Text = "Bejelentkezés";
                label1.Text = "Nincs bejelentkezve!";
                this.isLoggedIn = false;
            }
            else
            {
                Login login = new Login();
                login.ShowDialog();

                if (login.DialogResult != DialogResult.OK)
                    return;

                label1.Text = $"Bejelentkezve mint {login.UserData.Name} ({login.UserData.Age})";
                btn_login.Text = "Kijelentkezés";
                this.user = login.UserData;
                this.isLoggedIn = true;
            }
            CenterButtons();
        }

        private void btn_stats_Click(object sender, EventArgs e)
        {
            Stats stats = new Stats();
            stats.FormClosed += FormClosedHandler;
            stats.Show();
            this.Hide();
        }
    }
}
