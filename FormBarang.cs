using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HappyGrosir
{
    public partial class FormBarang : Form
    {
        public FormBarang()
        {
            InitializeComponent();
        }

        Barang Brg = new Barang();

       
        private void FormBarang_Load(object sender, EventArgs e)
        {
            //dgBarang.Columns.Add("Column1", "no");


            dgBarang.DataSource = Brg.listBarang();
            /*for(int i=0;i<dgBarang.Rows.Count;i++)
            {
                dgBarang.Rows[i].Cells[0].Value = i+1;
            }*/

            dgBarang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgBarang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }


        private void btnCari_Click_1(object sender, EventArgs e)
        {
            MYDB db = new MYDB();

            string namaBarang = boxCari.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand(
                "SELECT * FROM `data_barang` WHERE `nama_barang`= @usn", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = namaBarang;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Barang Ditemukan", "Barang Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgBarang.DataSource = table;

            }
            else
            {
                if (namaBarang.Trim().Equals(""))
                {
                    dgBarang.DataSource = Brg.listBarang();
                    MessageBox.Show("Masukkan Nama Barang", "Barang Kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            int kdbarang = Convert.ToInt32(boxCari.Text);

            if (kdbarang < 1)
            {
                MessageBox.Show("Enter Kode Barang",
                    "Empty Items",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (Brg.removeBarang(kdbarang))
                {
                    MessageBox.Show("Remove Item Successfully!",
                    "Item Remove",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                    dgBarang.DataSource = Brg.listBarang();
                }
                else
                {
                    MessageBox.Show("Item Can't Find",
                    "Wrong Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void boxCari_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
