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
    public partial class TambahBarang : Form
    {
        public TambahBarang()
        {
            InitializeComponent();
        }

        Barang brg = new Barang();

        private void TambahBarang_Load(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            int kdBarang = Convert.ToInt32(txtKodeBarang.Text);
            string name = txtNamaBarang.Text;
            int jml = Convert.ToInt32(txtJumlahBarang.Text);

            if (name.Trim().Equals("") || kdBarang < 1 || jml < 1)
            {
                MessageBox.Show("Data Tidak Lengkap",
                    "Empty Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (brg.addBarang(kdBarang, name, jml))
                {
                    MessageBox.Show("New Item Added Successfully!",
                    "New Item",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    Form form = new Form1();
                    form.Show();
                    this.Close();

                    //dgGenres.DataSource = genre.GenresList();
                }
                else
                {
                    MessageBox.Show("Item Not Added",
                    "Add Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
    }
}
