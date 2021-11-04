
namespace TowerOfHanoi.Views
{
    partial class Game
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
            this.tower3 = new TowerOfHanoi.Components.Tower();
            this.tower2 = new TowerOfHanoi.Components.Tower();
            this.tower1 = new TowerOfHanoi.Components.Tower();
            this.SuspendLayout();
            // 
            // tower3
            // 
            this.tower3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(139)))));
            this.tower3.Location = new System.Drawing.Point(509, 112);
            this.tower3.Name = "tower3";
            this.tower3.PoleColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tower3.PoleWidth = 20;
            this.tower3.Size = new System.Drawing.Size(219, 251);
            this.tower3.TabIndex = 2;
            this.tower3.Text = "tower3";
            // 
            // tower2
            // 
            this.tower2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(139)))));
            this.tower2.Location = new System.Drawing.Point(293, 112);
            this.tower2.Name = "tower2";
            this.tower2.PoleColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tower2.PoleWidth = 20;
            this.tower2.Size = new System.Drawing.Size(219, 251);
            this.tower2.TabIndex = 1;
            this.tower2.Text = "tower2";
            // 
            // tower1
            // 
            this.tower1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tower1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(139)))));
            this.tower1.Location = new System.Drawing.Point(78, 112);
            this.tower1.Name = "tower1";
            this.tower1.PoleColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.tower1.PoleWidth = 20;
            this.tower1.Size = new System.Drawing.Size(219, 251);
            this.tower1.TabIndex = 0;
            this.tower1.Text = "tower1";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tower3);
            this.Controls.Add(this.tower2);
            this.Controls.Add(this.tower1);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.Tower tower1;
        private Components.Tower tower2;
        private Components.Tower tower3;
    }
}