using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeTest
{
    internal class DBConnection
    {
        /*==========================================================================*/
        /*===================    Database Connectivity    ==========================*/
        /*==========================================================================*/


        private MySqlConnection conn = null;
        private string url = "datasource=localhost; database=lift_system; port=3306; User=root; Password=root";

        public MySqlConnection Connect()
        {
            try
            {
                conn = new MySqlConnection(url);
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            Console.WriteLine("Database connection successfully!!");
            return conn;
        }

        /*==========================================================================*/
        /*==========================================================================*/

        /*==========================================================================*/
        /*===================  Database Connectivity Close   =======================*/
        /*==========================================================================*/

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
                Console.WriteLine("Error" + ex.Message);
            }
            return result;
        }

        /*==========================================================================*/
        /*==========================================================================*/

    }
}
