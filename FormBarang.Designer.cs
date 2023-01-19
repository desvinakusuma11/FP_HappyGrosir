namespace HappyGrosir
{
    partial class FormBarang
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
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxCari = new System.Windows.Forms.TextBox();
            this.dgBarang = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Brown;
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHapus.Location = new System.Drawing.Point(780, 141);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(130, 61);
            this.btnHapus.TabIndex = 27;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click_1);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.Gold;
            this.btnCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCari.Location = new System.Drawing.Point(644, 141);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(130, 61);
            this.btnCari.TabIndex = 26;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = " Cari Barang :";
            // 
            // boxCari
            // 
            this.boxCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCari.Location = new System.Drawing.Point(2, 150);
            this.boxCari.Name = "boxCari";
            this.boxCari.Size = new System.Drawing.Size(636, 39);
            this.boxCari.TabIndex = 23;
            this.boxCari.TextChanged += new System.EventHandler(this.boxCari_TextChanged);
            // 
            // dgBarang
            // 
            this.dgBarang.AllowUserToAddRows = false;
            this.dgBarang.AllowUserToDeleteRows = false;
            this.dgBarang.AllowUserToResizeColumns = false;
            this.dgBarang.AllowUserToResizeRows = false;
            this.dgBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBarang.Location = new System.Drawing.Point(2, 208);
            this.dgBarang.Name = "dgBarang";
            this.dgBarang.ReadOnly = true;
            this.dgBarang.RowHeadersVisible = false;
            this.dgBarang.RowHeadersWidth = 62;
            this.dgBarang.RowTemplate.Height = 28;
            this.dgBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgBarang.Size = new System.Drawing.Size(908, 551);
            this.dgBarang.TabIndex = 21;
            this.dgBarang.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HappyGrosir.Properties.Resources.grocery_store;
            this.pictureBox3.Location = new System.Drawing.Point(9, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(950, 756);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxCari);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dgBarang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBarang";
            this.Text = "FormBarang";
            this.Load += new System.EventHandler(this.FormBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxCari;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dgBarang;
        private System.Windows.Forms.Label label3;
    }
}