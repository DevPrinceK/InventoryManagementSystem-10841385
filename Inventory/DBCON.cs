using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Inventory
{
    internal class DBCON
    {

        public static string connectionString = @"server=localhost;userid=root;password=;database=inventory_db;";
        //public static string connectionString = "mysql://root:wBtUVyEiTjJU5M0MuCI9@containers-us-west-37.railway.app:5696/railway";
        public static MySqlConnection conn = new MySqlConnection(connectionString);

        public static MySqlCommand cmd = new MySqlCommand();

        public static void OpenConnection()
        {
            try
            {
                conn.Open();
            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void CloseConnection()
        {
            try
            {
                conn.Close();
            } catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }





    }
}
