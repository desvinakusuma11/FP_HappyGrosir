using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HappyGrosir
{
    internal class Barang
    {
        MYDB db = new MYDB();

        public Boolean addBarang(int kdBarang, string name, int Sum)
        {

            string query = "INSERT INTO `data_barang`(`kd_barang`, `nama_barang`, `jumlah`) " +
                "VALUES (@kdBarang, @nmBarang, @jmlBarang)";

            MySqlParameter[] parameters = new MySqlParameter[3];
            parameters[0] = new MySqlParameter("@kdBarang", MySqlDbType.Int32);
            parameters[0].Value = kdBarang;

            parameters[1] = new MySqlParameter("@nmBarang", MySqlDbType.VarChar);
            parameters[1].Value = name;

            parameters[2] = new MySqlParameter("@jmlBarang", MySqlDbType.VarChar);
            parameters[2].Value = Sum;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean removeBarang(int kdBarang)
        {
            string query = "DELETE FROM `data_barang` WHERE `kd_barang`=@kdBarang";

            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@kdBarang", MySqlDbType.VarChar);
            parameters[0].Value = kdBarang;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public Boolean cariBarang(int name)
        {
            string query = "SELECT * FROM `data_barang` WHERE `kode_barang` = @nmBarang";

            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@nmBarang", MySqlDbType.Int32);
            parameters[0].Value = name;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable listBarang()
        {
            DataTable table = new DataTable();
            table = db.getData("SELECT * FROM `data_barang`", null);

            return table;
        }
    }
}
