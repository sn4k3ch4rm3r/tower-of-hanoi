namespace TowerOfHanoi.Views
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_login = new TowerOfHanoi.Components.MaterialButton();
            this.btn_play = new TowerOfHanoi.Components.MaterialButton();
            this.btn_stats = new TowerOfHanoi.Components.MaterialButton();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btn_login.Location = new System.Drawing.Point(116, 152);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Radius = 20;
            this.btn_login.Size = new System.Drawing.Size(304, 73);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Bejelentkezés";
            // 
            // btn_play
            // 
            this.btn_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_play.Location = new System.Drawing.Point(116, 233);
            this.btn_play.Margin = new System.Windows.Forms.Padding(4);
            this.btn_play.Name = "btn_play";
            this.btn_play.Radius = 20;
            this.btn_play.Size = new System.Drawing.Size(304, 73);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "Játék";
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_stats
            // 
            this.btn_stats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_stats.Location = new System.Drawing.Point(116, 314);
            this.btn_stats.Margin = new System.Windows.Forms.Padding(4);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Radius = 20;
            this.btn_stats.Size = new System.Drawing.Size(304, 73);
            this.btn_stats.TabIndex = 2;
            this.btn_stats.Text = "Statisztika";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(539, 554);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_stats);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private TowerOfHanoi.Components.MaterialButton btn_login;
        private TowerOfHanoi.Components.MaterialButton btn_play;
        private TowerOfHanoi.Components.MaterialButton btn_stats;
    }
}