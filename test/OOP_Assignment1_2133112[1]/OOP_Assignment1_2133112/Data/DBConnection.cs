using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment1_2133112.Data
{
    //mydb
    internal class DBConnection
    {
        private MySqlConnection conn = null;
        private string url = "datasource=localhost; database=elevator; port=3306; User=root; Password=root";
        public MySqlConnection Connect()
        {
            try
            {
                conn = new MySqlConnection(url);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            return conn;
        }
        public bool Close(MySqlConnection conn)
        {
            bool result = false;
            try
            {
                conn.Close();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }
    }
}
