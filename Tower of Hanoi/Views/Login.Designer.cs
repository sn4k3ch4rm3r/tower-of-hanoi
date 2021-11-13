
namespace TowerOfHanoi.Views
{
    partial class Login
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
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_age = new System.Windows.Forms.NumericUpDown();
            this.materialButton1 = new TowerOfHanoi.Components.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.num_age)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_name
            // 
            this.tbx_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbx_name.Location = new System.Drawing.Point(113, 13);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(384, 38);
            this.tbx_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(45, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Életkor:";
            // 
            // num_age
            // 
            this.num_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_age.Location = new System.Drawing.Point(113, 58);
            this.num_age.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.num_age.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_age.Name = "num_age";
            this.num_age.Size = new System.Drawing.Size(384, 38);
            this.num_age.TabIndex = 5;
            this.num_age.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // materialButton1
            // 
            this.materialButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.materialButton1.Location = new System.Drawing.Point(17, 106);
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Radius = 20;
            this.materialButton1.Size = new System.Drawing.Size(480, 59);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Bejelentkezés";
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 177);
            this.Controls.Add(this.num_age);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.Text = "Login";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.num_age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Components.MaterialButton materialButton1;
        private System.Windows.Forms.NumericUpDown num_age;
    }
}