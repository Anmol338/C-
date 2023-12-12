using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment1_2133112.Data
{
    internal class CrudOperation:DBConnection
    {
        public bool Insert(DetailsMw detailsMw)
        {
            string sql = "insert into elevator_log(details, beginDate, beginTime) values(@details, @beginDate, @beginTime);";
            bool result = false;
            try
            {
                MySqlConnection conn = Connect();
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlParameter[] sqlparams = new MySqlParameter[3];
                sqlparams[0] = new MySqlParameter("@details", detailsMw.Details);
                sqlparams[1] = new MySqlParameter("@beginDate", detailsMw.Begin_Date);
                sqlparams[2] = new MySqlParameter("@beginTime", detailsMw.Begin_Time);
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


        public ArrayList Displayall()
        {
            ArrayList Displaydata = new ArrayList();
            try
            {
                string sql = "SELECT * FROM elevator_log";
                MySqlConnection conn = Connect();
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DetailsMw detailsmw = new DetailsMw();
                    detailsmw.PID = reader.GetInt32("pid");
                    detailsmw.Details = reader.GetString("details");
                    detailsmw.Begin_Date= reader.GetDateOnly("beginDate").ToString("yyyy-MM-dd");
                    detailsmw.Begin_Time = reader.GetTimeOnly("beginTime").ToString("HH:mm:ss");
                    Displaydata.Add(detailsmw);
                }
                Close(conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            return Displaydata;
        }
    }
}

