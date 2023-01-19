using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyGrosir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlNav.Height = btnBarang.Height;
            pnlNav.Top = btnBarang.Top;
            pnlNav.Left = btnBarang.Left;
        }

        

        private void btnTbhBarang_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTbhBarang.Height;
            pnlNav.Top = btnTbhBarang.Top;
            btnTbhBarang.BackColor = Color.RoyalBlue;
            this.pnlBarang.Controls.Clear();
            TambahBarang tbhbrng = new TambahBarang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            tbhbrng.FormBorderStyle = FormBorderStyle.None;
            this.pnlBarang.Controls.Add(tbhbrng);
            tbhbrng.Show();
        }

        private void pnlNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pnlBarang.Controls.Clear();
            FormBarang frm_Barang = new FormBarang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_Barang.FormBorderStyle = FormBorderStyle.None;
            this.pnlBarang.Controls.Add(frm_Barang);
            frm_Barang.Show();
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnBarang.Height;
            pnlNav.Top = btnBarang.Top;
            btnBarang.BackColor = Color.RoyalBlue;
            this.pnlBarang.Controls.Clear();
            FormBarang frm_Barang = new FormBarang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_Barang.FormBorderStyle = FormBorderStyle.None;
            this.pnlBarang.Controls.Add(frm_Barang);
            frm_Barang.Show();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTbhBarang_Leave(object sender, EventArgs e)
        {
            btnTbhBarang.BackColor = Color.RoyalBlue;
        }

        private void btnBarang_Leave(object sender, EventArgs e)
        {
            btnBarang.BackColor = Color.RoyalBlue;
        }
    }
}
