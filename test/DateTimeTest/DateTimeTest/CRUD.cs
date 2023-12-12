using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeTest
{
    internal class CRUD:DBConnection
    {
        public bool Insert(string details, string date, string time)
        {
            string sql = "INSERT INTO lift_details(details, action_date, action_time) values(@details, @action_date, @action_time);";
            bool result = false;
            try
            {
                MySqlConnection conn = Connect();
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlParameter[] sqlparams = new MySqlParameter[3];
                sqlparams[0] = new MySqlParameter("@details", details);
                sqlparams[1] = new MySqlParameter("@action_date", date);
                sqlparams[2] = new MySqlParameter("@action_time", time);
                command.Parameters.Add(sqlparams[0]);
                command.Parameters.Add(sqlparams[1]);
                command.Parameters.Add(sqlparams[2]);
                object res = command.ExecuteNonQuery();
                Close(conn);
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                result = false;
            }
            return result;
        }
    }
}
