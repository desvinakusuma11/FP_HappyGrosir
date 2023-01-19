namespace HappyGrosir
{
    partial class Form1
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
            this.pnlBarang = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnTbhBarang = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBarang = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarang
            // 
            this.pnlBarang.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlBarang.Location = new System.Drawing.Point(354, -30);
            this.pnlBarang.Name = "pnlBarang";
            this.pnlBarang.Size = new System.Drawing.Size(1050, 805);
            this.pnlBarang.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnTbhBarang);
            this.panel1.Controls.Add(this.btnKeluar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnBarang);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 810);
            this.panel1.TabIndex = 15;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlNav.Location = new System.Drawing.Point(0, 286);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(8, 100);
            this.pnlNav.TabIndex = 8;
            this.pnlNav.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNav_Paint);
            // 
            // btnTbhBarang
            // 
            this.btnTbhBarang.BackColor = System.Drawing.Color.Transparent;
            this.btnTbhBarang.FlatAppearance.BorderSize = 0;
            this.btnTbhBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTbhBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTbhBarang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTbhBarang.Image = global::HappyGrosir.Properties.Resources.Icon_Plus_30_w;
            this.btnTbhBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTbhBarang.Location = new System.Drawing.Point(0, 339);
            this.btnTbhBarang.Name = "btnTbhBarang";
            this.btnTbhBarang.Size = new System.Drawing.Size(355, 60);
            this.btnTbhBarang.TabIndex = 7;
            this.btnTbhBarang.Text = "Tambah Barang";
            this.btnTbhBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTbhBarang.UseVisualStyleBackColor = false;
            this.btnTbhBarang.Click += new System.EventHandler(this.btnTbhBarang_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.BackColor = System.Drawing.Color.Transparent;
            this.btnKeluar.FlatAppearance.BorderSize = 0;
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKeluar.Image = global::HappyGrosir.Properties.Resources.Icon_Logout_30;
            this.btnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKeluar.Location = new System.Drawing.Point(6, 643);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(351, 78);
            this.btnKeluar.TabIndex = 6;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(79, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Happy Grosir";
            // 
            // btnBarang
            // 
            this.btnBarang.BackColor = System.Drawing.Color.Transparent;
            this.btnBarang.FlatAppearance.BorderSize = 0;
            this.btnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBarang.Image = global::HappyGrosir.Properties.Resources.Icon_Grosir_30;
            this.btnBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBarang.Location = new System.Drawing.Point(3, 262);
            this.btnBarang.Name = "btnBarang";
            this.btnBarang.Size = new System.Drawing.Size(354, 55);
            this.btnBarang.TabIndex = 3;
            this.btnBarang.Text = "Barang";
            this.btnBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarang.UseVisualStyleBackColor = false;
            this.btnBarang.Click += new System.EventHandler(this.btnBarang_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox2.Location = new System.Drawing.Point(0, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(358, 5);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HappyGrosir.Properties.Resources.Happy_Grosir_2_1__1_;
            this.pictureBox1.Location = new System.Drawing.Point(85, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(354, -19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 783);
            this.Controls.Add(this.pnlBarang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Happy Grosir";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnTbhBarang;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBarang;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

